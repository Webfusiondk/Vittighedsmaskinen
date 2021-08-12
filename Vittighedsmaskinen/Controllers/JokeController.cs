using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class JokeController : Controller
    {
        JokeManager Joke = new JokeManager();
        [HttpGet]
        [Route("Random")]
        public string GetRandomJoke()
        {
            return Joke.GiveRandomJoke();
        }

        public string GetJokeByCategory(string category)
        {

            return Joke.GetJokeFromCategory(category);
        }

        [HttpGet]
        [Route("Categorys")]
        public string GetCategorys()
        {
            return 
        }
    }
}
