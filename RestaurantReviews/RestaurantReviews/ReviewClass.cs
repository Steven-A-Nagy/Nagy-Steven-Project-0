using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public class ReviewClass
    {
        public string ReviewID { get; set; }
        public int Rating { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewBody { get; set; }

        public void PrintReviewBody()
        {
            throw new NotImplementedException();
        }

        public void PrintName()
        {
            throw new NotImplementedException();
        }

        public void PrintRating()
        {
            throw new NotImplementedException();
        }
        
        public void PrintFullReview()
        {
            throw new NotImplementedException();
        }
    }
}
