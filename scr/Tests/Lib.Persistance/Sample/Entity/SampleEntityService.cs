using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworkds.Tests.Lib.Persistance
{
    public class SampleEntityService
    {
        private readonly SampleEntityRepository _repository;

        public SampleEntityService(SampleEntityRepository repository)
        {
            _repository = repository;
        }

        public void Create(SampleEntity someEntity)
        {
            _repository.Create(someEntity);
        }

        public void Delete(SampleEntity someEntity)
        {
            _repository.Delete(someEntity);
        }

        public SampleEntityList GetAll()
        {
            return _repository.GetAll();
        }
    }
}
