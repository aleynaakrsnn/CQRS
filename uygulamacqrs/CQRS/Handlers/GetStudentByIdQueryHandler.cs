using MediatR;
using System.Threading;
using System.Threading.Tasks;
using uygulamacqrs.CQRS.Queries;
using uygulamacqrs.CQRS.Results;
using uygulamacqrs.Data;

namespace uygulamacqrs.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, GetStudentByIdQueryResult>
    {
        private readonly ApplicationDbContext _context;
        public GetStudentByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _context.Set<Student>().FindAsync(request.Id);
            return new GetStudentByIdQueryResult
            {
                Age = student.Age,
                Name = student.Name,
                Surname = student.Surname
            };
        }
    }
