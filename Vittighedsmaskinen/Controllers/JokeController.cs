using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Vittighedsmaskinen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : Controller
    {
        List<Joke> UsedJokes;
        JokeManager JokeManager = new JokeManager();
        [HttpGet]
        [Route("Random")]
        public IActionResult GetRandomJoke()
        {
            try
            {
                string tempString = GetUserFavoriteCategory();
                if (tempString != null)
                {
                    return GetJokeByCategory(tempString);
                }

                GetUsedJokesList();
                //Gets a random joke and addes it to the session. And returns the joke to the front end
                Joke Temp = JokeManager.GiveRandomJoke(UsedJokes, CheckForDefaultLanguage());
                UsedJokes.Add(Temp);
                HttpContext.Session.SetObjectAsJson("UsedJokes", UsedJokes);
                return Ok(Temp);
            }
            catch (ArgumentOutOfRangeException)
            {
                return BadRequest("Out of jokes.");
            }
        }
        [ApiKeyAuth]
        [HttpGet]
        [Route("Secret")]
        public IActionResult GetSecretJoke()
        {
            Joke Temp = JokeManager.GiveSecretJoke();
            return Ok(Temp);
        }
        public IActionResult GetJokeByCategory(string category)
        {
            try
            {
                //Gets a random joke from category.
                GetUsedJokesList();
                Joke temp = JokeManager.GetJokeFromCategory(category, UsedJokes, CheckForDefaultLanguage());
                SetUserFavoriteCategory(temp.Category);
                UsedJokes.Add(temp);
                HttpContext.Session.SetObjectAsJson("UsedJokes", UsedJokes);
                return Ok(temp);

            }
            catch (ArgumentOutOfRangeException)
            {
                return BadRequest("Out of jokes");
            }
            catch (ArgumentException)
            {
                //catch exeption when validating category
                return BadRequest("Wrong input");
            }
        }

        [HttpGet]
        [Route("Categorys")]
        public string GetCategorys()
        {
            return JokeManager.Categorys();
        }

        private void GetUsedJokesList()
        {
            //Check if we allrdy have a session with used jokes.
            //If not we make one
            UsedJokes = HttpContext.Session.GetObjectFromJson<List<Joke>>("UsedJokes");
            if (UsedJokes == null)
            {
                UsedJokes = new List<Joke>();
            }
        }
        private string GetUserFavoriteCategory()
        {
            //returns Favorit Category
            return HttpContext.Request.Cookies["FavoritCategory"];
        }
        private string CheckForDefaultLanguage()
        {
            //Gets the Accepted languages from the hedder
            string temp = HttpContext.Request.Headers["Accept-Language"];
            //Splits the languages into an array of strings
            var languages = temp.Split(',')
                .Select(StringWithQualityHeaderValue.Parse)
                .OrderByDescending(s => s.Quality.GetValueOrDefault(1));
            //Finds the language with the highest Quality
            double? maxQ = languages.Max(r => r.Quality);
            foreach (var item in languages)
            {
                if (item.Quality == maxQ)
                {
                    //returns the default language
                    return item.Value;
                }
            }
            return "";
        }
        private void SetUserFavoriteCategory(Category category)
        {
            //sets last category used
            CookieOptions option = new CookieOptions();
            option.Expires = DateTimeOffset.Now.AddMinutes(5);
            Response.Cookies.Append("FavoritCategory", category.ToString(), option);
        }
    }
}
