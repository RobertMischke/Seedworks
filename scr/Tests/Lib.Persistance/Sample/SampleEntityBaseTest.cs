using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using NHibernate;
using NUnit.Framework;

namespace Seedworkds.Tests.Lib.Persistance
{
    [TestFixture]
    public class SampleEntityBaseTest
    {
        protected IContainer _container;

        static SampleEntityBaseTest()
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
