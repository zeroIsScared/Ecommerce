

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
        public class Query : IRequest<Result<GetUserDto>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<GetUserDto>>
        {
            private readonly IRepository<User> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<User> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<Result<GetUserDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result =  _mapper.Map<GetUserDto>(_repository.GetById(request.Id));
                return Task.FromResult(Result<GetUserDto>.Success(result));
            }
        }
    }
}
