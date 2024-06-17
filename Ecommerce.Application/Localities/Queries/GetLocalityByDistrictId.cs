

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Localities.Dtos;
using Ecommerce.Application.Utilities.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Localities.Queries
{
    public class GetLocalityByDistrictId
    {
        public class Query : IRequest<List<GetLocalityDto>>
        {
            public long Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<GetLocalityDto>>
        {
            private readonly IRepository<Locality> _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<Locality> repository, IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public async Task<List<GetLocalityDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var localities = await _repository.Read()
                        .Include(x => x.District)
                        .Where(x => x.DistrictId == request.Id)
                        .Select(x => _mapper.Map<GetLocalityDto>(x))
                        .ToListAsync(cancellationToken);

                _logger.LogInformation($"The localities list for district with id {request.Id} was retrieved.");
                return localities;
            }
        }
    }
}
