

using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Xml;

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
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<Property> repository, ILogger<Handler> logger)
            {
                _repository = repository;
                _logger = logger;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                Property property = await _repository.TryGetByIdOrThrowAsync(request.Id, cancellationToken);
                await _repository.SoftRemoveAsync(property.Id, cancellationToken);
                _logger.LogInformation($"Property with id {request.Id} was deleted.");
            }
        }
    }
}
