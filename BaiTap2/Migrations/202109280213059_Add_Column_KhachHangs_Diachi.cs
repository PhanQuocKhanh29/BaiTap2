namespace BaiTap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_KhachHangs_Diachi : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "TenKH", c => c.String());
            AlterColumn("dbo.KhachHangs", "MaKH", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.KhachHangs", "MaKH");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "MaKH", c => c.String(unicode: false));
            AlterColumn("dbo.KhachHangs", "TenKH", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.KhachHangs", "TenKH");
        }
    }
}
