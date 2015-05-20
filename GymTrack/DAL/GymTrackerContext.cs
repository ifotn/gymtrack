using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GymTrack.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GymTrack.DAL
{
    public class GymTrackerContext : DbContext 
    {
        /* JW Comment this section removed when adding the model builder for the ExerciseExerciseDayProgram model builder
        public GymTrackerContext() : base ("GymTrackerContext")
        {
        }*/

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseDayProgram> ExerciseDayPrograms { get; set; }
        public DbSet<Results> Results { get; set; }
                           
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            /* JW Comment - removed this and made the relationship between Exercise and ExerciseDayProgram 1:many
            modelBuilder.Entity<Exercise>()
             .HasMany(e => e.ExerciseDayPrograms).WithMany(i => i.Exercises)
             .Map(t => t.MapLeftKey("ExerciseID")
                 .MapRightKey("ExerciseDayProgramID")
                 .ToTable("ExerciseExerciseDayProgram"));*/
        }
    }
}