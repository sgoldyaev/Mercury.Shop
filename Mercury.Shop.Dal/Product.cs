//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mercury.Shop.Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ID { get; set; }
        public int Model { get; set; }
        public int Material { get; set; }
        public int Color { get; set; }
        public string Name { get; set; }
        public string Collection { get; set; }
        public string Comment { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public System.DateTime SellDate { get; set; }
        public bool BestSeller { get; set; }
        public bool VIP { get; set; }
        public bool Private { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
