using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews 
{
    class RestaurantClass : IReviewable
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public List<ReviewClass> ReviewList = new List<ReviewClass>();

        public void AddReview(ReviewClass NewReview)
        {
            throw new NotImplementedException();
        }

        public void RemoveReview(string ID)
        {
            throw new NotImplementedException();
        }

        public ReviewClass GetReview()
        {
            throw new NotImplementedException();
        }

        public void PrintRestaurantInfo()
        {
            throw new NotImplementedException();
        }

        public void PrintAllReviews()
        {
            throw new NotImplementedException();
        }

    }
}
