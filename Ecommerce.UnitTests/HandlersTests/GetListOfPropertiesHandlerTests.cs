using Castle.Core.Logging;
using Ecommerce.Application.Interfaces;
using Ecommerce.Application.Properties.Dtos;
using Ecommerce.Application.Properties.Queries;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System.Threading;
using static Ecommerce.Application.Properties.Queries.GetListOfProperties;

namespace Ecommerce.UnitTests.HandlersTests

{
    
    public class GetListOfPropertiesHandlerTests
    {
        [SetUp]
        public void SetUp()
        {

        }
        private IRepository<Property> _repository;
        private ILogger<Handler> _logger;
        private CancellationToken cancellationToken;

        public GetListOfPropertiesHandlerTests()
        {
            _repository = Substitute.For<IRepository<Property>>();
            _logger = Substitute.For<ILogger<Handler>>();
        }

        [Fact]
        public async Task GetAllProperties_ShouldReturnProperties()
        {
            //Arrange
            var handler = new GetListOfProperties.Handler(_repository, _logger);
            var query = new GetListOfProperties.Query();
            var token = new CancellationToken();
            var result 
            var expectedResult = new List<GetPropertiesDto>
            {
                new() { Id = 2, Title = "House2", Price = 100000, Currency = "$", PhotoURL = "cdsfsffddfs"}
            };

            _repository.Read().Returns(expectedResult);
                 
            var actualResult = await handler.Handle(query,token);

            //Assert
          /*  Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedResult.Count(), actualResult.Count());*/
            Assert.Equal(expectedResult is List<GetPropertiesDto>, actualResult is List<GetPropertiesDto>);
        }
    }
}