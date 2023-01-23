using MediatR;
using System.Threading;
using System.Threading.Tasks;
using uygulamacqrs.CQRS.Commands;
using uygulamacqrs.Data;

namespace uygulamacqrs.CQRS.Handlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly ApplicationDbContext _context;
        public CreateStudentCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            _context.Students.Add(new Student { Age = request.Age, Name = request.Name, Surname = request.Surname });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
