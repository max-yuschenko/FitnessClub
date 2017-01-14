using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class TrainingProgram
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Workout> Workouts{ get; set; }
    }
}
