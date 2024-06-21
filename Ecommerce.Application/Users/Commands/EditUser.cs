

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Users.Commands
{
    public class EditUser
    {
        public class Command : IRequest<UserDto>
        {
            public required UserDto User { get; set; }
        }

        public class CommandValidator : AbstractValidator<UserDto>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Id).NotEmpty().GreaterThan(0);
                RuleFor(x => x.Username).NotEmpty().MaximumLength(50);
                RuleFor(x => x.PhoneNumber).NotEmpty().MaximumLength(30);
            }
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
                var user = _mapper.Map<User>(request.User);
                var edited = await _repository.UpdateAsync(user, cancellationToken);
                var result = _mapper.Map<UserDto>(edited);
                _logger.LogInformation($"The user with id {request.User.Id} was edited.");
                return result;
            }
        }
    }
}
