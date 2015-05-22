using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymTrack.ViewModels
{
    public class AssignedExercises
    {
        public int ExerciseID { get; set; }
        public string ExerciseName { get; set; }
        public bool Assigned { get; set; }
    }
}