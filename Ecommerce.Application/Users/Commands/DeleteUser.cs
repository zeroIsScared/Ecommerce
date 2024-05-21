using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Users.Commands
{
    public class DeleteUser
    {
        public class Command : IRequest
        {
            public int UserId { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IRepository<User> _userRepository;
            private readonly IRepository<PropertyDetail> _propertyDetailRepository;
            private readonly IRepository<PropertyUtility> _propertyUtilityRepository;
            private readonly IRepository<UserFavorite> _userFavoriteRepository;
            private readonly IRepository<Property> _propertyRepository;         

            public Handler(IRepository<User> userRepository,
                IRepository<PropertyDetail> propertyDetailRepository,
                IRepository<PropertyUtility> propertyUtilityRepository, 
                IRepository<UserFavorite> userFavoriteRepository,
                IRepository<Property> propertyRepository)
            {
                _userRepository = userRepository;
                _propertyDetailRepository = propertyDetailRepository;
                _propertyUtilityRepository = propertyUtilityRepository;
                _userFavoriteRepository = userFavoriteRepository;
                _propertyRepository = propertyRepository;                
            }

            public Task Handle(Command request, CancellationToken cancellationToken)
            {
                //delete proprety detail, utility, favorite, property, user
                User user = _userRepository.GetById(request.UserId);
                
                if (user.Properties != null)
                {
                    foreach (var property in user.Properties)
                    {
                        _propertyDetailRepository.Remove((int)property.Id);
                        _propertyUtilityRepository.Remove((int)property.Id);
                        _userFavoriteRepository.Remove((int)property.Id);
                        _propertyRepository.Remove((int)property.Id);
                    }
                }

                _userRepository.Remove(request.UserId);
                return Task.CompletedTask;
            }
        }
    }
}