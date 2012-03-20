using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace Seedworks.Tests.Lib.Persistence
{
    public class SampleEntityBaseEntitySearchSpec : SearchSpecificationBase<SampleEntityBaseEntityFilter, OrderByCriteria>
    {
    }

    public class SampleEntityBaseEntityFilter : ConditionContainer
    {
        public readonly ConditionString Name;
        public readonly ConditionDateTime DateCreated;
        public readonly ConditionDateTime DateModified;

        public SampleEntityBaseEntityFilter()
        {
            Name = new ConditionString(this, "Name");
            DateCreated = new ConditionDateTime(this, "DateCreated");
            DateModified = new ConditionDateTime(this, "DateModified");
        }
    }

    public class SampleEntityBaseEntityOrderBy : OrderByCriteria
    {
        public OrderBy Created;
        public OrderBy Modified;

        public SampleEntityBaseEntityOrderBy()
        {
            Created = new OrderBy("DateCreated", this);
            Modified = new OrderBy("DateModified", this);
        }        
    }

}
