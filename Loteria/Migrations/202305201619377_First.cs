namespace Loteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nagrodas",
                c => new
                    {
                        NagrodaId = c.Int(nullable: false, identity: true),
                        nagroda = c.String(),
                        Uczestnik_UczestnikId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.NagrodaId)
                .ForeignKey("dbo.Uczestniks", t => t.Uczestnik_UczestnikId)
                .Index(t => t.Uczestnik_UczestnikId);
            
            CreateTable(
                "dbo.Odpowiedzs",
                c => new
                    {
                        OdpowiedzId = c.String(nullable: false, maxLength: 128),
                        tresc = c.String(),
                        poprawnoscOdpowiedzi = c.Boolean(nullable: false),
                        PytanieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdpowiedzId)
                .ForeignKey("dbo.Pytanies", t => t.PytanieId, cascadeDelete: true)
                .Index(t => t.PytanieId);
            
            CreateTable(
                "dbo.Pytanies",
                c => new
                    {
                        PytanieId = c.Int(nullable: false, identity: true),
                        tresc = c.String(),
                    })
                .PrimaryKey(t => t.PytanieId);
            
            CreateTable(
                "dbo.Uczestniks",
                c => new
                    {
                        UczestnikId = c.String(nullable: false, maxLength: 128),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Pseudonim = c.String(),
                    })
                .PrimaryKey(t => t.UczestnikId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nagrodas", "Uczestnik_UczestnikId", "dbo.Uczestniks");
            DropForeignKey("dbo.Odpowiedzs", "PytanieId", "dbo.Pytanies");
            DropIndex("dbo.Odpowiedzs", new[] { "PytanieId" });
            DropIndex("dbo.Nagrodas", new[] { "Uczestnik_UczestnikId" });
            DropTable("dbo.Uczestniks");
            DropTable("dbo.Pytanies");
            DropTable("dbo.Odpowiedzs");
            DropTable("dbo.Nagrodas");
        }
    }
}
