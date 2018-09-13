namespace GraduationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EvenTDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "DateTime");
        }
    }
}
