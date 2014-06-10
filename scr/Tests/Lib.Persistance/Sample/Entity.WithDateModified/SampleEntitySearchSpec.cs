using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistence;

namespace Seedworks.Tests.Lib.Persistence
{
    public class SampleEntitySearchSpec : SearchSpecificationBase<SampleEntityFilter, SampleOrderBy>
    {
    }

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
        public OrderBy Name;
        public OrderBy Text;

        public OrderBy Created;
        public OrderBy Modified;

        public SampleOrderBy()
        {
            Created = new OrderBy("DateCreated", this);
            Modified = new OrderBy("DateModified", this);

            Name = new OrderBy("Name", this);
            Text = new OrderBy("Text", this);
        }        
    }

}
