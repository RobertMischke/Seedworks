using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworks.Lib.Persistance
{
    public interface IDeletable 
    {
		bool Deleted { get; set; }
    }
}
