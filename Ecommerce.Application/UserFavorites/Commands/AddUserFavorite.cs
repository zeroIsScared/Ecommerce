using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.UserFavorites.Commands
{
    public class AddUserFavorite 
    {
        public class Command : IRequest
        {
           public long UserId { get; set; }
           public long PropertyId { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<User> _userRepository;
            private readonly IRepository<Property> _propertyRepository;
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<User> userRepository, IRepository<Property> propertyRepository,
                IRepository<UserFavorite> userFavoriteRepository, ILogger<Handler> logger)
            {
                _userRepository = userRepository;
                _propertyRepository = propertyRepository;
                _userFavoriteRepository = userFavoriteRepository;
                _logger = logger;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _userRepository.TryGetByIdOrThrowAsync(request.UserId);
                var property = await _propertyRepository.TryGetByIdOrThrowAsync(request.PropertyId);
                var userFavorite = new UserFavorite() { };
                userFavorite.Property = property;
                userFavorite.PropertyId = request.PropertyId;
                userFavorite.UserId = request.UserId;
                userFavorite.User = user;

                await _userFavoriteRepository.AddAsync(userFavorite);

                _logger.LogInformation($"The property with id {request.PropertyId} was added to users favorites with id {request.UserId}.");
            }
        }
    }
}
