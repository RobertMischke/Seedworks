using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Seedworks.Lib.Persistance;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntityRepository : RepositoryDb<SampleEntity, SampleEntityList>
    {
        public SampleEntityRepository(ISession session) : base(session)
        {
        }
    }
}
