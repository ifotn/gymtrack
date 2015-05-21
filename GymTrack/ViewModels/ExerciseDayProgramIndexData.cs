using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GymTrack.Models;

namespace GymTrack.ViewModels
{
    public class ExerciseDayProgramIndexData
    {
        public IEnumerable<ExerciseDayProgram> ExerciseDayPrograms { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}