using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymTrack.Models
{
    public class Results
    {
        public int ID { get; set; }

        [Display(Name="Exercise Name")]
        public int ExerciseID { get; set; }

        [Display(Name = "Program Name")]
        public int ExerciseDayProgramID { get; set; }

        [DataType(DataType.Date)]
        public DateTime ExerciseDate { get; set; }

        [Display(Name = "Set Number")]
        public int SetNumber { get; set; }

        [Display(Name ="Weight used")]
        public int Weight { get; set; }

        [Display(Name = "Reps achieved")]
        public int Reps { get; set; }

        public string GuID { get; set; }

        public virtual Exercise Exercise { get; set; }
        public virtual ExerciseDayProgram ExerciseDayProgram { get; set; }
    }
}