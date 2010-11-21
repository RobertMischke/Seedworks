using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seedworks.Lib.Persistance;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntity :  IMutablePersistable
    {
        public int Id { get; set; }
        public string Name;

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
