﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworks.Lib.Persistence
{
    public interface WithCreatedBy
    {
        IUser CreatedBy { get; set; }   
    }
}
