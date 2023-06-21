using MediatorDesingPattern1.MediatorPattern.Queries;
using MediatorDesingPattern1.MediatorPattern.Results;
using MediatorDesingPattern1.MediatorPattern.Commands;
using MediatR;
using MediatorDesingPattern1.DAL;
using NuGet.Protocol.Plugins;

namespace MediatorDesingPattern1.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetUpdateProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetUpdateProductByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetUpdateProductByIDQueryResult
            {

                ProductCategory = values.ProductCategory,
                ProductName = values.ProductName,
                ProductID = values.ProductID,
                ProductPrice = values.ProductPrice,
                ProductStoct = values.ProductStoct

            };
        }
    }
}
