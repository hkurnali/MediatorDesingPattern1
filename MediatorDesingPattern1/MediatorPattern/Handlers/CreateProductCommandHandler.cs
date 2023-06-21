using MediatorDesingPattern1.DAL;
using MediatorDesingPattern1.MediatorPattern.Commands;
using MediatR;

namespace MediatorDesingPattern1.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductCategory = request.ProductCategory,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStoct = request.ProductStoct


            });
            await _context.SaveChangesAsync();
        }

        
    }
}
