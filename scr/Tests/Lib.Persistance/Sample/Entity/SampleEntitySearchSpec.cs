using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistance;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntitySearchSpec : SearchSpecificationBase<SampleEntityFilter, OrderByCriteria>{}

    public class SampleEntityFilter : ConditionContainer
    {
        public readonly ConditionString Name;
        public readonly ConditionDateTime DateCreated;
        public readonly ConditionDateTime DateModified;

        public SampleEntityFilter()
        {
            Name = new ConditionString(this, "Name");
            DateCreated = new ConditionDateTime(this, "DateCreated");
            DateModified = new ConditionDateTime(this, "DateModified");
        }
    }

    public class SampleOrderBy : OrderByCriteria
    {
        public OrderBy Created;
        public OrderBy Modified;

        public SampleOrderBy()
        {
            Created = new OrderBy("DateCreated", this);
            Modified = new OrderBy("DateModified", this);
        }        
    }

}
