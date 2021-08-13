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
    public class Joke
    {
        public Joke(string jokes, Language language, Category category, int id)
        {
            Jokes = jokes;
            Language = language;
            Category = category;
            Id = id;
        }

        public int Id { get; set; }
        public string Jokes { get; set; }
        public Language Language { get; set; }
        public Category Category { get; set; }
    }
}
