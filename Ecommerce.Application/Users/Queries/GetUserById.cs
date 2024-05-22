

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;

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

            public Handler(IRepository<User> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<UserDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _repository.TryGetByIdOrThrowAsync(request.Id, cancellationToken);
                var result = _mapper.Map<UserDto>(user);
                return result;
            }
        }
    }
}
