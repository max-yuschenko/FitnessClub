using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FitnessClub.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public PersonalCard PersonalCard { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public SeasonTicket SeasonTicket { get; set; }
    }
}
