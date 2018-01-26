using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PokeWeb.DAL
{
    /**
    *  Class of context database. This class is user for EntityFramework an extend "DbContext" to manage 
    *  the access of database with MySQL Server 2014.
    */
    public class PokeWebContext : DbContext
    {
        /**
          * Constructor of database context. This contriuctor mapping access data informatio this TAG "PokeWebContext" in
          * "Web.config" file.
          */
        public PokeWebContext() : base("PokeWebContext")
        {
        }

        /**
          * Dataset to map object Pokemon in database. This used with Entity Framework to
          * generate all resources with percistence using MySQL Server 2014.
          */
        public DbSet<Models.Pokemon> Pokemons { get; set; }
    }
}