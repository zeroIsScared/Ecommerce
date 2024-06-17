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
using System.Xml;
using System;

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
        public void GetPropertyById_InValidData_ThrowsError()
        {
            //Arrange
            var logger = new Mock<ILogger<GetPropertyById.Handler>>();
            long id = -1; 
            var query = new GetPropertyById.Query { Id = id };
            var handler = new GetPropertyById.Handler(_repository.Object, _mapper, logger.Object);
            var exception = new EntityNotFoundException(typeof(Property), id);
            _repository.Setup(x => x.ExistsOrThrowsAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).ThrowsAsync(exception);
            
            //Act
            var result = Assert.ThrowsAsync<EntityNotFoundException>(() => handler.Handle(query, CancellationToken.None));  

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(exception.Message, result.Message);
            Assert.IsInstanceOf<EntityNotFoundException>(result);
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
            _repository.Setup(x => x.AddAsync(It.IsAny<Property>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Property());
            var logger = new Mock<ILogger<CreateProperty.Handler>>();
            var command = new CreateProperty.Command { RealEstate = _mapper.Map<CreateOrUpdatePropertyDto>(_property)};
            var handler = new CreateProperty.Handler(_repository.Object, _mapper, logger.Object);

            //Act
            var result = await handler.Handle(command, CancellationToken.None);

            //Assert
            Assert.IsInstanceOf<CreateOrUpdatePropertyDto>(result);       
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
            _repository.Setup(x => x.SoftRemoveAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).Callback(() =>
            {
                _propertyList[0].IsDeleted = true;
            });
            _repository.Setup(x => x.TryGetByIdOrThrowAsync(It.IsAny<long>(), It.IsAny<CancellationToken>())).ReturnsAsync(_propertyList[0]);
            //Act            
            await handler.Handle(command, CancellationToken.None);

            //Assert
            Assert.That(_propertyList[0].IsDeleted, Is.EqualTo(true));
        }

        [Test]
        public async Task EditProperty_WhenValidData()
        {
            //Arrange
            _repository.Setup(x => x.UpdateAsync(It.IsAny<Property>(), It.IsAny<CancellationToken>())).ReturnsAsync(_propertyList[1]);
            var logger = new Mock<ILogger<EditProperty.Handler>>();         
            var command = new EditProperty.Command {  RealEstate = _mapper.Map<CreateOrUpdatePropertyDto>(_propertyList[1]) };
            var handler = new EditProperty.Handler(_repository.Object, _mapper, logger.Object);
           
            //Act            
            var result = await handler.Handle(command, CancellationToken.None);

            //Assert          
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<CreateOrUpdatePropertyDto>(result);
        }
    }
}