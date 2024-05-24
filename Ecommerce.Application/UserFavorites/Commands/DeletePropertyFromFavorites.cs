using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using MediatR;

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

            public Handler(IRepository<UserFavorite> userFavoriteRepository)
            {                
                _userFavoriteRepository = userFavoriteRepository;                
            }

            public Task Handle(Command request, CancellationToken cancellationToken)
            {

                var userFavorites = _userFavoriteRepository.Read(false);
                var favorite = userFavorites.
                       Where(x => x.UserId == request.UserId && x.PropertyId == request.PropertyId).FirstOrDefault();
                
                if (favorite != null)
                {
                    favorite.IsDeleted = true;
                }

                return Task.CompletedTask;
            }
        }
    }
}
