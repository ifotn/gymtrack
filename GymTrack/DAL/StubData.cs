using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GymTrack.Models;

namespace GymTrack.DAL
{
    public class StubData : System.Data.Entity.DropCreateDatabaseIfModelChanges<GymTrackerContext>    
    {
        protected override void Seed(GymTrackerContext context)
        {
            base.Seed(context);

            var exercises = new List<Exercise>
            {
                new Exercise{ExerciseName = "Pullups", Description="Using the assist machine, set the weight accordingly and pull yourself up with a wide grip" },
                new Exercise{ExerciseName = "Standing single arm cable row", Description="Using the cable machine, set the pulley at waist height and pull it in with 1 arm at a time" },
                new Exercise{ExerciseName = "Single Arm Dumbell row", Description="Using a dumbell, bend at the waist and pull the dumbell up to your waist using your lats" },
                new Exercise{ExerciseName = "Straight arm pushdown", Description="Using the cable machine, set the pulley at the top and pulldown on the rope attachment with straight arms"}           
            };

            exercises.ForEach(ex => context.Exercises.Add(ex));
            context.SaveChanges();               
            
            var exerciseDay = new List<ExerciseDayProgram>
            {
                new ExerciseDayProgram{ExerciseDayName="Day 32", ExerciseID = 1, PlannedSets=3, PlannedReps=10},
                new ExerciseDayProgram{ExerciseDayName="Day 32", ExerciseID = 2, PlannedSets=3, PlannedReps=10},
                new ExerciseDayProgram{ExerciseDayName="Day 32", ExerciseID = 3, PlannedSets=3, PlannedReps=10},
                new ExerciseDayProgram{ExerciseDayName="Day 32", ExerciseID = 4, PlannedSets=3, PlannedReps=10}
            };
            exercises.ForEach(ex => context.Exercises.Add(ex));
            context.SaveChanges();               


            var results = new List<Results>
            {
                new Results{ExerciseDayProgramID=1, ExerciseID=1, SetNumber=1, ExerciseDate=DateTime.Now, Weight=70, Reps=10},
                new Results{ExerciseDayProgramID=1, ExerciseID=1, SetNumber=2, ExerciseDate=DateTime.Now, Weight=70, Reps=8},
                new Results{ExerciseDayProgramID=1, ExerciseID=1, SetNumber=3, ExerciseDate=DateTime.Now, Weight=70, Reps=6},
                new Results{ExerciseDayProgramID=1, ExerciseID=2, SetNumber=1, ExerciseDate=DateTime.Now, Weight=60, Reps=10},
                new Results{ExerciseDayProgramID=1, ExerciseID=2, SetNumber=2, ExerciseDate=DateTime.Now, Weight=60, Reps=10},
                new Results{ExerciseDayProgramID=1, ExerciseID=2, SetNumber=3, ExerciseDate=DateTime.Now, Weight=60, Reps=10}
            };
            results.ForEach(r => context.Results.Add(r));
            context.SaveChanges();
        }
    }
}