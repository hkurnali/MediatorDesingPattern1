using MediatorDesingPattern1.MediatorPattern.Results;
using MediatR;

namespace MediatorDesingPattern1gediatorPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {

    }
}
