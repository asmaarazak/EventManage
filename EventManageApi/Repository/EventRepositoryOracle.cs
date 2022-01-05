using EventManageApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManageApi.Repository
{
    public class EventRepositoryOracle : IEventRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Event> GetAll()
        {
            return new List<Event> { };
        }

        public Event GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Event input)
        {
            throw new NotImplementedException();
        }

        public bool Update(Event input)
        {
            throw new NotImplementedException();
        }
    }
}
