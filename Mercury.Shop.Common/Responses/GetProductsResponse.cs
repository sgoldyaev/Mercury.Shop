using System.Collections.Generic;
using Mercury.Shop.Common.Dto;

namespace Mercury.Shop.Common.Responses
{
    public class GetProductsResponse
    {
        public IList<ProductShortInfo> Products { get; set; }
    }
}