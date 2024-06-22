
using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Services;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
                RuleFor(x => x.Title).NotEmpty().MaximumLength(50);               
                RuleFor(x => x.Description).MaximumLength(500);
                RuleFor(x => x.Category).IsInEnum();
                RuleFor(x => x.TransactionType).IsInEnum();
                RuleFor(x => x.CurrencyId).InclusiveBetween(1, 3);
                RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
                RuleFor(x => x.Details.RoomNumber).InclusiveBetween(1, 99);
                RuleFor(x => x.Details.FloorsNumber).InclusiveBetween(1, 99);
                RuleFor(x => x.Details.State).IsInEnum();
                RuleFor(x => x.Details.AuthorType).IsInEnum();
                RuleFor(x => x.Details.BuildingType).IsInEnum();
                RuleFor(x => x.Details.ParkingType).IsInEnum();
                RuleFor(x => x.Details.LandType).IsInEnum();
                RuleFor(x => x.Address.LocalityId).NotEmpty();               
            }
        }

        public class Handler : IRequestHandler<Command, CreateOrUpdatePropertyDto>
        {
            private readonly IRepository<Property> _repository;
            private readonly IRepository<Locality> _localityRepository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;
            private readonly IDirectionService _directionservice;

            public Handler(IRepository<Property> repository, IRepository<Locality> localityRepository, IMapper mapper, ILogger<Handler> logger, IDirectionService directionservice)
            {
                _repository = repository;
                _localityRepository = localityRepository;
                _mapper = mapper;
                _logger = logger;
                _directionservice = directionservice;
            }

            public async Task<CreateOrUpdatePropertyDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var realEstate = _mapper.Map<Property>(request.RealEstate);

                var locality = _localityRepository.Read()
                    .Include(x => x.District)
                    .Where(x => x.Id == realEstate.Address.LocalityId)
                    .First();                   


               
                var address = $"{realEstate.Address.Street} {realEstate.Address.HouseNumber} {locality.Name} {locality.District.Name}";

                var coordinates = await _directionservice.GeocodeAddressAsync(address);

                realEstate.Address.Longitude = coordinates.First().Geometry.Location.Longitude.ToString();

                realEstate.Address.Latitude = coordinates.First().Geometry.Location.Latitude.ToString();

                var property =  await _repository.AddAsync(realEstate, cancellationToken);

                var createdProperty = _mapper.Map<CreateOrUpdatePropertyDto>(property);

                _logger.LogInformation($"Property with id {realEstate.Id} was created.");
              
                return createdProperty;
            }
        }
    }
}
