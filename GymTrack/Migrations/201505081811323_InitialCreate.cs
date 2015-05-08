namespace GymTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExerciseID = c.Int(nullable: false),
                        ExerciseDate = c.DateTime(nullable: false),
                        SetNumber = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Reps = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exercises", t => t.ExerciseID, cascadeDelete: true)
                .Index(t => t.ExerciseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "ExerciseID", "dbo.Exercises");
            DropIndex("dbo.Results", new[] { "ExerciseID" });
            DropTable("dbo.Results");
            DropTable("dbo.Exercises");
        }
    }
}
