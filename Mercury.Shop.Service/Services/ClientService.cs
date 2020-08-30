using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mercury.Shop.Common.Dto;
using Mercury.Shop.Common.Requests;
using Mercury.Shop.Common.Responses;
using Mercury.Shop.Dal;

namespace Mercury.Shop.Service.Services
{
    public class ClientService
    {
        private readonly CancellationToken token;

        public ClientService(CancellationToken token)
        {
            this.token = token;
        }

        public Task<GetProductsResponse> GetProducts(GetProductsRequest request)
        {
            var skip = request.PageNo * request.PageSize;
            var take = request.PageSize;

            return Task.Factory.StartNew(() =>
            {
                Debug.WriteLine("Quering DB. Current thread is " + System.Threading.Thread.CurrentThread.ManagedThreadId);
                using (var context = new MercuryDbConnection())
                {
                    var query = context.Product
                        .OrderBy(x => x.ID)
                        .Skip(skip)
                        .Take(take)
                        .Select(p => new ProductShortInfo
                        {
                            Id = p.ID,
                            BestSellers = p.BestSeller,
                            Color = p.Color,
                            Material = p.Material,
                            Model = p.Model,
                            ModifyDate = p.ModifyDate,
                            Name = p.Name,
                        });

                    return new GetProductsResponse { Products = query.ToList() };
                }
            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        public Task<GetProductResponse> GetProduct(GetProductRequest request)
        {
            return Task.Factory.StartNew(() =>
            {
                Debug.WriteLine("Quering DB. Current thread is " + System.Threading.Thread.CurrentThread.ManagedThreadId);
                using (var context = new MercuryDbConnection())
                {
                    var query = context.Product
                        .Where(p => p.ID == request.ProductId)
                        .Select(p => new ProductInfo
                        {
                            ModifyDate = p.ModifyDate,
                            Model = p.Model,
                            Id = p.ID,
                            Color = p.Color,
                            Name = p.Name,
                            BestSellers = p.BestSeller,
                            Material = p.Material,
                            Collection = p.Collection,
                            Comment = p.Comment,
                            CreateDate = p.CreateDate,
                            Private = p.Private,
                            RowVersion = p.RowVersion,
                            SellDate = p.SellDate,
                            VIP = p.VIP,
                        });

                    return new GetProductResponse { Product = query.FirstOrDefault() };
                }
            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        public Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest request)
        {
            return Task.Factory.StartNew(() =>
            {
                Debug.WriteLine("Quering DB. Current thread is " + System.Threading.Thread.CurrentThread.ManagedThreadId);

                var p = request.Product;
                using (var context = new MercuryDbConnection())
                {
                    var product = new Product {ID = p.Id, RowVersion = p.RowVersion};
                    context.Product.Attach(product);

                    product.Model = p.Model;
                    product.Color = p.Color;
                    product.Material = p.Material;
                    product.Name = p.Name;
                    product.Collection = p.Collection;
                    product.Comment = p.Comment;
                    product.ModifyDate = p.ModifyDate;
                    product.CreateDate = p.CreateDate;
                    product.SellDate = p.SellDate;
                    product.Private = p.Private;
                    product.VIP = p.VIP;
                    product.BestSeller = p.BestSellers;
                    context.Entry(product).State = EntityState.Modified;

                    context.SaveChanges();

                    // NOTE [sg]: get new rowVersion from Db and send to client.
                    p.RowVersion = product.RowVersion;
                }
                return new UpdateProductResponse {Message = "Запись успешно сохранена.", Product = p};

            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        public Task<GenerateProductsResponse> GenerateProducts(GenerateProductsRequest request)
        {
            return Task.Factory.StartNew(() =>
            {
                Debug.WriteLine("Quering DB. Current thread is " + System.Threading.Thread.CurrentThread.ManagedThreadId);

                //throw new Exception("WTF");

                using (var context = new MercuryDbConnection())
                {
                    ((IObjectContextAdapter)context).ObjectContext.CommandTimeout = 600;
                    context.GenerateMockProducts(request.Count);
                }
                return new GenerateProductsResponse {Message = "Тестовые данные сгенерированы успешно."};

            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }
    }
}
