using System;
using System.Collections.Generic;
using Mercury.Shop.Common.Dto;
using Mercury.Shop.Mvp.Events;

namespace Mercury.Shop.Mvp.Views
{
    public interface IProductsView
    {
        event EventHandler GenerateProducts;
        event EventHandler Cancel; 
        event EventHandler<GetProductsEventArgs> GetProducts;
        event EventHandler<GetProductEventArgs> GetProduct; 
        event EventHandler<UpdateProductEventArgs> UpdateProduct;

        void ClearProductCollection();
        void ClearProductControl();
        void AddProductsToCollection(IList<ProductShortInfo> prod);
        void AddProductToControl(ProductInfo product);
        void UpdateProductInCollection(ProductInfo product);
        void Error(Exception e);
        void Message(string m);
        void ProgressOn();
        void ProgressOff();
    }
}
