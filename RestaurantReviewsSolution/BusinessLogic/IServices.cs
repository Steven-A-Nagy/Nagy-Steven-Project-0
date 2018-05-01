using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsModels;

namespace BusinessLogic
{
    public interface IRestServ
    {
        List<Restaurant> TopThreeRests();
        List<Restaurant> AllRests();
        List<Restaurant> SearchAll();
        Restaurant SearchByName(string name);
        List<Restaurant> GetAllRestaurants();
        void SortRestaurants(List<Restaurant> restList);
        void AddRestaurant(Restaurant rest);
        void UpdateRestaurant(Restaurant rest);
        void DeleteRestaurant(Restaurant rest);
    }

    public interface IRevServ
    {
        List<Review> GetAllRestReviews(Restaurant rest);
        Review GetReviewByRestAndID(Restaurant rest, int ID);
        void AddReview(Restaurant rest, Review rev);
        void ModifyReview(Restaurant rest, Review rev);
        void DeleteReview(Restaurant rest, Review rev);
    }
}
