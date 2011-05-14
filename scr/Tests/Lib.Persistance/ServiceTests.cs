using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using NUnit.Framework;

namespace Seedworkds.Tests.Lib.Persistance
{
    /// <summary>
    /// Example usage 
    /// </summary>
    public class ServiceTests : SampleEntityBaseTest
    {
        [SetUp]
        public void Setup()
        {
            InitializeContext();
            _entityService = _container.Resolve<SampleEntityService>();
        }
        
        SampleEntityService _entityService;
        
        [Test]
        public void Usage_of_create_entity()
        {
            var someEntity = new SampleEntity {Name = "SampleEntity"};

            _entityService.Create(someEntity);
            
            Assert.That(someEntity.Id, Is.EqualTo(1));
            Assert.That(someEntity.DateCreated  , Is.GreaterThan(DateTime.Now.AddSeconds(-1)));
            Assert.That(someEntity.DateModified , Is.GreaterThan(DateTime.Now.AddSeconds(-1)));
        }

        [Test]
        public void Usage_of_delete_entity()
        {
            var someEntity = new SampleEntity { Name = "SampleEntity" };

            _entityService.Create(someEntity);
            
            Assert.That(_entityService.GetAll().Count, Is.EqualTo(1));

            _entityService.Delete(someEntity);
            Assert.That(_entityService.GetAll().Count, Is.EqualTo(0));
        }

        [Test]
        public void Should_retrieve_a_list_of_entities()
        {
            Assert.That(_entityService.GetAll().Count, Is.EqualTo(0));

            var someEntity1 = new SampleEntity { Name = "SampleEntity1" };
            var someEntity2 = new SampleEntity { Name = "SampleEntity2" };

            _entityService.Create(someEntity1);
            _entityService.Create(someEntity2);

            Assert.That(_entityService.GetAll().Count, Is.EqualTo(2));
        }


    }
}
