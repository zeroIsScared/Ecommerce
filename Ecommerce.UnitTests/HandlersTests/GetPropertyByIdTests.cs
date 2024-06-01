

using AutoMapper;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Properties.Queries;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;
using static Ecommerce.Application.Properties.Queries.GetPropertyById;

namespace Ecommerce.UnitTests.HandlersTests
{
    public class GetPropertyByIdTests
    {
        private IRepository<Property> _repository;
        private ILogger<Handler> _logger;
        private IMapper _mapper;
        private CancellationToken cancellationToken;

        public GetPropertyByIdTests()
        {
            _repository = Substitute.For<IRepository<Property>>();
            _logger = Substitute.For<ILogger<Handler>>();
            _mapper = Substitute.For<IMapper>();
        }

        [Fact]
        public async Task GetPropertyById_ShouldReturnProperty()
        {
            //Arrange
            var propertyId = 9;
            var handler = new GetPropertyById.Handler(_repository, _mapper, _logger);
            var query = new GetPropertyById.Query { Id = propertyId };
            var expectedResult = 

             _repository.Read()
                   .Include(x => x.Currency)
                   .Include(x => x.Details)
                   .Include(x => x.Utilities)
                       .ThenInclude(x => x.Utility)
                   .Include(x => x.User)
                   .Include(x => x.Photos)
                   .Include(x => x.Address)
                       .ThenInclude(x => x.Locality)
                          .ThenInclude(x => x.District)
                 .FirstAsync(x => x.Id == propertyId, cancellationToken).Returns(expectedResult);



            //Act 
            var actualResult = await handler.Handle(query, cancellationToken);

            //Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedResult.Received(1), actualResult.Received(1));
            //Assert.IsType<GetPropertyDto>(expectedResult);
        }
    }
}
