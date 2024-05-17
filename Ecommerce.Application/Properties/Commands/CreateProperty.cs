
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos.Responses;
using Ecommerce.Domain.Entities;
using FluentValidation;
using MediatR;

namespace Ecommerce.Application.Properties.Commands
{
    public class CreateProperty
    {
        public class Command : IRequest<int>
        {
            public required Property RealEstate { get; set; }
        }

        public class CommandValidator : AbstractValidator<GetPropertyDto>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Title).MaximumLength(50);
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IRepository<Property> _repository;

            public Handler(IRepository<Property> repository)
            {
                _repository = repository;
            }

            public Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var realEstate = new Property(
                   request.RealEstate.Title,
                   request.RealEstate.Description,
                   request.RealEstate.Price);
                /*realEstate.CreatedAt = DateTimeOffset.UtcNow;
                realEstate.CreatedBy = null;*/

                var property = _repository.Add(realEstate);

                return Task.FromResult((int)property.Id);
            }
        }
    }
}
