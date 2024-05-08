

using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Properties.Create
{
    public class EditProperty 
    {
        public class Command : IRequest<int>
        {
            public required Domain.Entities.Property Property { get; set; }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IRepository<Domain.Entities.Property> _repository;

            public Handler(IRepository<Domain.Entities.Property> repository)
            {
                _repository = repository;
            }

            public Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                _repository.Update(request.Property); 
                var updatedId = (int)request.Property.Id;
                return  Task.FromResult(updatedId);
            }
        }
    }

    
}
