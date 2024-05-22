

using AutoMapper;
using Ecommerce.Application.Core;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ecommerce.Application.Properties.Queries
{
    public class GetPropertyById
    {
        public class Query : IRequest<GetPropertyDto>
        {
            public long Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, GetPropertyDto>
        {
            private readonly IRepository<Property> _repository;
            private readonly IMapper _mapper;

            public Handler(IRepository<Property> repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public async Task<GetPropertyDto> Handle(Query request, CancellationToken cancellationToken)
            {
                var property = await _repository.TryGetByIdOrThrowAsync(request.Id, cancellationToken);
                var result = _mapper.Map<GetPropertyDto>(property);                

                return result;
            }
        }
    }
}
