using MediatR;

namespace MediatorDesingPattern1.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<GetProductUpdateByIDQuery>
    {

        public GetProductUpdateByIDQuery(int id)
        {

            Id = id;
        }

        public int Id { get; set; }
    }
}
