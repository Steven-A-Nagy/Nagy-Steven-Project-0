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
        public Dictionary<int, ReviewClass> ReviewList { get => reviewList; }

        private Dictionary<int, ReviewClass> reviewList = new Dictionary<int, ReviewClass>();

        public RestaurantClass()
        {
            throw new NotImplementedException();
        }

        public RestaurantClass(string name, string address, string locality, string city, string latitude, string longitude, string zipcode, string cuisines)
        {
            Name = name;
            Address = address;
            Locality = locality;
            City = city;
            Latitude = latitude;
            Longitude = longitude;
            Zipcode = zipcode;
            Cuisines = cuisines;
        }

        public void AddReview(ReviewClass NewReview)
        {
            ReviewList.Add(ReviewList.Count(), NewReview);
        }

        public void RemoveReview(int ID)
        {
            ReviewList.Remove(ID);
        }

        public ReviewClass GetReview(int ID)
        {
            return ReviewList[ID];
        }

        public void PrintReview(int ID)
        {
            ReviewList[ID].PrintFullReview();
        }

        public void PrintAllReviews()
        {
            foreach (int element in ReviewList.Keys)
            {
                PrintReview(element);
            }
        }
    }
}
