using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeWeb.Models
{
    /** 
     * Pokemon class represents the Pokemon in all project. This object contain all information about the Pokemon
    */
    public class Pokemon
    {
        /** 
         * An identification element. 
        */
        public long id { get; set; }

        /** 
         * A name of Pokemon. 
        */
        public string name { get; set; }

        /** 
         * A path to Pokemon image. 
        */
        public string image { get; set; }

        /** 
         * A speed attribute of the Pokemon. 
        */
        public int speed { get; set; }

        /** 
         * A defence attribute of the Pokemon. 
        */
        public int defense { get; set; }

        /** 
         * A attack attribute of the Pokemon. 
        */
        public int attack { get; set; }

        /** 
         * A special defence attribute of the Pokemon. 
        */
        public int special_defense { get; set; }

        /** 
         * A special attack attribute of the Pokemon. 
        */
        public int special_attack { get; set; }

        /** 
         * A health points attribute of the Pokemon. 
        */
        public int hp { get; set; }

        /** 
         * A experience points attribute of the Pokemon. 
        */
        public int base_experience { get; set; }

        /** 
         * A height attribute of the Pokemon. 
        */
        public int height { get; set; }

        /** 
         * A weigh attribute of the Pokemon. 
        */
        public int weigh { get; set; }

        /** 
         * A list of moves of the Pokemon. 
        */
        public virtual ICollection<Move> moves { get; set; }

        /** 
         * A list of abilities of the Pokemon. 
        */
        public virtual ICollection<Ability> abilities { get; set; }


    }
}