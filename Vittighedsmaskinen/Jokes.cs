using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public enum Language
    {
        Danish,
        English
    }
    public enum Category
    {
        Dad,
        Dwarf,
        Tech
    }
    public class Jokes
    {
        public Jokes(string joke, Language language, Category category)
        {
            Joke = joke;
            Language = language;
            Category = category;
        }

        public string Joke { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }
    }
}
