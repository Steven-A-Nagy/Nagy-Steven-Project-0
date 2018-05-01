using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsModels;
using Repository;

namespace BusinessLogic
{
    public class RestServices : IRestServ
    {
        private readonly IRestaurantRepository _restaurantRepo;
        public RestServices(IRestaurantRepository restaurantRepo)
        {
            _restaurantRepo = restaurantRepo;
        }

        public void AddRest(Restaurant rest)
        {
            _restaurantRepo.AddRestaurant(rest);
        }

        public List<Restaurant> AllRests()
        {
            return _restaurantRepo.GetAllRestaurants().ToList();
        }

        public void DeleteRest(Restaurant rest)
        {
            _restaurantRepo.DeleteRestaurant(rest);
        }

        public List<Restaurant> SearchAll(string searchMeth)
        {
            //switch (searchMeth)
            //{
            //    case "name":

            //    case "city":

            //    case "address":
            //    default:
            //}
            throw new NotImplementedException();
        }

        public void SortRestaurants(List<Restaurant> restList)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> TopThreeRests()
        {
            throw new NotImplementedException();
        }

        public void UpdateRest(Restaurant rest)
        {
            throw new NotImplementedException();
        }
    }

    public class RevServices : IRevServ
    {
        public void AddRev(Restaurant rest, Review rev)
        {
            throw new NotImplementedException();
        }

        public void DeleteRev(Restaurant rest, Review rev)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAllRestReviews(Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public Review GetReviewByRestAndID(Restaurant rest, int ID)
        {
            throw new NotImplementedException();
        }

        public void ModifyRev(Restaurant rest, Review rev)
        {
            throw new NotImplementedException();
        }
    }
}
