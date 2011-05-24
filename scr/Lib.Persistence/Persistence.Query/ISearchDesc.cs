using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworks.Lib.Persistance
{
    public interface ISearchDesc : IPager
    {
        ConditionContainer Filter { get; }
        OrderByCriteria OrderBy { get; }
    }
}
