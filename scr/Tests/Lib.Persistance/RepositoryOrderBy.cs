using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using NUnit.Framework;
using Seedworks.Lib.Persistence;

namespace Seedworks.Tests.Lib.Persistence
{
    public class RepositoryOrderBy : BaseTestEntitites
    {
        [Test]
        public void Should_order_by()
        {
            var entityRepository = Resolve<SampleEntityRepository>();
            entityRepository.Create(new SampleEntity { Name = "A", Text = "A"});
            entityRepository.Create(new SampleEntity { Name = "B", Text = "B"});
            entityRepository.Create(new SampleEntity { Name = "B", Text = "A"});

            var spec = new SampleEntitySearchSpec();
            spec.OrderBy.Name.Asc();
            spec.OrderBy.Text.Asc();

            var entities = entityRepository.GetBy(spec);

            Assert.That(entities[0].Name, Is.EqualTo("A"));
            Assert.That(entities[1].Name, Is.EqualTo("B"));
            Assert.That(entities[1].Text, Is.EqualTo("A"));
        }
    }
}
