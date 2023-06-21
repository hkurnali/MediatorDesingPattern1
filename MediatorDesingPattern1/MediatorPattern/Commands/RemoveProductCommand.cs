using MediatR;

namespace MediatorDesingPattern1.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int id)
        {

            Id=id;
        }

        public int Id { get; set; }
    }
}
