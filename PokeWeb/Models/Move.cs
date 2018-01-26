using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeWeb.Models
{
    /**
     * Move class represents the Pokemon move object. This object is grouped in list form and related to a Pokemon
     */
    public class Move
    {
        /** 
         * An identification element. 
        */
        public long id { get; set; }

        /** 
         * A name of ability. 
        */
        public string name { get; set; }
    }
}