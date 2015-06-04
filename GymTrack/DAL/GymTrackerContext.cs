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

        public GymTrackerContext() : base ("DefaultConnection")
        {
        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<PlannedRepsAndSets> PlannedRepsAndSets { get; set; }
        public DbSet<ExerciseDayProgram> ExerciseDayPrograms { get; set; }
        public DbSet<Results> Results { get; set; }
                           
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            
            /*
            modelBuilder.Entity<Exercise>()
             .HasMany(e => e.PlannedExercises).WithMany(i => i.)
             .Map(t => t.MapLeftKey("ExerciseID")
                 .MapRightKey("ExerciseDayProgramID")
                 .ToTable("ExerciseExerciseDayProgram"));*/
        }
    }
}