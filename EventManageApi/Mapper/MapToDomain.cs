using EventManageApi.Domain;
using EventManageApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManageApi.Mapper
{
    public static class MapToDomain
    {
        public static Event ToDomain(this EventDto input)
        {
            var random = new Random();
            return new Event
            {
                Id = random.Next(5, 50),
                Title = input.Title,
                Description = input.Description,
                Date = input.Date
            };
        }
    }
}
