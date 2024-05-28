

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Users.Queries
{
    public class GetUserById
    {
        public class Query : IRequest<UserDto>
        {
            public long Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, UserDto>
        {
            private readonly IRepository<User> _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<User> repository,
                IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public async Task<UserDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _repository.TryGetByIdOrThrowAsync(request.Id, cancellationToken);
                var result = _mapper.Map<UserDto>(user);
                _logger.LogInformation($"The user with id {request.Id} was retrieved.");
                return result;
            }
        }
    }
}
