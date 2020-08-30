using Mercury.Shop.Common.Dto;

namespace Mercury.Shop.Common.Responses
{
    public class UpdateProductResponse
    {
        public string Message { get; set; }
        public ProductInfo Product { get; set; }
    }
}