namespace GymTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExerciseDayPrograms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExerciseDayName = c.String(),
                        ExerciseID = c.Int(nullable: false),
                        PlannedSets = c.Int(nullable: false),
                        PlannedReps = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exercises", t => t.ExerciseID, cascadeDelete: true)
                .Index(t => t.ExerciseID);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExerciseDayProgramID = c.Int(nullable: false),
                        ExerciseID = c.Int(nullable: false),
                        ExerciseDate = c.DateTime(nullable: false),
                        SetNumber = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Reps = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExerciseDayPrograms", t => t.ExerciseDayProgramID, cascadeDelete: true)
                .Index(t => t.ExerciseDayProgramID);
            
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExerciseName = c.String(),
                        Description = c.String(),
                        VideoURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExerciseDayPrograms", "ExerciseID", "dbo.Exercises");
            DropForeignKey("dbo.Results", "ExerciseDayProgramID", "dbo.ExerciseDayPrograms");
            DropIndex("dbo.Results", new[] { "ExerciseDayProgramID" });
            DropIndex("dbo.ExerciseDayPrograms", new[] { "ExerciseID" });
            DropTable("dbo.Exercises");
            DropTable("dbo.Results");
            DropTable("dbo.ExerciseDayPrograms");
        }
    }
}
