using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymTrack.Models
{
    public class PlannedRepsAndSets
    {
        public int ID { get; set; }


        public int ExerciseID { get; set; }

        [Display(Name = "Exercise")]
        public int ExerciseDayProgramID { get; set; }

        [Display(Name="Planned Sets")]
        public int PlannedSets { get; set; }

        [Display(Name = "Planned Reps")]
        public int PlannedReps { get; set; }

        /*Navigation information*/
        public virtual Exercise Exercise { get; set; }
        public virtual ExerciseDayProgram ExerciseDayPrograms { get; set; }
        public virtual ICollection<Results> Results { get; set; }
    }
}