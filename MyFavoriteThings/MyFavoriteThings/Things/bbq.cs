using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Things
{
    class bbq
    {
        public string Cut { get; set; }
        public string Style { get; set; }
        public bool IsTender { get; set; }

        public string BBQReview()
        {
            return IsTender
                ? $"I had some really good {Style} {Cut} today and it was incredibly tender!"
                : $"I had some awful {Style} {Cut} today...hated every second of it.";
        }
    }
}
