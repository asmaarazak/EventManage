using EventManageApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManageApi.Repository
{
    public class EventRepository : IEventRepository
    {
        public Event[] events = new Event[]
        {
            new Event
            {
                Id = 1,
                Title = "New Year's Dinner",
                Description = "New Year's Dinner Description",
                Date = new DateTime(2021,01,05)
            },
            new Event
            {
                Id = 2,
                Title = "New Year's Dinner 2",
                Description = "New Year's Dinner Description 2",
                Date = new DateTime(2021,04,25)
            },
            new Event
            {
                Id = 3,
                Title = "New Year's Dinner 3",
                Description = "New Year's Dinner Description 3",
                Date = new DateTime(2021,12,01)
            }
        };

        public bool Delete(int id)
        {
            return true;
        }

        public IEnumerable<Event> GetAll()
        {
            return events;
        }

        public Event GetById(int id)
        {
            var data = events.FirstOrDefault((e) => e.Id == id);
            return data;
        }

        public bool Insert(Event input)
        {
            return true;
        }

        public bool Update(Event input)
        {
            return true;
        }
    }
}
