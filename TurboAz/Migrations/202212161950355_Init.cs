namespace TurboAz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BanTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        ProductionYear = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        IsOld = c.Boolean(nullable: false),
                        UsageDistance = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                        EnergyTypeId = c.Int(nullable: false),
                        BanTypeId = c.Int(nullable: false),
                        ManufacturerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BanTypes", t => t.BanTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.EnergyTypes", t => t.EnergyTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ColorId)
                .Index(t => t.EnergyTypeId)
                .Index(t => t.BanTypeId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnergyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnergyTypeName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManuacturerName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Cars", "EnergyTypeId", "dbo.EnergyTypes");
            DropForeignKey("dbo.Cars", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Cars", "BanTypeId", "dbo.BanTypes");
            DropIndex("dbo.Cars", new[] { "ManufacturerId" });
            DropIndex("dbo.Cars", new[] { "BanTypeId" });
            DropIndex("dbo.Cars", new[] { "EnergyTypeId" });
            DropIndex("dbo.Cars", new[] { "ColorId" });
            DropTable("dbo.Models");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.EnergyTypes");
            DropTable("dbo.Colors");
            DropTable("dbo.Cars");
            DropTable("dbo.BanTypes");
        }
    }
}
