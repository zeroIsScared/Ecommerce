

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyById
    {
        public class Query : IRequest<GetPropertyDto>
        {
            public long Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, GetPropertyDto>
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
            public async Task<GetPropertyDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var exist = await _repository.ExistsOrThrowsAsync(request.Id, cancellationToken);

                var property = await _repository.Read()
                    .Include(x => x.Currency)
                    .Include(x => x.Details)
                    .Include(x => x.Utilities)
                        .ThenInclude(x => x.Utility)
                    .Include(x => x.User)
                    .Include(x => x.Photos)
                    .Include(x => x.Address)
                        .ThenInclude(x => x.Locality)
                           .ThenInclude(x => x.District)
                  .FirstAsync(x => x.Id == request.Id, cancellationToken);               

                var result = _mapper.Map<GetPropertyDto>(property);

                _logger.LogInformation($"The property with id {request.Id} was retrieved.");

                return result;
            }
        }
    }
}
