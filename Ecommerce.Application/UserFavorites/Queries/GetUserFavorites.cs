

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.UserFavorites.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.UserFavorites.Queries
{
    public class GetUserFavorites
    {
        public class Query : IRequest<Result<List<GetUserFavoritesDto>>>
        {
            public int UserId { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<List<GetUserFavoritesDto>>>
        {
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly IMapper _mapper;

            public Handler(IRepository<UserFavorite> userFavoriteRepository, IMapper mapper) 
            {
                _userFavoriteRepository = userFavoriteRepository;
                _mapper = mapper;
            }

            public Task<Result<List<GetUserFavoritesDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var userFavorites = _userFavoriteRepository.Read(false, true)
                    .Where(x => x.UserId == (long)request.UserId)
                    .Select(x => _mapper.Map<GetUserFavoritesDto>(x));
                
                return Task.FromResult(Result<List<GetUserFavoritesDto>>.Success(userFavorites.ToList()));
            }
        }
    }
}
