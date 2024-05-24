using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Users.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Application.Users.Queries
{
    public class GetAllUsers
    {
        public class Query : IRequest<List<UserDto>> { }

        public class Handler : IRequestHandler<Query, List<UserDto>>
        {
            private readonly IRepository<User> _repository;
            private readonly IMapper _mapper;
            private readonly ILogger<Handler> _logger;

            public Handler(IRepository<User> repository, IMapper mapper, ILogger<Handler> logger)
            {
                _repository = repository;
                _mapper = mapper;
                _logger = logger;
            }

            public Task<List<UserDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _repository.Read().Select(x => _mapper.Map<UserDto>(x));

                _logger.LogInformation($"Get all Users enpoint executed, got {result.Select(x => x.Id).Count()} users back.");
                return Task.FromResult(result.ToList());

            }
        }
    }
}
