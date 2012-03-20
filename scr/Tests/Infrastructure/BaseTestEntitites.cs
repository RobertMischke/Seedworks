using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using NHibernate;
using NUnit.Framework;

namespace Seedworks.Tests.Lib.Persistence
{
    [TestFixture]
    public class BaseTestEntitites
    {
        protected IContainer _container;

        static BaseTestEntitites()
        {
            HibernatingRhinos.Profiler.Appender.NHibernate.NHibernateProfiler.Initialize();
        }

        [SetUp]
        public void Setup()
        {
            InitializeContext();
        }

        public void InitializeContext()
        {            
            var builder = new ContainerBuilder();
            builder.RegisterType<SampleEntityService>();
            builder.RegisterType<SampleEntityRepository>();
            builder.RegisterInstance(SessionFactory.CreateSessionFactory().OpenSession());
            _container = builder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
