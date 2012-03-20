using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seedworks.Tests.Lib.Persistence
{
    public class SampleEntityBaseEntityService
    {
        private readonly SampleEntityRepository _repository;

        public SampleEntityBaseEntityService(SampleEntityRepository repository)
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

        public IList<SampleEntity> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
