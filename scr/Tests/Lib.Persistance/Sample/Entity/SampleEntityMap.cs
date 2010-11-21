﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntityMap : ClassMap<SampleEntity>
    {
        public SampleEntityMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.DateCreated);
            Map(x => x.DateModified);
        }
    }
}
