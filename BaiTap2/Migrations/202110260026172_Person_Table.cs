namespace BaiTap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Person_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        NamePerson = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
