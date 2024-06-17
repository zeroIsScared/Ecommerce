using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Properties.Commands
{
    public class EditProperty
    {
        public class Command : IRequest<CreateOrUpdatePropertyDto>
        {
            public required CreateOrUpdatePropertyDto RealEstate { get; set; }
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
                await _repository.ExistsOrThrowsAsync((long)request.RealEstate.Id!, cancellationToken);                
            
                var realEstate = _mapper.Map<Property>(request.RealEstate);             

                var property = await _repository.UpdateAsync(realEstate, cancellationToken);

                var updatedProperty = _mapper.Map<CreateOrUpdatePropertyDto>(property);              
              
                
                _logger.LogInformation($"Property with id {request.RealEstate.Id} was updated.");
                return updatedProperty ;
            }
        }
    }


}
