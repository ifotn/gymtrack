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
        public GymTrackerContext() : base ("GymTrackerContext")
        {

        }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Results> Results { get; set; }
    }
}