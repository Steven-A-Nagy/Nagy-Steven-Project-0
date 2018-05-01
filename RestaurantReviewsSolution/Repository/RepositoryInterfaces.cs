using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsModels;

namespace Repository
{
    public interface IRestaurantRepository
    {
        Restaurant GetById(int id);
        IEnumerable<Restaurant> GetAllRestaurants();
        void AddRestaurant(Restaurant rest);
        void ModifyRestaurant(Restaurant rest);
        void DeleteRestaurant(Restaurant rest);
        void SaveRestaurants();
    }

    public interface IReviewRepository
    {
        Review GetById(int id, Restaurant rest);
        IEnumerable<Review> GetAllReviews();
        void AddReview(Review rest);
        void ModifyReview(Review rest);
        void DeleteReview(Review rest);
        void SaveReviews();
    }
}
