
using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos.Responses;
using MediatR;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetListOfProperties
    {
        public class Query : IRequest<Result<List<PropertyDto>>> { }

        public class Handler : IRequestHandler<Query, Result<List<PropertyDto>>>
        {
            private readonly IRepository<Domain.Entities.Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Domain.Entities.Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<Result<List<PropertyDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _repository.Read(false).Select(x => _mapper.Map<PropertyDto>(x));              
                return Task.FromResult(Result < List < PropertyDto >>.Success(result.ToList()));
            }
        }

    }
}
