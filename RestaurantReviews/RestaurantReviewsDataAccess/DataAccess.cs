using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsDataAccess
{
    public class DataAccess : IDataAccess
    {
        RestaurantReviewsDBEntities db = new RestaurantReviewsDBEntities();

        public void AddRestaurant(Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public void AddReview(int ID, Review rev)
        {
            throw new NotImplementedException();
        }

        public void DeleteRestaurant(int ID)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(int RestID, int RevID)
        {
            throw new NotImplementedException();
        }

        public Restaurant GetRestaurantByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetRestaurantReviews(int id)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestaurants()
        {
            throw new NotImplementedException();
        }

        public Review GetReviewByRestaurantAndID(int restID, int revID)
        {
            throw new NotImplementedException();
        }
    }
}
