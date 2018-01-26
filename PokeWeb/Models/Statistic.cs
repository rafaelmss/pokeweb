using System.Collections.Generic;

namespace PokeWeb.Models
{
    /**
     * Statistic class represents the Pokemon sum attributes. This object is created where clint request the 6 top attacks points Pokemons
     */
    public class Statistic
    {
        /** 
         * A speed attribute sum of the Pokemon. 
        */
        public int speed { get; set; }

        /** 
         * A defence attribute sum of the Pokemon. 
        */
        public int defense { get; set; }

        /** 
         * A attack attribute sum of the Pokemon. 
        */
        public int attack { get; set; }

        /** 
         * A special defence attribute sum of the Pokemon. 
        */
        public int special_defense { get; set; }

        /** 
         * A special attack attribute sum of the Pokemon. 
        */
        public int special_attack { get; set; }

        /** 
         * A speed health points sum of the Pokemon. 
        */
        public int hp { get; set; }
    }

    /**
     * StatisticContainer class represents the list of top 6 Pokemons and statistics data. This object is created where clint request the 6 
     * top attacks points Pokemons and used to return de statistic data and the list of top 6 Pokemons
     */
    public class StatisticContainer
    {
        /**
         * List of 6 top attack attribute Pokemons
         */
        public IList<Pokemon> pokemons { get; set; }

        /**
         * Statistic data about this goup of Pokemons
         */
        public Statistic statistic { get; set; }
    }
}