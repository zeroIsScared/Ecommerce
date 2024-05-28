
using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Users.Commands
{
    public class CreateUser
    {
        public class Command : IRequest<UserDto>
        {
            public required UserDto User { get; set; }
        }

        public class Handler : IRequestHandler<Command, UserDto>
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
            public async Task<UserDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var newUser = _mapper.Map<User>(request.User);
                var savedUser = await _repository.AddAsync(newUser);
                var result = _mapper.Map<UserDto>(savedUser);
                _logger.LogInformation($"The user with id {result.Id} was created.");
                return result;
            }
        }
    }
}
