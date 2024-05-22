
using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;

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

            public Handler(IRepository<User> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public async Task<UserDto> Handle(Command request, CancellationToken cancellationToken)
            {
                var newUser = _mapper.Map<User>(request.User);
                var savedUser = await _repository.AddAsync(newUser);
                var result = _mapper.Map<UserDto>(savedUser);
                return result;
            }
        }
    }
}
