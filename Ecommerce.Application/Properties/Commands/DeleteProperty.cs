

using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Properties.Commands
{
    public class DeleteProperty
    {
        public class Command : IRequest        {
            public required int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<Property> _repository;

            public Handler(IRepository<Property> repository)
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
