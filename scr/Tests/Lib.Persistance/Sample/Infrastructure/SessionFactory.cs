﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Seedworkds.Tests.Lib.Persistance
{
    public static class SessionFactory
    {
        private const string _fileDbName = "sample.db";

        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(
                SQLiteConfiguration.Standard
                  .UsingFile(_fileDbName)
              )
              .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<SampleEntity>())
              .ExposeConfiguration(BuildSchema)
              .BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config)
        {
             DeleteDbOnEachRun();

            new SchemaExport(config)
              .Create(false, true);
        }

        private static void DeleteDbOnEachRun()
        {
            if (File.Exists(_fileDbName))
                File.Delete(_fileDbName);
        }
    }
}
