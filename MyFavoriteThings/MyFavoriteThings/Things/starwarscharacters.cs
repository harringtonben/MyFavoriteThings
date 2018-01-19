using System;

namespace MyFavoriteThings.Things
{
    class starwarscharacters
    {
        private string _jedi;
        private string _sith;
        private bool _isDead;

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

        public bool IsDead
        {
            get
            {
                return _isDead;
            }
            set
            {
                if (value)
                {
                    _isDead = true;
                }
                if (!value)
                {
                    _isDead = false;
                }
            }
        }

        public string JediBattle(string Jedi, string Sith)
        {
            return $"{_jedi} fought {_sith}, and {_jedi} beat {_sith}";
             
        }

    }
}
