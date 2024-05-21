

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Enums;
using MediatR;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyListByCategoryId

    {
        public class Query : IRequest<Result<List<GetPropertyDto>>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<List<GetPropertyDto>>>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public Task<Result<List<GetPropertyDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var propertyList = _repository.Read(false);
                
                if(propertyList == null) 
                {
                    return null;
                }
                var result = propertyList.Where(x => x.Category == (PropertyCategory)request.Id)
                    .Select(x => _mapper.Map<GetPropertyDto>(x));
                return Task.FromResult(Result<List<GetPropertyDto>>.Success(result.ToList()));
            }
        }
    }
}
