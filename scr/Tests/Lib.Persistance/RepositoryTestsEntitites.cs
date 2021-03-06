﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Autofac;
using NUnit.Framework;

namespace Seedworks.Tests.Lib.Persistence
{
    [TestFixture]
    public class RepositoryTestsEntitites : BaseTestEntitites 
    {
        [Test]
        public void Should_persist_entity()
        {
            var entityRepository = Resolve<SampleEntityRepository>();
            entityRepository.Create(new SampleEntity());

            Assert.That(entityRepository.GetAll().Count, Is.EqualTo(1));
        }

    }
}
