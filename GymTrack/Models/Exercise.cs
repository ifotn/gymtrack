using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymTrack.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        public string ExerciseName { get; set; }
        public string Description { get; set; }
        public string VideoURL { get; set; }

        public virtual ICollection<Results> Results { get; set; }
    }
}