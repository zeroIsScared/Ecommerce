using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Users.Commands
{
    public class DeleteUser
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<User> _repository;

            public Handler(IRepository<User> repository)
            {
                _repository = repository;
            }

            public Task Handle(Command request, CancellationToken cancellationToken)
            {
                _repository.Remove(request.Id);
                return Task.CompletedTask;
            }
        }
    }
}