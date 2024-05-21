

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Users.Commands
{
    public class EditUser
    {
        public class Command : IRequest<int>
        {
            public required AddOrEditUserDto User { get; set; }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IRepository<User> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<User> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var edited = _repository.Update(_mapper.Map<User>(request.User));
                return Task.FromResult((int)edited.Id);
            }
        }
    }
}
