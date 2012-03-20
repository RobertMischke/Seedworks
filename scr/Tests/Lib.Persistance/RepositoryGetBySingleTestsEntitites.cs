using Autofac;
using NUnit.Framework;

namespace Seedworks.Tests.Lib.Persistence
{
    [TestFixture]
    public class RepositoryGetBySingleTestsEntitites : BaseTestEntitites
    {
        [Test]
        [ExpectedException]
        public void Should_throw_when_more_then_one_result()
        {
            var entityRepository = _container.Resolve<SampleEntityRepository>();
            entityRepository.Create(new SampleEntity{Name = "Foo"});
            entityRepository.Create(new SampleEntity{Name = "Bar"});

            Resolve<SampleEntityRepository>().GetByUnique(new SampleEntitySearchSpec());
        }

        [Test]
        public void Should_return_one_result()
        {
            var entityRepository = _container.Resolve<SampleEntityRepository>();
            entityRepository.Create(new SampleEntity { Name = "Foo" });

            var searchSpec = new SampleEntitySearchSpec();
            searchSpec.Filter.Name.EqualTo("Foo");

            var sampleEntity = Resolve<SampleEntityRepository>().GetByUnique(searchSpec);
            Assert.That(sampleEntity, Is.Not.Null);
            Assert.That(sampleEntity.Name, Is.EqualTo("Foo"));
        }
    }
}
