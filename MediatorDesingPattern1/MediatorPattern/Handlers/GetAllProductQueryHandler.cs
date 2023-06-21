using MediatorDesingPattern1.DAL;
using MediatorDesingPattern1.MediatorPattern.Results;
using MediatorDesingPattern1gediatorPattern.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatorDesingPattern1.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {

                ProductID = x.ProductID,
                ProductCategory = x.ProductCategory,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStoct = x.ProductStoct
            }).ToListAsync();
        }
    }
}
