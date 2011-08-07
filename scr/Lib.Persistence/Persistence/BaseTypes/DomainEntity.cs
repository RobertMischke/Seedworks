using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworks.Lib.Persistence.Persistence.BaseTypes
{
    /// <remarks>
    /// Based on:
    /// https://github.com/Slesa/Playground/blob/master/src/lib/DataAccess/DataAccess/DomainEntity.cs
    /// </remarks>>
    public class DomainEntity :  Entity, WithDateCreated, WithDateModified
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
