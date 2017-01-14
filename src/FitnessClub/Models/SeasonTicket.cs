using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public enum SeasonTicketType
    {
        Classic, Premium
    }

    public enum DurationType
    {
        Month = 1, ThreeMonth = 3, HalfYear = 6, Year = 12
    }
    public class SeasonTicket
    {
        public int ID { get; set; }

        public DateTime StartDate { get; set; }

        public SeasonTicketType Type { get; set; }

        public DurationType? Duration { get; set; }

        public double Price { get; set; }
    }
}
