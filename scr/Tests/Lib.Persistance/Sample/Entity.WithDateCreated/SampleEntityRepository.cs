using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistence;

namespace Seedworks.Tests.Lib.Persistence
{
    public class SampleEntityRepository : RepositoryDb<SampleEntity>
    {
        public SampleEntityRepository(ISession session) : base(session)
        {
        }
    }
}
