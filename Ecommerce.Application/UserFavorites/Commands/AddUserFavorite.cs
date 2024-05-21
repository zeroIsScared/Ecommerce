

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.UserFavorites.Commands
{
    public class AddUserFavorite 
    {
        public class Command : IRequest
        {
           public int UserId { get; set; }
           public int PropertyId { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<User> _userRepository;
            private readonly IRepository<Property> _propertyRepository;
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly IMapper _mapper;

            public Handler(IRepository<User> userRepository, IRepository<Property> propertyRepository,
                IRepository<UserFavorite> userFavoriteRepository, IMapper mapper)
            {
                _userRepository = userRepository;
                _propertyRepository = propertyRepository;
                _userFavoriteRepository = userFavoriteRepository;
                _mapper = mapper;
            }

            public Task Handle(Command request, CancellationToken cancellationToken)
            {
                var user = _userRepository.GetById(request.UserId);
                var property = _propertyRepository.GetById(request.PropertyId);
                var userFavorite = new UserFavorite() { };
                userFavorite.Property = property;
                userFavorite.PropertyId = request.PropertyId;
                userFavorite.UserId = request.UserId;
                userFavorite.User = user;

                _userFavoriteRepository.Add(userFavorite);

                return Task.CompletedTask;
            }
        }
    }
}
