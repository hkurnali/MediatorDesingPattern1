using MediatR;

namespace MediatorDesingPattern1.MediatorPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string ProductName { get; set; }
        public int ProductStoct { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; }
    }
}
