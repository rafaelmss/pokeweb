using PokeWeb.DAL;
using PokeWeb.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace PokeWeb.Controllers
{
    /**
    *  Primary controller of the API application. This controller is responsible for receiving all requests in 
    *  the application and handling each of the calls according to the route and parameters received.
    */
    public class pokemonController : ApiController
    {
        /** 
         * Database context.
         * This is the instace of context database based on Entity Framework, the ORM of Microsoft. This is
         * responsable for conect the applicatio to database source and do the operations and transactions.
         */
        PokeWebContext db = new PokeWebContext();

        /**
          * Routine for Pokemon listings. This routine operates by paging system, facilitating the client-side iplementation. 
          * To be executed, this routine waits for two parameters, the page size (number of elements returned) 
          * and the page number.
          * 
          * @param page_size   Number of elements
          * @param page        Number of page
          * @return            List of Pokemons
          * @author            Rafael M. S. Siqueira
          */
        public IHttpActionResult GetAllPokemons(int page_size, int page)
        {            
            if ((page_size == 0) || (page == 0))
            {
                return BadRequest();
            }
            var pokemons = db.Pokemons.ToList();
            return Ok(pokemons.Skip((page-1)*page_size).Take(page_size));
        }

        /**
         * Routine for the list of 6 best Pokemons ordered by attack points. This routine lists the 6 best pokémons 
         * ordered by the attack parameter and calculates the statistical data for this group to help the 
         * client about this information.
         * 
         * @return            Container with the list of 6 top Pokemons ans statistic data 
         * @author            Rafael M. S. Siqueira
         */
        [Route("api/pokemon/top6")]
        public IHttpActionResult GetFirst6PokemonsOrderByAtackDesc()
        {
            var pokemons = db.Pokemons.OrderBy(p => p.attack).Take(6).ToList();

            var statistic = new Statistic();

            foreach (var pokemon in pokemons)
            {
                statistic.attack += pokemon.attack;
                statistic.special_attack += pokemon.special_attack;
                statistic.defense += pokemon.defense;
                statistic.special_defense += pokemon.special_defense;
                statistic.speed += pokemon.speed;
                statistic.hp += pokemon.hp;
            }

            var statisticContainer = new StatisticContainer { pokemons = pokemons, statistic = statistic };

            return Ok(statisticContainer);
        }

        /**
        * Routine for Pokemon details. This Pokemon gets the identification number of a Pokemon and 
        * returns all the data in the application related to that Pokemon
        * 
        * @param id          Identification of Pokemon in database
        * @return            Data of Pokemon
        * @author            Rafael M. S. Siqueira
        */
        public IHttpActionResult GetPokemon(int id)
        {
            var pokemon = db.Pokemons.FirstOrDefault((e) => e.id == id);
            if (pokemon != null && pokemon.id != 0) 
            {
                return Ok(pokemon);
            }
            else
            {
                return NotFound();
            }
            
        }

        /**
        * Routine to send a Pokemon. This routine is responsible for inserting a Pokemon 
        * into the application or updating all the data if it is already registered in the 
        * database of the application
        * 
        * @param Pokemon     All infoirmation about the Pokemon
        * @return            Data of Pokemon with identification
        * @author            Rafael M. S. Siqueira
        */
        public IHttpActionResult PostPokemon(Pokemon pokemon)
        {
            pokemon.id = 0;
            db.Pokemons.Add(pokemon);
            db.SaveChanges();
            return Created("",pokemon);
        }

        /**
        * Routine to send a Pokemon. This routine is responsible for inserting a Pokemon 
        * into the application all the data if it is already registered in the 
        * database of the application
        * 
        * @param Pokemon     All infoirmation about the Pokemon
        * @return            Data of Pokemon with identification
        * @author            Rafael M. S. Siqueira
        */
        public IHttpActionResult PutPokemon(Pokemon pokemon)
        {
            if (pokemon.id != 0)
            {
                var old_pokemon = db.Pokemons.FirstOrDefault((e) => e.id == pokemon.id);
                pokemon.id = old_pokemon.id;
            }
            db.Pokemons.Add(pokemon);
            db.SaveChanges();
            return Created("", pokemon);
        }

        /**
        * Routine to send a Pokemon. This routine is responsible for update a part of
        * infromation about the Pokemon into the application in database
        * 
        * @param Pokemon     Part of infoirmation about the Pokemon
        * @return            Data of Pokemon with identification
        * @author            Rafael M. S. Siqueira
        */
        public IHttpActionResult PatchPokemon(Pokemon pokemon)
        {
            if (pokemon.id == 0)
            {
                return NotFound();
            }

            var old_pokemon = db.Pokemons.FirstOrDefault((e) => e.id == pokemon.id);

            if (pokemon.name != null)
            {
                old_pokemon.name = pokemon.name;
            }

            if (pokemon.image != null)
            {
                old_pokemon.image = pokemon.image;
            }

            if (pokemon.speed != 0)
            {
                old_pokemon.speed = pokemon.speed;
            }

            if (pokemon.defense != 0)
            {
                old_pokemon.defense = pokemon.defense;
            }

            if (pokemon.special_defense != 0)
            {
                old_pokemon.special_defense = pokemon.special_defense;
            }

            if (pokemon.attack != 0)
            {
                old_pokemon.attack = pokemon.attack;
            }

            if (pokemon.special_attack != 0)
            {
                old_pokemon.special_attack = pokemon.special_attack;
            }

            if (pokemon.hp != 0)
            {
                old_pokemon.hp = pokemon.hp;
            }

            if (pokemon.base_experience != 0)
            {
                old_pokemon.base_experience = pokemon.base_experience;
            }

            if (pokemon.height != 0)
            {
                old_pokemon.height = pokemon.height;
            }

            if (pokemon.weigh != 0)
            {
                old_pokemon.weigh = pokemon.weigh;
            }

            if (pokemon.moves.Count != 0)
            {
                old_pokemon.moves = pokemon.moves;
            }

            if (pokemon.abilities.Count != 0)
            {
                old_pokemon.abilities = pokemon.abilities;
            }
            
            db.Pokemons.Add(old_pokemon);
            db.SaveChanges();
            return Ok(pokemon);
        }

        /**
        * Routine to delete a Pokemon. This routine is responsible for remove data
        * about the Pokemon into the application with identification
        * 
        * @param Pokemon     Identification of Pokemon in database
        * @return            Data of Pokemon removed
        * @author            Rafael M. S. Siqueira
        */
        public IHttpActionResult DeletePokemon(int id)
        {
            var pokemon = db.Pokemons.FirstOrDefault((e) => e.id == id);
            if (pokemon == null)
            {
                return NotFound();
            }
            db.Pokemons.Remove(pokemon);
            db.SaveChanges();
            return Ok(pokemon);
        }


    }
}
