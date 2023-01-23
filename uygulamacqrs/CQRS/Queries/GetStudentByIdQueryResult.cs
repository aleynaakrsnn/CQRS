

using MediatR;
using uygulamacqrs.CQRS.Results;

namespace uygulamacqrs.CQRS.Queries
{
    public class GetStudentByIdQuery : IRequest<GetStudentByIdQueryResult>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id = id;

        }
    }
}
