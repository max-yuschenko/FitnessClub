using FitnessClub.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Data
{
    public class FitnessAppSeedData
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;

        public FitnessAppSeedData(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
    
        public async Task EnsureSeedData()
        {
            //if (!_context.TrainingPrograms.Any())
            //{
                var IronBornProgram = new TrainingProgram()
                {
                    
                    Title = "Iron Born",
                    Description = "The IRONBORN is a strength-oriented dumbbell-based 30-day program designed for muscle definition. Each day focuses on a specific area: shoulders, chest & triceps, back & biceps, legs & abs. It can be scaled up or down depending on the dumbbells’ weight you choose.",
                    Workouts = new List<Workout>()
                    {
                        new Workout() {Title = "Crunch Time", Description = "an abdominal training workout that targets all those muscle groups for an athletic performance-enhancing ab strengthening result. "},
                        new Workout() {Title = "Space Cowboy", Description = "an upper body strength workout that works all the major upper body muscle groups in a way that aligns their movements and helps increase the overall level of power your strength can generate." },
                        new Workout() {Title = "Whiplash", Description = "It requires endurance, strength, flexibility and core stability. " }
                    }
                };
                ApplicationUser user = await _userManager.FindByNameAsync("user@gmail.com");

                user.TrainingProgram = IronBornProgram;

                _context.TrainingPrograms.Add(IronBornProgram);

                _context.Workouts.AddRange(IronBornProgram.Workouts);

                _context.SaveChanges();
            //}
            
        }
    }
}
