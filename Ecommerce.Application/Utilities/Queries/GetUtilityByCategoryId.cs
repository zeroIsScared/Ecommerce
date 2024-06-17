
using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Application.Utilities.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Utilities.Queries
{
    public class GetUtilityByCategoryId
    {
        public class Query : IRequest<List<GetUtilityDto>>
        {
            public long Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<GetUtilityDto>>
        {
            private readonly IRepository<Utility> _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<Utility> repository, IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public async Task<List<GetUtilityDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                /*     Apartment = 1, House = 2, Land = 3*/
                if (request.Id == 1)
                {
                    return await _repository.Read()
                        .Where(x => x.ForAppartment == true)
                        .Select(x => _mapper.Map<GetUtilityDto>(x))
                        .ToListAsync(cancellationToken);
                }
                else if (request.Id == 2)
                {
                    return await _repository.Read()
                        .Where(x => x.ForHouse == true)
                        .Select(x => _mapper.Map<GetUtilityDto>(x))
                        .ToListAsync(cancellationToken);
                }
                else if (request.Id == 3)
                {
                    return await _repository.Read()
                        .Where(x => x.ForLand == true)
                        .Select(x => _mapper.Map<GetUtilityDto>(x))
                        .ToListAsync(cancellationToken);
                }
                
                    _logger.LogInformation($"The utilities list for category with id {request.Id} was retrieved.");
                return null;
            }
        }
    }
}
