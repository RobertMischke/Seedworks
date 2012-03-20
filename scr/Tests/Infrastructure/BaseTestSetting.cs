using Autofac;
using NUnit.Framework;
using Seedworks.Lib.Settings;
using Seedworks.Tests.Lib.Persistence;

namespace Seedworks.Tests.Lib.Settings
{
    [TestFixture]
    public class BaseTestSetting
    {
        protected IContainer _container;

        static BaseTestSetting()
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
            builder.RegisterType<SettingRepository>()
                .As<ISettingRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<SettingStorage>();
            builder.RegisterType<SettingBag1Loader>();
            builder.RegisterInstance(SessionFactory.CreateSessionFactory().OpenSession());
            _container = builder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
