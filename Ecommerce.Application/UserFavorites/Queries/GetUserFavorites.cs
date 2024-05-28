

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.UserFavorites.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.UserFavorites.Queries
{
    public class GetUserFavorites
    {
        public class Query : IRequest<List<GetUserFavoritesDto>>
        {
            public long UserId { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<GetUserFavoritesDto>>
        {
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<UserFavorite> userFavoriteRepository, IMapper mapper, ILogger<Handler> logger) 
            {
                _userFavoriteRepository = userFavoriteRepository;
                _mapper = mapper;
                _logger = logger;
            }

            public async Task<List<GetUserFavoritesDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var userFavorites = await _userFavoriteRepository.Read(true)
                    .Include(x => x.Property)
                        .ThenInclude(x => x.Currency)
                    .Include(x => x.Property)
                        .ThenInclude(x => x.Address)
                            .ThenInclude(x => x.Locality)
                                .ThenInclude(x => x.District)
                    .Include(x => x.Property)
                        .ThenInclude(x => x.Details)
                    .Include(x => x.Property)
                        .ThenInclude(x => x.Utilities)
                    .Include(x => x.Property)
                        .ThenInclude(x => x.Photos)                   
                    .Where(x => x.UserId == request.UserId)
                    .ToListAsync(cancellationToken);

                var result = _mapper.Map<List<GetUserFavoritesDto>>(userFavorites);

                _logger.LogInformation($"The properties favorites was retrieved from user with id {request.UserId}.");

                return result;
            }
        }
    }
}
