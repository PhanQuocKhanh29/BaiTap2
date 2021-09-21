namespace BaiTap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Khachhang_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        TenKH = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TenKH);
            
            AddColumn("dbo.Students", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Address");
            DropTable("dbo.KhachHangs");
        }
    }
}
