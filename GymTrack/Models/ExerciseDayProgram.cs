using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymTrack.Models
{
    public class ExerciseDayProgram
    {
        public int ID { get; set; }
        public string ExerciseDayName { get; set; }
        public int ExerciseID { get; set; }
        public int PlannedSets { get; set; }
        public int PlannedReps { get; set; }

       /* public virtual Exercise Exercise { get; set; } /* //JW Comment - this creates a circular reference */
        public virtual ICollection<Results> Results { get; set; }
    }
}