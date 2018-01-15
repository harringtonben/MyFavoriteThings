using System;
using MyFavoriteThings.Things;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization
            var beer = new Beers
            {
                Style = "Porter",
                Brewery = "Founders",
                Drinking = true
            };
            beer.ImOut(beer.Brewery, beer.Style);

            //Object Initialization
            var starwars = new starwarscharacters
            {
                Jedi = "Obi Wan Kenobi",
                Sith = "Darth Vader",
                IsDead = false
            };
            starwars.JediBattle(starwars.Jedi, starwars.Sith);

            //Object Initialization
            var steaks = new Steaks
            {
                Type = "ribeye",
                CookingTemp = "medium rare",
                IsCookedWell = false
            };
            steaks.MyDinner(steaks.Type, steaks.CookingTemp);
        }
    }
}
