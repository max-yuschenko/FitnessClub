using FitnessClub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Controllers
{
    public class TrainingsController : Controller
    {
        private UserManager<ApplicationUser> _userManager;

        public TrainingsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            TrainingProgram program = user.TrainingProgram;
            List<Workout> workout = program.Workouts.ToList();

            TrainingsViewModel model = new TrainingsViewModel
            {
                //TrainingId = program.ID,
                //TrainingTitle = program.Title,
                //TrainingDescription = program.Description,
                //Workouts = workout
            };
            return View(model);
        }
    }
}
