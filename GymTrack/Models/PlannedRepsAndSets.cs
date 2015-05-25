using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymTrack.Models
{
    public class PlannedRepsAndSets
    {
        public int ID { get; set; }
        public int ExerciseID { get; set; }
        public int ExerciseDayProgramID { get; set; }
        public int PlannedSets { get; set; }
        public int PlannedReps { get; set; }

        /*Navigation information*/
        public virtual Exercise Exercise { get; set; }
        public virtual ExerciseDayProgram ExerciseDayPrograms { get; set; }
        public virtual ICollection<Results> Results { get; set; }
    }
}