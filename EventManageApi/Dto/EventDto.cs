using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManageApi.Dto
{
    public class EventDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
