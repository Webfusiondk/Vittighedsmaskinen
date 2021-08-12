using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public class JokeManager
    {
        Random r = new Random();
        List<Jokes> ListOfJokes = new List<Jokes>()
        {
            new Jokes("Ved du hvorfor dværge altid griner når de spiller fodbold... Svar: Fordi græsset kilder dem i numsen.",Language.Danish,Category.Dwarf),
            new Jokes("Og så var der den om kanibalen der var på slankekur: ...han måtte kun spise dværge",Language.Danish,Category.Dwarf),
            new Jokes("Where do midgets like to go surfing? On microwaves.",Language.English,Category.Dwarf),
            new Jokes("Konen lå og hyggede sig med en dværg, da manden kom hjem: Skulle du ikke stoppe med,at være utro?, brølede han.Konen: Kan du ikke se, jeg er ved, at trappe ned?",Language.Danish,Category.Dwarf),
            new Jokes("I met a midget once, my conversation with her was extremely awkward. I am not very good when it comes to small talk.",Language.English,Category.Dwarf),
            new Jokes("What do you call a fish wearing a bowtie? Sofishticated.",Language.English,Category.Dad),
            new Jokes("How do you get a squirrel to like you? Act like a nut.",Language.English,Category.Dad),
            new Jokes("Hvad er den bedste måde at huske sin kones fødelsdag på? Svar: ved at prøve at glemme den en gang",Language.Danish,Category.Dad),
            new Jokes("Søn: Far, jeg er sulten Far: Hej Sulten godt at møde dig. Jeg er far Søn: Far, jeg er seriøs... Far: Jeg troede du var sulten? :o) Søn: ER DU SERIØS? Far: Nej, jeg er far",Language.Danish,Category.Dad),
            new Jokes("Hvilket dyr elsker at samle efter flasker? – Panteren",Language.Danish,Category.Dad),
            new Jokes("0 is false and 1 is true, Right? Svar: 1",Language.English,Category.Tech),
            new Jokes("why do java programmers wear glasses Svar: because they don't c#",Language.English,Category.Tech),
            new Jokes("At sige er Java er godt, fordi det virker på alle platforme, er som at sige, at analsex er godt, fordi det virker med alle køn. (Bonus: Det lugter lidt af lort. Det er fint nok, hvis man bare vil hygge sig - men det er ikke produktivt.)",Language.Danish,Category.Tech),
            new Jokes("Hvad er forskellen på en Linux bruger og en rotte? Rotten formerer sig.",Language.Danish,Category.Tech),
            new Jokes("- Hvad gør Bill Gates, når bilen går i stykker ? Han lukker alle vinduer, og prøver at starte igen !",Language.Danish,Category.Tech)
        };

        public string GiveRandomJoke()
        {
            int index = r.Next(ListOfJokes.Count);
            return ListOfJokes[index].Joke;
        }

        public string GetJokeFromCategory(string category)
        {
            List<Jokes> Temp = new List<Jokes>();
            foreach (var item in ListOfJokes)
            {
                if (item.Category.ToString().ToLower() == category.ToLower())
                {
                    Temp.Add(item);
                }
            }
            int index = r.Next(Temp.Count);
            return Temp[index].Joke;
        }

        public void ChoseLanguage()
        {

        }
        public string GetCategorys()
        {
            string temp;
            foreach (var item in ListOfJokes)
            {

            }
        }
    }
}
