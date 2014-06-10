using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using FluentNHibernate.Mapping;

namespace Seedworks.Tests.Lib.Persistence
{
    public class SampleEntityMap : ClassMap<SampleEntity>
    {
        public SampleEntityMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Text);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);
        }
    }
}   
