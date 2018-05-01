using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviewsDataAccess
{
    public interface IDataAccess
    {
        void AddReview(int ID, Review rev);
        void AddRestaurant(Restaurant rest);
        void DeleteRestaurant(int ID);
        void DeleteReview(int RestID, int RevID);
        Restaurant GetRestaurantByID(int id);
        List<Review> GetRestaurantReviews(int id);
        Review GetReviewByRestaurantAndID(int restID, int revID);
        List<Restaurant> GetRestaurants();
    }
}
