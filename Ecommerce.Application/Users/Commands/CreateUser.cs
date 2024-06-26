﻿
using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using FluentValidation;
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

        public class CommandValidator : AbstractValidator<UserDto>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Id).GreaterThan(0);
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
                var newUser = _mapper.Map<User>(request.User);
                var savedUser = await _repository.AddAsync(newUser);
                var result = _mapper.Map<UserDto>(savedUser);
                _logger.LogInformation($"The user with id {result.Id} was created.");
                return result;
            }
        }
    }
}
