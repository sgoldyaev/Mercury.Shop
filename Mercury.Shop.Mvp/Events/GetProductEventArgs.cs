using System;

namespace Mercury.Shop.Mvp.Events
{
    public class GetProductEventArgs : EventArgs
    {
        public int ProductId { get; set; }
    }
}