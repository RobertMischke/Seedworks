using System;

namespace Seedworks.Lib.Persistance
{
    public interface IMutablePersistable : IPersistable
    {
        DateTime DateModified { get; set; }
    }
}