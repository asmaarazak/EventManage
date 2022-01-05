using EventManageApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManageApi.Repository
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAll();
        Event GetById(int id);
        bool Insert(Event input);
        bool Update(Event input);
        bool Delete(int id);
    }
}
