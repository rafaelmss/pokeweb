namespace PokeWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    /**
    *  Class to create/update database. This class was created for the "add-migrations" command in the Package 
    *  Manager Console after deployment and generated the database flow to create and/or update the database structure. 
    *  At each project update this command must be executed and a new "DbMigration" is created.
    */
    public partial class CreateDatabase : DbMigration
    {
        /**
        *  Routine to create tables. This routine is responsible for creating or updating 
        *  the tables in the database, mirroring the most recent structure of the objects in the project.
        */
        public override void Up()
        {
            CreateTable(
                "dbo.Pokemons",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        image = c.String(),
                        speed = c.Int(nullable: false),
                        defense = c.Int(nullable: false),
                        attack = c.Int(nullable: false),
                        special_defense = c.Int(nullable: false),
                        special_attack = c.Int(nullable: false),
                        hp = c.Int(nullable: false),
                        base_experience = c.Int(nullable: false),
                        height = c.Int(nullable: false),
                        weigh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        Pokemon_id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Pokemons", t => t.Pokemon_id)
                .Index(t => t.Pokemon_id);
            
            CreateTable(
                "dbo.Moves",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        Pokemon_id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Pokemons", t => t.Pokemon_id)
                .Index(t => t.Pokemon_id);
            
        }

        /**
        *  Routine to delete tables. This routine is responsible for delete 
        *  the tables in the database, mirroring the most recent structure of the objects in the project.
        */
        public override void Down()
        {
            DropForeignKey("dbo.Moves", "Pokemon_id", "dbo.Pokemons");
            DropForeignKey("dbo.Abilities", "Pokemon_id", "dbo.Pokemons");
            DropIndex("dbo.Moves", new[] { "Pokemon_id" });
            DropIndex("dbo.Abilities", new[] { "Pokemon_id" });
            DropTable("dbo.Moves");
            DropTable("dbo.Abilities");
            DropTable("dbo.Pokemons");
        }
    }
}
