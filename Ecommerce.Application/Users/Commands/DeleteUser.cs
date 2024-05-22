using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Users.Commands
{
    public class DeleteUser
    {
        public class Command : IRequest
        {
            public long UserId { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<User> _userRepository;
            private readonly IRepository<PropertyDetail> _propertyDetailRepository;
            private readonly IRepository<PropertyUtility> _propertyUtilityRepository;
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly IRepository<Property> _propertyRepository;
            private readonly IUnitOfWork _unitOfWork;

            public Handler(IRepository<User> userRepository,
                IRepository<PropertyDetail> propertyDetailRepository,
                IRepository<PropertyUtility> propertyUtilityRepository, 
                IRepository<UserFavorite> userFavoriteRepository,
                IRepository<Property> propertyRepository,
                IUnitOfWork unitOfWork)
            {
                _userRepository = userRepository;
                _propertyDetailRepository = propertyDetailRepository;
                _propertyUtilityRepository = propertyUtilityRepository;
                _userFavoriteRepository = userFavoriteRepository;
                _propertyRepository = propertyRepository;
                _unitOfWork = unitOfWork;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {                
                //delete proprety detail, utility, favorite, property, user
                await _userRepository.ExistsOrThrowsAsync(request.UserId, cancellationToken);
                var user = await _userRepository.Read()
                    .Include(x => x.Properties)
                        .ThenInclude(x => x.Details)
                    .Include(x => x.Properties)
                        .ThenInclude(x => x.Utilities)
                    .Include(x => x.Properties)
                        .ThenInclude(x => x.Favorites)
                    .FirstAsync(x => x.Id == request.UserId, cancellationToken);
                    

                try
                {
                    await _unitOfWork.BeginTransactionAsync(cancellationToken);

                    if (user.Properties != null)
                    {                         
                          
                            await _propertyDetailRepository.SoftRemoveRangeAsync(user.Properties, cancellationToken);
                            await _propertyUtilityRepository.SoftRemoveRangeAsync(user.Properties), cancellationToken);
                            await _userFavoriteRepository.RemoveAsync(property.Id, cancellationToken);
                            await _propertyRepository.RemoveAsync(property.Id, cancellationToken);
                        
                    }

                    _userRepository.RemoveAsync(request.UserId, cancellationToken);
                    await _unitOfWork.SaveAsync();
                }
                catch (Exception ex)
                {
                    await _unitOfWork.CommitTransactionAsync(cancellationToken);
                }           
            }
        }
    }
}