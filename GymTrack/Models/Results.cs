using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymTrack.Models
{
    public class Results
    {
        public int ID { get; set; }
        public int ExerciseID { get; set; }
        public int ExerciseDayProgramID { get; set; }
        public DateTime ExerciseDate { get; set; }
        public int SetNumber { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }

        public virtual Exercise Exercise { get; set; }
        public virtual ExerciseDayProgram ExerciseDayProgram { get; set; }
    }
}