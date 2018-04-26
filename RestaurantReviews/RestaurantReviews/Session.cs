using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public sealed class Session
    {
        private static readonly Session instance = new Session();
        static Session()
        {

        }
        private Session()
        {

        }
        public static Session Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
