using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.UserFavorites.Commands
{
    public class DeletePropertyFromFavorites
    {
        public class Command : IRequest
        {
            public long UserId { get; set; }
            public long PropertyId { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {            
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<UserFavorite> userFavoriteRepository, ILogger<Handler> logger)
            {                
                _userFavoriteRepository = userFavoriteRepository;
                _logger = logger;
            }

            public Task Handle(Command request, CancellationToken cancellationToken)
            {

                var userFavorites = _userFavoriteRepository.Read(false);
                var favorite = userFavorites.
                       FirstOrDefault(x => x.UserId == request.UserId && x.PropertyId == request.PropertyId);
                
                if (favorite != null)
                {
                    favorite.IsDeleted = true;
                    _userFavoriteRepository.SoftRemoveAsync(favorite.Id);
                }

                _logger.LogInformation($"The property with id {request.PropertyId} was deleted to users favorites with id {request.UserId}.");

                return Task.CompletedTask;
            }
        }
    }
}
