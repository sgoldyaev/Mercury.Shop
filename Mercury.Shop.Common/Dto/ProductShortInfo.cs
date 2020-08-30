using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury.Shop.Common.Dto
{
    public class ProductShortInfo
    {
        public int Id { get; set; }
        public int Model { get; set; }
        public int Material { get; set; }
        public int Color { get; set; }
        public string Name { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool BestSellers { get; set; }
    }
}
