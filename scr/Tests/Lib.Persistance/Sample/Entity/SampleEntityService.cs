using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntityService
    {
        private readonly SampleEntityRepository _sampleEntityRepository;

        public SampleEntityService(SampleEntityRepository sampleEntityRepository)
        {
            _sampleEntityRepository = sampleEntityRepository;
        }
    }
}
