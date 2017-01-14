using System.Collections.Generic;

namespace FitnessClub.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public ICollection<File> Files { get; set; }
    }
}