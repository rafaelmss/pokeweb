namespace PokeWeb.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PokeWeb.DAL.PokeWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /**
        *  Routine to populate database. This routine is used where database is updated for command "update-database" int Package Manager Console.
        *  This command update/create the database en use this routine to create the first 15 pokemons.
        */
        protected override void Seed(PokeWeb.DAL.PokeWebContext context)
        {

            var pokemons = new List<Models.Pokemon>
            {
                new Models.Pokemon{
                    name ="bulbasaur",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                    speed = 45,
                    special_defense = 65,
                    special_attack = 65,
                    defense = 49,
                    attack = 49,
                    hp = 45,
                    base_experience = 64,
                    height = 7,
                    weigh = 69,
                    moves = new List<Models.Move>{new Models.Move{name= "razor-wind"},new Models.Move { name = "echoed-voice"},new Models.Move { name = "work-up"} },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "chlorophyll"},new Models.Ability { name = "overgrow"} }
                },                
                new Models.Pokemon{
                    name ="ivysaur",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png",
                    speed = 60,
                    special_defense = 80,
                    special_attack = 80,
                    defense = 63,
                    attack = 62,
                    hp = 60,
                    base_experience = 142,
                    height = 10,
                    weigh = 130,
                    moves = new List<Models.Move>{new Models.Move{name= "swords-dance" },new Models.Move { name = "cut" },new Models.Move { name = "bind" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "chlorophyll" },new Models.Ability { name = "overgrow" } }
                },
                new Models.Pokemon{
                    name ="venusaur",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png",
                    speed = 80,
                    special_defense = 100,
                    special_attack = 100,
                    defense = 83,
                    attack = 82,
                    hp = 80,
                    base_experience = 236,
                    height = 20,
                    weigh = 1000,
                    moves = new List<Models.Move>{new Models.Move{name= "swords-dance" },new Models.Move { name = "cut" },new Models.Move { name = "vine-whip" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "chlorophyll" },new Models.Ability { name = "overgrow" } }
                },
                new Models.Pokemon{
                    name ="charmander",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png",
                    speed = 65,
                    special_defense = 50,
                    special_attack = 60,
                    defense = 43,
                    attack = 52,
                    hp = 39,
                    base_experience = 62,
                    height = 6,
                    weigh = 85,
                    moves = new List<Models.Move>{new Models.Move{name= "mega-punch" },new Models.Move { name = "fire-punch" },new Models.Move { name = "thunder-punch" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "solar-power" },new Models.Ability { name = "blaze" } }
                },
                new Models.Pokemon{
                    name ="charmeleon",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png",
                    speed = 80,
                    special_defense = 65,
                    special_attack = 80,
                    defense = 58,
                    attack = 64,
                    hp = 58,
                    base_experience = 142,
                    height = 11,
                    weigh = 190,
                    moves = new List<Models.Move>{new Models.Move{name= "mega-punch" },new Models.Move { name = "fire-punch" },new Models.Move { name = "scratch" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "solar-power" },new Models.Ability { name = "blaze" } }
                },
                new Models.Pokemon{
                    name ="charizard",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png",
                    speed = 100,
                    special_defense = 85,
                    special_attack = 109,
                    defense = 78,
                    attack = 84,
                    hp = 78,
                    base_experience = 240,
                    height = 17,
                    weigh = 905,
                    moves = new List<Models.Move>{new Models.Move{name= "wing-attack" },new Models.Move { name = "fire-punch" },new Models.Move { name = "scratch" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "solar-power" },new Models.Ability { name = "blaze" } }
                },
                new Models.Pokemon{
                    name ="squirtle",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png",
                    speed = 43,
                    special_defense = 64,
                    special_attack = 50,
                    defense = 65,
                    attack = 48,
                    hp = 44,
                    base_experience = 63,
                    height = 5,
                    weigh = 90,
                    moves = new List<Models.Move>{new Models.Move{name= "mega-punch" },new Models.Move { name = "ice-punch" },new Models.Move { name = "mega-kick" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "rain-dish" },new Models.Ability { name = "torrent" } }
                },
                new Models.Pokemon{
                    name ="wartortle",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png",
                    speed = 58,
                    special_defense = 80,
                    special_attack = 65,
                    defense = 80,
                    attack = 63,
                    hp = 59,
                    base_experience = 142,
                    height = 10,
                    weigh = 225,
                    moves = new List<Models.Move>{new Models.Move{name= "mega-punch" },new Models.Move { name = "ice-punch" },new Models.Move { name = "headbutt" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "rain-dish" },new Models.Ability { name = "torrent" } }
                },
                new Models.Pokemon{
                    name ="blastoise",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png",
                    speed = 78,
                    special_defense = 105,
                    special_attack = 85,
                    defense = 100,
                    attack = 83,
                    hp = 79,
                    base_experience = 239,
                    height = 16,
                    weigh = 855,
                    moves = new List<Models.Move>{new Models.Move{name= "mega-punch" },new Models.Move { name = "ice-punch" },new Models.Move { name = "tackle" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "rain-dish" },new Models.Ability { name = "torrent" } }
                },
                new Models.Pokemon{
                    name ="caterpie",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png",
                    speed = 45,
                    special_defense = 20,
                    special_attack = 20,
                    defense = 35,
                    attack = 30,
                    hp = 45,
                    base_experience = 39,
                    height = 3,
                    weigh = 29,
                    moves = new List<Models.Move>{new Models.Move{name= "tackle" },new Models.Move { name = "string-shot" },new Models.Move { name = "snore" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "run-away" },new Models.Ability { name = "shield-dust" } }
                },
                new Models.Pokemon{
                    name ="metapod",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png",
                    speed = 30,
                    special_defense = 25,
                    special_attack = 25,
                    defense = 55,
                    attack = 20,
                    hp = 50,
                    base_experience = 72,
                    height = 7,
                    weigh = 99,
                    moves = new List<Models.Move>{new Models.Move{name= "string-shot" },new Models.Move { name = "harden" },new Models.Move { name = "iron-defense" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "shed-skin" } }
                },
                new Models.Pokemon{
                    name ="butterfree",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png",
                    speed = 70,
                    special_defense = 80,
                    special_attack = 90,
                    defense = 50,
                    attack = 45,
                    hp = 60,
                    base_experience = 178,
                    height = 11,
                    weigh = 320,
                    moves = new List<Models.Move>{new Models.Move{name= "razor-wind" },new Models.Move { name = "gust" },new Models.Move { name = "whirlwind" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "tinted-lens" },new Models.Ability { name = "compound-eyes" } }
                },
                new Models.Pokemon{
                    name ="weedle",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png",
                    speed = 50,
                    special_defense = 20,
                    special_attack = 20,
                    defense = 30,
                    attack = 35,
                    hp = 40,
                    base_experience = 39,
                    height = 3,
                    weigh = 32,
                    moves = new List<Models.Move>{new Models.Move{name= "poison-sting" },new Models.Move { name = "string-shot" },new Models.Move { name = "bug-bite" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "run-away" },new Models.Ability { name = "shield-dust" } }
                },
                new Models.Pokemon{
                    name ="kakuna",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png",
                    speed = 35,
                    special_defense = 25,
                    special_attack = 25,
                    defense = 50,
                    attack = 25,
                    hp = 45,
                    base_experience = 72,
                    height = 6,
                    weigh = 100,
                    moves = new List<Models.Move>{new Models.Move{name= "string-shot" },new Models.Move { name = "harden" },new Models.Move { name = "iron-defense" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "shed-skin" } }
                },
                new Models.Pokemon{
                    name ="beedrill",
                    image ="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png",
                    speed = 75,
                    special_defense = 80,
                    special_attack = 45,
                    defense = 40,
                    attack = 90,
                    hp = 65,
                    base_experience = 39,
                    height = 3,
                    weigh = 295,
                    moves = new List<Models.Move>{new Models.Move{name= "swords-dance" },new Models.Move { name = "cut" },new Models.Move { name = "fury-attack" } },
                    abilities = new List<Models.Ability>{new Models.Ability{ name = "sniper" },new Models.Ability { name = "swarm" } }
                }
            };

            pokemons.ForEach(s => context.Pokemons.Add(s));
            context.SaveChanges();
        }
    }
}
