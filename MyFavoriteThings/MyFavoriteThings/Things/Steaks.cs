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
                return _iscookedwell;
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

        public string MyDinner(string Type, string CookingTemp)
        {
            if (IsCookedWell)
            {
                Console.WriteLine($"I had a really good {_type} cooked {_cookingtemp}.");
            }
            if (!IsCookedWell)
            {
                Console.WriteLine($"I had a really bad {_type} cooked {_cookingtemp}.");
            }
            return "tasty";
            
        }


    }
}
