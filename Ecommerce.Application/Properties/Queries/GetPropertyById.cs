

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Property.Responses;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyById
    {
        public class Query : IRequest<Result<PropertyDto>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<PropertyDto>>
        {
            private readonly IRepository<Domain.Entities.Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Domain.Entities.Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public   Task<Result<PropertyDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _mapper.Map<PropertyDto>(_repository.GetById(request.Id));                

                return Task.FromResult(Result<PropertyDto>.Success(result));
            }
        }
    }
}
