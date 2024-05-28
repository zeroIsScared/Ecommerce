using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Properties.Commands
{
    public class EditProperty
    {
        public class Command : IRequest<long>
        {
            public required Property Property { get; set; }
        }

        public class Handler : IRequestHandler<Command, long>
        {
            private readonly IRepository<Property> _repository;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<Property> repository, ILogger<Handler> logger)
            {
                _repository = repository;
                _logger = logger;
            }

            public async Task<long> Handle(Command request, CancellationToken cancellationToken)
            {
                await _repository.TryGetByIdOrThrowAsync(request.Property.Id, cancellationToken);
                await _repository.UpdateAsync(request.Property, cancellationToken);
                var updatedId = request.Property.Id;
                _logger.LogInformation($"Property with id {request.Property.Id} was deleted.");
                return updatedId;
            }
        }
    }


}
