using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetListOfProperties
    {
        public class Query : IRequest<List<GetPropertiesDto>> { }

        public class Handler : IRequestHandler<Query, List<GetPropertiesDto>>
        {
            private readonly IRepository<Property> _repository;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<Property> repository, ILogger<Handler> logger)
            {
                _repository = repository;
                _logger = logger;
            }

            public async Task<List<GetPropertiesDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _repository.Read(false)
                    .Include(x => x.Currency)
                    .Include(x => x.Photos)
                    .Include(x => x.User)
                    .Select(x => new GetPropertiesDto 
                    {  
                        Id = x.Id,
                        Title = x.Title,
                        Currency = x.Currency.Symbol ?? x.Currency.Code,
                        Price = x.Price,
                        PhotoURL = x.Photos.First().URL,
                        UserId = x.User.Id,
                    })
                    .ToListAsync(cancellationToken);

                _logger.LogInformation($"The list of all properties was retrieved");

                return result;
            }
        }
    }
}
