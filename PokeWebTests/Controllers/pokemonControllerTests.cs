using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;

namespace PokeWeb.Controllers.Tests
{
    [TestClass()]
    public class pokemonControllerTests
    {
        [TestMethod()]
        public void GetFirst6PokemonsOrderByAtackDescTest()
        {
            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            IHttpActionResult response = controller.GetFirst6PokemonsOrderByAtackDesc();

            Assert.IsNotNull(response);
        }

        [TestMethod()]
        public void GetAllPokemonsTest()
        {
            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            IHttpActionResult response = controller.GetAllPokemons(6,1);

            Assert.IsNotNull(response);
        }

        [TestMethod()]
        public void GetPokemonTest()
        {
            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var pokemon = new Models.Pokemon
            {
                name = "bulbasaur",
                image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                speed = 45,
                special_defense = 65,
                special_attack = 65,
                defense = 49,
                attack = 49,
                hp = 45,
                base_experience = 64,
                height = 7,
                weigh = 69,
                moves = new List<Models.Move> { new Models.Move { name = "razor-wind" }, new Models.Move { name = "echoed-voice" }, new Models.Move { name = "work-up" } },
                abilities = new List<Models.Ability> { new Models.Ability { name = "chlorophyll" }, new Models.Ability { name = "overgrow" } }
            };

            IHttpActionResult response = controller.PostPokemon(pokemon);

            Assert.AreNotSame(pokemon.id, 0);

            response = controller.GetPokemon(Convert.ToInt32(pokemon.id));

            Assert.IsNotNull(response);
        }

        [TestMethod()]
        public void PostPokemonTest()
        {
            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var pokemon = new Models.Pokemon
            {
                name = "bulbasaur",
                image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                speed = 45,
                special_defense = 65,
                special_attack = 65,
                defense = 49,
                attack = 49,
                hp = 45,
                base_experience = 64,
                height = 7,
                weigh = 69,
                moves = new List<Models.Move> { new Models.Move { name = "razor-wind" }, new Models.Move { name = "echoed-voice" }, new Models.Move { name = "work-up" } },
                abilities = new List<Models.Ability> { new Models.Ability { name = "chlorophyll" }, new Models.Ability { name = "overgrow" } }
            };

            IHttpActionResult response = controller.PostPokemon(pokemon);
            
            Assert.AreNotSame(pokemon.id, 0);
        }

        [TestMethod()]
        public void PutPokemonTest()
        {

            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var pokemon = new Models.Pokemon
            {
                name = "bulbasaur",
                image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                speed = 45,
                special_defense = 65,
                special_attack = 65,
                defense = 49,
                attack = 49,
                hp = 45,
                base_experience = 64,
                height = 7,
                weigh = 69,
                moves = new List<Models.Move> { new Models.Move { name = "razor-wind" }, new Models.Move { name = "echoed-voice" }, new Models.Move { name = "work-up" } },
                abilities = new List<Models.Ability> { new Models.Ability { name = "chlorophyll" }, new Models.Ability { name = "overgrow" } }
            };

            IHttpActionResult response = controller.PostPokemon(pokemon);

            var old_id = pokemon.id;
            
            response = controller.PutPokemon(pokemon);

            var new_id = pokemon.id;
            
            Assert.AreNotSame(new_id, old_id);
        }

        [TestMethod()]
        public void PatchPokemonTest()
        {
            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var pokemon = new Models.Pokemon
            {
                id = 1,
                name = "bulbasaur",
                image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                speed = 45,
                special_defense = 65,
                special_attack = 65,
                defense = 49,
                attack = 49,
                hp = 45,
                base_experience = 64,
                height = 7,
                weigh = 69,
                moves = new List<Models.Move> { new Models.Move { name = "razor-wind" }, new Models.Move { name = "echoed-voice" }, new Models.Move { name = "work-up" } },
                abilities = new List<Models.Ability> { new Models.Ability { name = "chlorophyll" }, new Models.Ability { name = "overgrow" } }
            };

            IHttpActionResult response = controller.PostPokemon(pokemon);

            pokemon.image = "teste";

            response = controller.PatchPokemon(pokemon);

            Assert.IsNotNull(response);
        }

        [TestMethod()]
        public void DeletePokemonTest()
        {
            pokemonController controller = new pokemonController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/api/pokemon/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var pokemon = new Models.Pokemon
            {
                name = "bulbasaur",
                image = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                speed = 45,
                special_defense = 65,
                special_attack = 65,
                defense = 49,
                attack = 49,
                hp = 45,
                base_experience = 64,
                height = 7,
                weigh = 69,
                moves = new List<Models.Move> { new Models.Move { name = "razor-wind" }, new Models.Move { name = "echoed-voice" }, new Models.Move { name = "work-up" } },
                abilities = new List<Models.Ability> { new Models.Ability { name = "chlorophyll" }, new Models.Ability { name = "overgrow" } }
            };

            IHttpActionResult response = controller.PutPokemon(pokemon);

            Assert.AreNotSame(pokemon.id, 0);

            response = controller.DeletePokemon(Convert.ToInt32(pokemon.id));

            Assert.IsNotNull(response);
        }
    }
}