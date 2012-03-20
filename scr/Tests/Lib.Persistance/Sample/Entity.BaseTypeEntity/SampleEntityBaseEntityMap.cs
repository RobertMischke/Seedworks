using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using FluentNHibernate.Mapping;

namespace Seedworks.Tests.Lib.Persistence
{
    public class SampleEntityBaseEntityMap : ClassMap<SampleEntityBaseEntity>
    {
        public SampleEntityBaseEntityMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);
        }
    }
}   
