using System;
using Mercury.Shop.Common.Dto;

namespace Mercury.Shop.Mvp.Events
{
    public class UpdateProductEventArgs : EventArgs
    {
        public ProductInfo Product { get; set; }
    }
}
