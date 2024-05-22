
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
        public class Command : IRequest<int>
        {
            public required GetPropertyDto RealEstate { get; set; }
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
            private readonly IMapper _mapper;
            private readonly ILogger<Command> _logger;

            public Handler(IRepository<Property> repository, IMapper mapper, ILogger<Command> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var realEstate = _mapper.Map<Property>(request.RealEstate);
                /*realEstate.CreatedAt = DateTimeOffset.UtcNow;
                realEstate.CreatedBy = null;*/

                var property =  await _repository.AddAsync(realEstate, cancellationToken);
                var requestName = request.GetType().Name;        
              
                return await Task.FromResult((int)property.Id);
            }
        }
    }
}
