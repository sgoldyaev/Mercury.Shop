using System;

namespace Mercury.Shop.Mvp.Events
{
    public class GetProductsEventArgs : EventArgs
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
    }
}