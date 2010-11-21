using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistance;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntity : IMutablePersistable
    {
        virtual public int Id { get; set; }
        virtual public string Name { get; set; }

        virtual public DateTime DateCreated { get; set; }
        virtual public DateTime DateModified { get; set; }
    }
}
