
using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetListOfProperties
    {
        public class Query : IRequest<List<GetPropertyDto>> { }

        public class Handler : IRequestHandler<Query, List<GetPropertyDto>>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<List<GetPropertyDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _repository.Read(false).Select(x => _mapper.Map<GetPropertyDto>(x));              
                return Task.FromResult(result.ToList());
            }
        }

    }
}
