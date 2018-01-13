using System;

namespace MyFavoriteThings.Things
{
    class Beers
    {
       
        private string _ipas;
        private string _stouts;

        public string ipas
        {
            get
            {
                return _ipas;
            }
            set
            {
                _ipas = value;
            }
        }

        public string stouts
        {
            get
            {
                return _stouts;
            }
            set
            {
                _stouts = value;
            }
        }

        public bool Drinking(string drinking)
        {
            drinking = _stouts;
            return true;
        }

        public string ImOut()
        {
            return ("I'll have another");
        }
    }
}
