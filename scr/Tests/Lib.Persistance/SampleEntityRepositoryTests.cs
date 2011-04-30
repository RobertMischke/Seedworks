﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Autofac;
using NUnit.Framework;

namespace Seedworkds.Tests.Lib.Persistance
{
    [TestFixture]
    public class SampleEntityRepositoryTests : SampleEntityBaseTest 
    {
        [Test]
        public void Should_persist_entity()
        {
            var entityRepository = _container.Resolve<SampleEntityRepository>();
            entityRepository.Create(new SampleEntity());
            entityRepository.Flush();

            Assert.That(entityRepository.GetAll().Count, Is.EqualTo(1));
        }
    }
}
