using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen
{
    public class JokeStorage
    {
        public List<Joke> ListOfJokes = new List<Joke>()
        {
            new Joke("Ved du hvorfor dværge altid griner når de spiller fodbold... Svar: Fordi græsset kilder dem i numsen.",Language.Danish,Category.Dwarf,1),
            new Joke("Og så var der den om kanibalen der var på slankekur: ...han måtte kun spise dværge",Language.Danish,Category.Dwarf,2),
            new Joke("Where do midgets like to go surfing? On microwaves.",Language.English,Category.Dwarf,3),
            new Joke("Konen lå og hyggede sig med en dværg, da manden kom hjem: Skulle du ikke stoppe med,at være utro?, brølede han.Konen: Kan du ikke se, jeg er ved, at trappe ned?",Language.Danish,Category.Dwarf,4),
            new Joke("I met a midget once, my conversation with her was extremely awkward. I am not very good when it comes to small talk.",Language.English,Category.Dwarf,5),
            new Joke("What do you call a fish wearing a bowtie? Sofishticated.",Language.English,Category.Dad,6),
            new Joke("How do you get a squirrel to like you? Act like a nut.",Language.English,Category.Dad,7),
            new Joke("Hvad er den bedste måde at huske sin kones fødelsdag på? Svar: ved at prøve at glemme den en gang",Language.Danish,Category.Dad,8),
            new Joke("Søn: Far, jeg er sulten Far: Hej Sulten godt at møde dig. Jeg er far Søn: Far, jeg er seriøs... Far: Jeg troede du var sulten? :o) Søn: ER DU SERIØS? Far: Nej, jeg er far",Language.Danish,Category.Dad,9),
            new Joke("Hvilket dyr elsker at samle efter flasker? – Panteren",Language.Danish,Category.Dad,10),
            new Joke("0 is false and 1 is true, Right? Svar: 1",Language.English,Category.Tech,11),
            new Joke("why do java programmers wear glasses Svar: because they don't c#",Language.English,Category.Tech,12),
            new Joke("At sige er Java er godt, fordi det virker på alle platforme, er som at sige, at analsex er godt, fordi det virker med alle køn. (Bonus: Det lugter lidt af lort. Det er fint nok, hvis man bare vil hygge sig - men det er ikke produktivt.)",Language.Danish,Category.Tech,13),
            new Joke("Hvad er forskellen på en Linux bruger og en rotte? Rotten formerer sig.",Language.Danish,Category.Tech,14),
            new Joke("- Hvad gør Bill Gates, når bilen går i stykker ? Han lukker alle vinduer, og prøver at starte igen !",Language.Danish,Category.Tech,15)
        };
    }
}
