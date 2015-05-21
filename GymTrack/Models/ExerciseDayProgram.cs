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
        public string Description { get; set; }

        public virtual ICollection<PlannedRepsAndSets> PlannedExercises { get; set; }
    }
}