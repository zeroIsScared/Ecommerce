

using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Properties.Commands
{
    public class DeleteProperty
    {
        public class Command : IRequest      
        {
            public required long Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<Property> _repository;

            public Handler(IRepository<Property> repository)
            {
                _repository = repository;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                Property property = await _repository.TryGetByIdOrThrowAsync(request.Id, cancellationToken);
                await _repository.SoftRemoveAsync(property.Id, cancellationToken);                
            }
        }
    }
}
