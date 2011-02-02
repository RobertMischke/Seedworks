using System;

namespace Seedworks.Lib.Persistance
{
    public interface WithDateCreated : IPersistable
    {
        DateTime DateModified { get; set; }
    }
}