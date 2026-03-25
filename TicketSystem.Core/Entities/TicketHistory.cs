using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem.Core.Entities
{
    public class TicketHistory
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public string Action { get; set; } = ""; // Status change / Comment

        public string Description { get; set; } = "";

        public int UpdatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
