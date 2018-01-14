using System;


namespace MyFavoriteThings.Things
{
    class Steaks
    {
        private string _type;
        private string _cookingtemp;
        private bool _iscookedwell;

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public string CookingTemp
        {
            get
            {
                return _cookingtemp;
            }
            set
            {
                _cookingtemp = value;
            }
        }

        public bool IsCookedWell
        {
            get
            {
                return true;
            }
            set
            {
                if (value)
                {
                    _iscookedwell = true;
                }
                if (!value)
                {
                    _iscookedwell = false;
                }
            }
        }


    }
}
