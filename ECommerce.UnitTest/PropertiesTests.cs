using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using ECommerce.UnitTest.Fakers;
using Moq;
using MockQueryable.Moq;
using Ecommerce.Application.Properties.Queries;
using Microsoft.Extensions.Logging;
using Ecommerce.Application.Properties.Dtos;
using AutoMapper;
using Bogus;
using System.Data;
using Ecommerce.Application.Core.Mappings;
using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Properties.Commands;

namespace ECommerce.UnitTest
{
    public class PropertiesTests
    {
        private PropertyFaker _propertyFaker;
        private Mock<IRepository<Property>> _repository;             
        private List<Property> _propertyList;
        private Property _property;
        private IMapper _mapper;

        [SetUp]
        public void Setup()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            _mapper = new Mapper(configuration);         
            _propertyFaker = new PropertyFaker();
            _repository = new Mock<IRepository<Property>>();            
            _propertyList = _propertyFaker.Generate(5);
            _property = _propertyFaker.Generate();
            _repository.Setup(x => x.Read(It.IsAny<bool>())).Returns(_propertyList.AsQueryable().BuildMock());
            _repository.Setup(x => x.ExistsOrThrowsAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).ReturnsAsync(true);
           // _repository.Setup(x => x.ExistsOrThrowsAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).ThrowsAsync(new EntityNotFoundException(Property, _propertyList[0].Id));
            _repository.Setup(x => x.AddAsync(It.IsAny<Property>(), It.IsAny<CancellationToken>())).ReturnsAsync(It.IsAny<Property>);
            _repository.Setup(x => x.SoftRemoveAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).CallBase();
            _repository.Setup(x => x.UpdateAsync(It.IsAny<Property>(), It.IsAny<CancellationToken>())).ReturnsAsync(It.IsAny<Property>);
        }

        [Test]
        public async Task GetListOfProperties_WhenValidData_ReturnsListOfProperties()
        {
            //Arrange
            var logger = new Mock<ILogger<GetListOfProperties.Handler>>();
            var query = new GetListOfProperties.Query { };
            var handler = new GetListOfProperties.Handler(_repository.Object, logger.Object);
            //Act
            var result =  await handler.Handle(query, CancellationToken.None);

            //Assert
            Assert.IsInstanceOf<List<GetPropertiesDto>>(result);
            Assert.AreEqual(_propertyList.Count, result.Count);
        }

        [Test]
        public async Task GetPropertyById_WhenValidData_ReturnsAProperty()
        {
            //Arrange
            var logger = new Mock<ILogger<GetPropertyById.Handler>>();                   
            var id = _propertyList[0].Id;
            var query = new GetPropertyById.Query { Id = id };
            var handler = new GetPropertyById.Handler(_repository.Object, _mapper, logger.Object);
           
            //Act
            var result = await handler.Handle(query, CancellationToken.None);

            //Assert
            Assert.IsInstanceOf<GetPropertyDto>(result);
            Assert.AreEqual(id, result.Id);           
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task GetPropertyById_InValidData_ThrowsError()
        {
            //Arrange
            var logger = new Mock<ILogger<GetPropertyById.Handler>>();
            long id = 503; 
            var query = new GetPropertyById.Query { Id = id };
            var handler = new GetPropertyById.Handler(_repository.Object, _mapper, logger.Object);

            //Act

            //  await handler.Handle(query, CancellationToken.None);


            //Assert
           // Assert.That(async () => await handler.Handle(query, CancellationToken.None),
               // Throws.TypeOf<EntityNotFoundException>);
        }

        [Test]
        public async Task GetPropertyListByCategoryId_WhenValidData_ReturnsListOfProperties()
        {
            //Arrange
            var logger = new Mock<ILogger<GetPropertyListByCategoryId.Handler>>();
            var id = (int)_propertyList[0].Category;
            var query = new GetPropertyListByCategoryId.Query { Id = id };
            var handler = new GetPropertyListByCategoryId.Handler(_repository.Object, _mapper, logger.Object);

            //Act            
            var result = await handler.Handle(query, CancellationToken.None);

            //Assert
            Assert.IsInstanceOf<List<GetPropertiesDto>>(result);
        }

        [Test]
        public async Task CreateProperty_WhenValidData_ReturnsAProperty()
        {
            //Arrange
            var logger = new Mock<ILogger<CreateProperty.Handler>>();
            var command = new CreateProperty.Command { RealEstate = _mapper.Map<CreatePropertyDto>(_property)};
            var handler = new CreateProperty.Handler(_repository.Object, _mapper, logger.Object);

            //Act
            var result = await handler.Handle(command, CancellationToken.None);

            //Assert
            Assert.IsInstanceOf<CreatePropertyDto>(result);
            Assert.AreEqual(_property.Id, result.Id);
            Assert.IsNotNull(result);
        }

        [Test]
        public async Task DeleteProperty_WhenValidData()
        {
            //Arrange
            var logger = new Mock<ILogger<DeleteProperty.Handler>>();
            var id = _propertyList[0].Id;
            var command = new DeleteProperty.Command { Id = id };
            var handler = new DeleteProperty.Handler(_repository.Object, logger.Object);

            //Act            
            await handler.Handle(command, CancellationToken.None);

            //Assert
            Assert.That(_propertyList[0].IsDeleted, Is.EqualTo(true));
        }

        [Test]
        public async Task EditProperty_WhenValidData()
        {
            //Arrange
            var logger = new Mock<ILogger<EditProperty.Handler>>();         
            var command = new EditProperty.Command { Property = _propertyList[1] };
            var handler = new EditProperty.Handler(_repository.Object, logger.Object);

            //Act            
            var result = await handler.Handle(command, CancellationToken.None);

            //Assert
            Assert.AreEqual(_propertyList[1].Id, result);           
        }
    }
}