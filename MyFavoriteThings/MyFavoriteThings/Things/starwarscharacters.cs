using System;

namespace MyFavoriteThings.Things
{
    class starwarscharacters
    {
        private string _jedi;
        private string _sith;
        private bool _isdead;

        public string Jedi
        {
            get
            {
                return _jedi;
            }
            set
            {
                _jedi = value;
            }
        }

        public string Sith
        {
            get
            {
                return _sith;
            }
            set
            {
                _sith = value;
            }
        }
    }
}
