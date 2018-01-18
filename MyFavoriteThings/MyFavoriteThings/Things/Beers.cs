using System;

namespace MyFavoriteThings.Things
{
    class Beers
    {
       
        private string _style;
        private string _brewery;
        protected bool _drinking;

        public string Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }

        public string Brewery
        {
            get
            {
                return _brewery;
            }
            set
            {
                _brewery = value;
            }
        }

        public bool Drinking
        { 
            get
            {
                return _drinking;
            }
            set
            {
                if (value)
                {
                    _drinking = true;
                }
                if (!value)
                {
                    _drinking = false;
                }
            }
        }

        public string ImOut(string Brewery, string Style)
        {

            return "I'll have another " + _brewery + " " + _style + ".";
                 
            
        }
    }
}
