
using AutoMapper;
using Azure;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;

namespace Ecommerce.Application.Properties.Commands
{
    public class CreateProperty
    {
        public class Command : IRequest<CreatePropertyDto>
        {
            public required CreatePropertyDto RealEstate { get; set; }
        }

        public class CommandValidator : AbstractValidator<CreatePropertyDto>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Title).MaximumLength(50);
            }
        }

        public class Handler : IRequestHandler<Command, CreatePropertyDto>
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

            public async Task<CreatePropertyDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var realEstate = _mapper.Map<Property>(request.RealEstate);              

                var property =  await _repository.AddAsync(realEstate, cancellationToken);

                var createdProperty = _mapper.Map<CreatePropertyDto>(property);

                _logger.LogInformation($"Loggin here:{request}");
              
                return createdProperty;
            }
        }
    }
}
