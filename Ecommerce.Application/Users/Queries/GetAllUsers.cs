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
        public class Query : IRequest<Result<List<GetUserDto>>> {}

        public class Handler : IRequestHandler<Query, Result<List<GetUserDto>>>
        {
            private readonly IRepository<User> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<User> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<Result<List<GetUserDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _repository.Read(false).Select(x => _mapper.Map<GetUserDto>(x));
                return Task.FromResult(Result<List<GetUserDto>>.Success(result.ToList()));
            }
        }
    }
}
