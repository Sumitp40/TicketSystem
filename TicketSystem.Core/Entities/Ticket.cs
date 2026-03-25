using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Core.Entities
{
    namespace TicketSystem.Core.Entities
    {
        public class Ticket
        {
            public int Id { get; set; }

            public string TicketNumber { get; set; } = "";

            public string Title { get; set; } = "";

            public string Description { get; set; } = "";

            public string Status { get; set; } = "";

            public string Priority { get; set; } = "";

            public int CreatedBy { get; set; }

            public int? AssignedTo { get; set; }

            public DateTime CreatedAt { get; set; }
        }
    }
}
