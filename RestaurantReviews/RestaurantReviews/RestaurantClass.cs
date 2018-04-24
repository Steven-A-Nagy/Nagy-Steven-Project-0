using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews 
{
    public class RestaurantClass : IReviewable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string City { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Zipcode { get; set; }
        public string Cuisines { get; set; }
        public List<ReviewClass> ReviewList { get => reviewList; }

        private List<ReviewClass> reviewList = new List<ReviewClass>();

        public void AddReview(ReviewClass NewReview)
        {
            throw new NotImplementedException();
        }

        public void RemoveReview(string ID)
        {
            throw new NotImplementedException();
        }

        public ReviewClass GetReview(string ReviewName)
        {
            throw new NotImplementedException();
        }

        public void PrintReview(string ReviewName)
        {
            throw new NotImplementedException();
        }

        public void PrintAllReviews()
        {
            throw new NotImplementedException();
        }
    }
}
