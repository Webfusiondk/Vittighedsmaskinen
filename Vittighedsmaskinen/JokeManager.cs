using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public class JokeManager
    {
        Random r = new Random();
        JokeStorage jokeStorage = new JokeStorage();
        public Joke GiveRandomJoke(List<Joke> UsedJokes, string language)
        {
            //Try and catch for when we run out of jokes.
            FilterListForUsedJokes(UsedJokes);
            Language defaultLanguage = ChoseLanguage(language);
            //Give a random joke from  the list.
            int index = r.Next(jokeStorage.ListOfJokes.Where(joke => joke.Language == defaultLanguage).Count());
            Joke temp = jokeStorage.ListOfJokes[index];
            return temp;

        }
        public Joke GiveSecretJoke()
        {
            int index = r.Next(jokeStorage.SecretListOfJokes.Count);
            Joke temp = jokeStorage.SecretListOfJokes[index];
            return temp;
        }
        public Joke GetJokeFromCategory(string category, List<Joke> UsedJokes, string language)
        {

            //loop threw the list from the highest to lowest. So we dont miss any jokes.
            Language defaultLanguage = ChoseLanguage(language);
            Category chosenCategory = ValidateCategoryInput(category);
            FilterListForUsedJokes(UsedJokes);
            for (int i = jokeStorage.ListOfJokes.Count - 1; i >= 0; i--)
            {
                //Checks if the joke are not Category we are looking for
                if (jokeStorage.ListOfJokes[i].Category != chosenCategory)
                {
                    //Checks if the joke are not the Language we are looking for
                    if (jokeStorage.ListOfJokes[i].Language != defaultLanguage)
                    {
                        jokeStorage.ListOfJokes.RemoveAt(i);
                    }
                }
            }
            return jokeStorage.ListOfJokes[r.Next(jokeStorage.ListOfJokes.Count)];
        }

        public string Categorys()
        {
            //returns a combind string of the categorys.
            string temp = "";
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                temp += category + "\n";
            }
            return temp;
        }

        private Category ValidateCategoryInput(string categoryType)
        {
            //Validates the category we are looking for
            Category category;
            category = (Category)Enum.Parse(typeof(Category), categoryType.First().ToString().ToUpper() + categoryType.Substring(1));
            return category;
        }
        private Language ChoseLanguage(string language)
        {
            switch (language)
            {
                case "da":
                    return Language.Danish;
                case"en" :
                    return Language.English;
            }
            //if no language match found Danish is default.
            return Language.Danish;
        }
        private void FilterListForUsedJokes(List<Joke> UsedJokes)
        {
            //Goes through the listofjokes to find used jokes and remove them.
            for (int i = 0; i < UsedJokes.Count; i++)
            {
                for (int j = 0; j < jokeStorage.ListOfJokes.Count; j++)
                {
                    if (UsedJokes[i].Id == jokeStorage.ListOfJokes[j].Id)
                    {
                        jokeStorage.ListOfJokes.RemoveAt(j);
                    }
                }
            }
        }
    }
}
