

using AutoMapper;
using Ecommerce.Application.Districts.Dtos;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Districts.Queries
{
    public class GetAllDistricts 
    {
        public class Query : IRequest<List<GetDistrictDto>> { }     

        public class Handler : IRequestHandler<Query, List<GetDistrictDto>>
        {
            private readonly IRepository<District> _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<District> repository, IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public Task<List<GetDistrictDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var districts = _repository.Read()
                        .Select(x => _mapper.Map<GetDistrictDto>(x));

                _logger.LogInformation($"The list of all districts was retrieved.");
                return Task.FromResult(districts.ToList());
            }
        }
    }
}

