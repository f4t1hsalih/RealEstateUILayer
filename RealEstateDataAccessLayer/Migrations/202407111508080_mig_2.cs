namespace RealEstateDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_address",
                c => new
                    {
                        ads_id = c.Int(nullable: false, identity: true),
                        ads_address = c.String(),
                        ads_phone1 = c.String(),
                        ads_phone2 = c.String(),
                        ads_email1 = c.String(),
                        ads_email2 = c.String(),
                        ads_mapLocation = c.String(),
                    })
                .PrimaryKey(t => t.ads_id);
            
            CreateTable(
                "dbo.tbl_contacts",
                c => new
                    {
                        cnt_id = c.Int(nullable: false, identity: true),
                        cnt_name = c.String(),
                        cnt_subject = c.String(),
                        cnt_email = c.String(),
                        cnt_description = c.String(),
                        cnt_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.cnt_id);
            
            CreateTable(
                "dbo.tbl_features",
                c => new
                    {
                        ftr_id = c.Int(nullable: false, identity: true),
                        ftr_title = c.String(),
                        ftr_title2 = c.String(),
                        ftr_description = c.String(),
                    })
                .PrimaryKey(t => t.ftr_id);
            
            CreateTable(
                "dbo.tbl_featureServices",
                c => new
                    {
                        fsr_id = c.Int(nullable: false, identity: true),
                        fsr_title = c.String(),
                        fsr_description = c.String(),
                        fsr_image = c.String(),
                    })
                .PrimaryKey(t => t.fsr_id);
            
            CreateTable(
                "dbo.tbl_socialMedias",
                c => new
                    {
                        scl_id = c.Int(nullable: false, identity: true),
                        scl_title = c.String(),
                        scl_url = c.String(),
                    })
                .PrimaryKey(t => t.scl_id);
            
            CreateTable(
                "dbo.tbl_subscribes",
                c => new
                    {
                        sbs_id = c.Int(nullable: false, identity: true),
                        sbs_email = c.String(),
                    })
                .PrimaryKey(t => t.sbs_id);
            
            CreateTable(
                "dbo.tbl_testimonials",
                c => new
                    {
                        tst_id = c.Int(nullable: false, identity: true),
                        tst_name = c.String(),
                        tst_job = c.String(),
                        tst_title = c.String(),
                        tst_description = c.String(),
                        tst_image = c.String(),
                    })
                .PrimaryKey(t => t.tst_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Subscribes");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.FeatureServices");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Addresses");
        }
    }
}
