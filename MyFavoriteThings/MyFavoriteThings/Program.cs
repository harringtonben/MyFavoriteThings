﻿using System;
using System.Collections.Generic;
using MyFavoriteThings.Things;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization
            //var beer = new Beers
            //{
            //    Style = "Porter",
            //    Brewery = "Founders",
            //    Drinking = true
            //};
            //beer.ImOut(beer.Brewery, beer.Style);

            //Object Initialization
            //var starwars = new starwarscharacters
            //{
            //    Jedi = "Obi Wan Kenobi",
            //    Sith = "Darth Vader",
            //    IsDead = false
            //};
            //starwars.JediBattle(starwars.Jedi, starwars.Sith);

            //Object Initialization
            //var steaks = new Steaks
            //{
            //    Type = "ribeye",
            //    CookingTemp = "medium rare",
            //    IsCookedWell = false
            //};
            //steaks.MyDinner(steaks.Type, steaks.CookingTemp);

            var beers = new List<Beers>
            {
                new Beers { Style = "IPA", Brewery = "Treehouse", Drinking = true},
                new Beers { Style = "Pilsner", Brewery = "Jackalope", Drinking = false},
                new Beers { Style = "Stout", Brewery = "Bells", Drinking = true}
            };

            foreach (var beer in beers)
            {
                Console.WriteLine(beer.ImOut(beer.Style, beer.Brewery));
            }

            var StarWars = new List<starwarscharacters>
            {
                new starwarscharacters { Jedi = "Obi Wan Kenobi", Sith = "Darth Vader", IsDead = false},
                new starwarscharacters { Jedi = "Yoda", Sith = "Darth Sidious", IsDead = true},
                new starwarscharacters { Jedi = "Luke Skywalker", Sith = "Darth Vader", IsDead = false}
            };

            foreach (var character in StarWars)
            {
                Console.WriteLine(character.JediBattle(character.Jedi, character.Sith));
            }

            var steaks = new List<Steaks>
            {
                new Steaks { Type = "Filet", CookingTemp = "Medium Rare", IsCookedWell = true},
                new Steaks { Type = "Ribeye", CookingTemp = "Medium Rare", IsCookedWell = true},
                new Steaks { Type = "Flank", CookingTemp = "Medium Well", IsCookedWell = false}
            };

            foreach (var steak in steaks)
            {
                Console.WriteLine(steak.MyDinner(steak.Type, steak.CookingTemp));
            }

            var BBQ = new List<bbq>
            {
                new bbq { Cut = "Whole Hog", Style = "Carolina Style", IsTender = true},
                new bbq { Cut = "Ribs", Style = "Memphis Style", IsTender = false},
                new bbq { Cut = "Brisket", Style = "Texas Style", IsTender = true}
            };

            foreach (var meat in BBQ)
            {
                Console.WriteLine(meat.BBQReview());
            }
            Console.Read();
        }
    }
}
