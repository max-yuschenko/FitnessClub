using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Models
{
    public class TrainingsViewModel
    {
        public int TrainingId { get; set; }
        public string TrainingTitle { get; set; }
        public string TrainingDescription { get; set; }
        public ICollection<Workout> Workouts{ get; set; }
        //public int WorkoutId { get; set; }
        //public string WorkoutTitle { get; set; }
        //public string WorkoutDescription { get; set; }
    }
}
