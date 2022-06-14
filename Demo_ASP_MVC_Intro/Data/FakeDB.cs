using Demo_ASP_MVC_Intro.Models;

namespace Demo_ASP_MVC_Intro.Data
{
    public static class FakeDB
    {
        public static IEnumerable<Duck> Ducks = new List<Duck>
        {
            new Duck {
                Id= 1,
                Firstname= "Zaza",
                Lastname = "Vanderquack",
                Birthdate = new DateTime(2006, 11, 20),
                Address = "Lac du village"
            },
            new Duck {
                Id= 2,
                Firstname= "Balthazar",
                Lastname = "Picsou",
                Birthdate = new DateTime(1967, 2, 2),
                Address = "Lac du village"
            },
            new Duck
            {
                Id = 3,
                Firstname = "Della",
                Lastname = "Duck",
                Birthdate = new DateTime(1990, 1, 10),
                Address = "Lac de l'aventure"
            }
        };

    }
}
