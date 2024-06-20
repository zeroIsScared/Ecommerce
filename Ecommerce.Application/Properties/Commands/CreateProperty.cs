
using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;


namespace Ecommerce.Application.Properties.Commands
{
    public class CreateProperty
    {
        public class Command : IRequest<CreateOrUpdatePropertyDto>
        {
            public required CreateOrUpdatePropertyDto RealEstate { get; set; }
        }

        public class CommandValidator : AbstractValidator<CreateOrUpdatePropertyDto>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Title).MaximumLength(50);
                RuleFor(x => x.Description).
            }
        }

        public class Handler : IRequestHandler<Command, CreateOrUpdatePropertyDto>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<Property> repository, IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public async Task<CreateOrUpdatePropertyDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var realEstate = _mapper.Map<Property>(request.RealEstate);              

                var property =  await _repository.AddAsync(realEstate, cancellationToken);

                var createdProperty = _mapper.Map<CreateOrUpdatePropertyDto>(property);

                _logger.LogInformation($"Property with id {realEstate.Id} was created.");
              
                return createdProperty;
            }
        }
    }
}
