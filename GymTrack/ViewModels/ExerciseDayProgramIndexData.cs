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
        public IEnumerable<PlannedRepsAndSets> PlannedRepsAndSets { get; set; }
        public IEnumerable<Results> Results { get; set; }
    }
}