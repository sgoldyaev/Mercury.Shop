using System;
using System.Threading;
using Mercury.Shop.Common.Requests;
using Mercury.Shop.Mvp.Views;
using Mercury.Shop.Service.Services;

namespace Mercury.Shop.Mvp.Presenters
{
    public class ProductsPresenter : IDisposable
    {
        private const int MOCK_PRODUCTS = 1000;
        private CancellationTokenSource cts;
        private ClientService svc;
        private IProductsView view;

        public ProductsPresenter(IProductsView v)
        {
            cts = new CancellationTokenSource();
            svc = new ClientService(cts.Token);

            view = v;
            view.GenerateProducts += View_GenerateProducts;
            view.GetProducts += View_GetProducts;
            view.GetProduct += View_GetProduct;
            view.UpdateProduct += View_UpdateProduct;
            view.Cancel += View_Cancel;
        }

        public void Dispose()
        {
            view.GenerateProducts -= View_GenerateProducts;
            view.GetProducts -= View_GetProducts;
            view.GetProduct -= View_GetProduct;
            view.UpdateProduct -= View_UpdateProduct;
            view.Cancel -= View_Cancel;
            cts.Dispose();
        }

        private void View_Cancel(object sender, EventArgs e)
        {
            view.ProgressOff();
            view.Message("");
            cts.Cancel();

            cts = new CancellationTokenSource();
            svc = new ClientService(cts.Token);
            view.Message("Операция отменена");
        }

        private void View_UpdateProduct(object sender, Events.UpdateProductEventArgs e)
        {
            view.ProgressOn();
            view.Message("");

            var task = svc.UpdateProduct(new UpdateProductRequest { Product = e.Product });

            task.ContinueWhenOk(r =>
            {
                view.UpdateProductInCollection(r.Result.Product);
                view.Message(r.Result.Message);
                view.ProgressOff();
            }, cts.Token);

            task.ContinueWhenFail(r => 
            {
                view.Error(r.Exception);
                view.ProgressOff();
            }, cts.Token);
        }

        private void View_GetProduct(object sender, Events.GetProductEventArgs e)
        {
            view.ProgressOn();
            view.Message("");

            var task = svc.GetProduct(new GetProductRequest { ProductId = e.ProductId });

            task.ContinueWhenOk(r => 
            {
                view.AddProductToControl(r.Result.Product);
                view.ProgressOff();
            }, cts.Token);

            task.ContinueWhenFail(r => 
            {
                view.Error(r.Exception);
                view.ProgressOff();
            }, cts.Token);
        }

        private void View_GetProducts(object sender, Events.GetProductsEventArgs e)
        {
            view.ProgressOn();
            view.Message("");

            var task = svc.GetProducts(new GetProductsRequest { PageNo = e.PageNo, PageSize = e.PageSize });

            task.ContinueWhenOk(r =>
            {
                view.AddProductsToCollection(r.Result.Products);
                view.ProgressOff();
            }, cts.Token);

            task.ContinueWhenFail(r => 
            {
                view.Error(r.Exception);
                view.ProgressOff();
            }, cts.Token);
        }

        private void View_GenerateProducts(object sender, EventArgs e)
        {
            view.ProgressOn();
            view.Message("");

            var task = svc.GenerateProducts(new GenerateProductsRequest { Count = MOCK_PRODUCTS });

            task.ContinueWhenOk(r =>
            {
                view.Message(r.Result.Message);
                view.ProgressOff();
            }, cts.Token);

            task.ContinueWhenFail(r => 
            {
                view.Error(r.Exception);
                view.ProgressOff();
            }, cts.Token);
        }
    }
}
