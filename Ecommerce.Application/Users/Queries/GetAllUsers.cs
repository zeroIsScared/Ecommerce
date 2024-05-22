using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Users.Queries
{
    public class GetAllUsers
    {
        public class Query : IRequest<List<UserDto>> { }

        public class Handler : IRequestHandler<Query, List<UserDto>>
        {
            private readonly IRepository<User> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<User> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<List<UserDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _repository.Read().Select(x => _mapper.Map<UserDto>(x));
                return Task.FromResult(result.ToList());
            }
        }
    }
}
