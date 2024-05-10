

using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Property.Responses;
using Ecommerce.Domain.Entities;
using FluentValidation;
using MediatR;
using System.Reflection;

namespace Ecommerce.Application.Properties.Create
{
    public class CreateProperty
    {
        public class Command : IRequest<int>
        {
            public required Domain.Entities.Property RealEstate { get; set; }
        }

        public class CommandValidator : AbstractValidator<PropertyDto>
        {
            public CommandValidator() 
            {
                RuleFor(x => x.Title).MaximumLength(50);
            }
        }


        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IRepository<Domain.Entities.Property> _repository;

            public Handler( IRepository<Domain.Entities.Property> repository)
            {
                _repository = repository;
            }

            public Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var realEstate = new Domain.Entities.Property(
                   request.RealEstate.Title,        
                   request.RealEstate.Description, 
                   request.RealEstate.Price);  
                realEstate.CreatedAt = DateTimeOffset.UtcNow;
                realEstate.CreatedBy = null;

                var property = _repository.Add(realEstate);
                
                return Task.FromResult((int)property.Id);
            }
        }
    }
}
