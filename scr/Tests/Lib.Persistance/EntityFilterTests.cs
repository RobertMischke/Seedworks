using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using NUnit.Framework;
using Seedworks.Lib.Persistence;

namespace Seedworks.Tests.Lib.Persistence
{
    [TestFixture]
    public class EntityFilterTests : SampleEntityBaseTest
    {
        private void Arrange_persisted_sample_entities()
        {
            var entityRepository = Resolve<SampleEntityRepository>();
            entityRepository.Create(new SampleEntity { Name = "Daniel" });
            entityRepository.Create(new SampleEntity { Name = "Tom" });
            entityRepository.Create(new SampleEntity { Name = "Wladimir" });
        }

        [Test]
        public void Should_filter_by_string()
        {
            Arrange_persisted_sample_entities();

            var searchSpec = new SampleEntitySearchSpec();
            searchSpec.Filter.Name.EqualTo("Tom");

            Assert.That(Resolve<SampleEntityRepository>().GetBy(searchSpec).Count, Is.EqualTo(1));
        }

        [Test]
        public void Should_return_unique_item_or_none()
        {
            Arrange_persisted_sample_entities();

            var searchSpec = new SampleEntitySearchSpec();
            searchSpec.Filter.Name.EqualTo("Tom");

            Assert.That(Resolve<SampleEntityRepository>().GetByUnique(searchSpec), Is.Not.Null);
        }


    }
}
