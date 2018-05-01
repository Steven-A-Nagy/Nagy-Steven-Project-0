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
        List<Restaurant> SearchAll(string searchMeth);
        void SortRestaurants(List<Restaurant> restList);
        void AddRest(Restaurant rest);
        void UpdateRest(Restaurant rest);
        void DeleteRest(Restaurant rest);
    }

    public interface IRevServ
    {
        List<Review> GetAllRestReviews(Restaurant rest);
        Review GetReviewByRestAndID(Restaurant rest, int ID);
        void AddRev(Restaurant rest, Review rev);
        void ModifyRev(Restaurant rest, Review rev);
        void DeleteRev(Restaurant rest, Review rev);
    }
}
