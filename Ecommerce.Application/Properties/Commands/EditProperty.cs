using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

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

            public Handler(IRepository<Property> repository)
            {
                _repository = repository;
            }

            public async Task<long> Handle(Command request, CancellationToken cancellationToken)
            {
                Property property = await _repository.TryGetByIdOrThrowAsync(request.Property.Id, cancellationToken);
                await _repository.UpdateAsync(request.Property);
                var updatedId = request.Property.Id;
                return updatedId;
            }
        }
    }


}
