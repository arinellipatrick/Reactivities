using Domain;
using MediatR;

namespace Application.Products
{
    public class List
    {
        public class Query : IRequest<List<Activity>> {}
    }
}