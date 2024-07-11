namespace RealEstateDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_customers",
                c => new
                {
                    ctm_id = c.Int(nullable: false, identity: true),
                    ctm_name = c.String(),
                    ctm_surname = c.String(),
                    ctm_phone = c.String(),
                    ctm_email = c.String(),
                })
                .PrimaryKey(t => t.ctm_id);

            CreateTable(
                "dbo.tbl_products",
                c => new
                {
                    prd_id = c.Int(nullable: false, identity: true),
                    prd_type = c.String(),
                    prd_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    prd_title = c.String(),
                    prd_size = c.String(),
                })
                .PrimaryKey(t => t.prd_id);

            CreateTable(
                "dbo.tbl_categories",
                c => new
                {
                    ctg_id = c.Int(nullable: false, identity: true),
                    ctg_name = c.String(),
                    ctg_details = c.String(),
                    ctg_status = c.Boolean(),
                })
                .PrimaryKey(t => t.ctg_id);
        }

        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
