

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos.Responses;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyById
    {
        public class Query : IRequest<Result<GetPropertyDto>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<GetPropertyDto>>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public   Task<Result<GetPropertyDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = _mapper.Map<GetPropertyDto>(_repository.GetById(request.Id));                

                return Task.FromResult(Result<GetPropertyDto>.Success(result));
            }
        }
    }
}
