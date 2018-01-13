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
        }
    }
}
