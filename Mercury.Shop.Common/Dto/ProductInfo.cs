using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shop.Common.Dto
{
    public class ProductInfo
    {
        public int Id { get; set; }
        public int Model { get; set; }
        public int Material { get; set; }
        public int Color { get; set; }
        public string Name { get; set; }
        public string Collection { get; set; }
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime SellDate { get; set; }
        public bool BestSellers { get; set; }
        public bool VIP { get; set; }
        public bool Private { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
