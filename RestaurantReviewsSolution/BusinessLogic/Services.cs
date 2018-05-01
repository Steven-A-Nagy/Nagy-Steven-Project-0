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
        private readonly IRestaurantRepository restaurantRepo;
        public void AddRestaurant(Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> AllRests()
        {
            throw new NotImplementedException();
        }

        public void DeleteRestaurant(Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchAll()
        {
            throw new NotImplementedException();
        }

        public Restaurant SearchByName(string name)
        {
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

        public void UpdateRestaurant(Restaurant rest)
        {
            throw new NotImplementedException();
        }
    }

    public class RevServices : IRevServ
    {
        public void AddReview(Restaurant rest, Review rev)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(Restaurant rest, Review rev)
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

        public void ModifyReview(Restaurant rest, Review rev)
        {
            throw new NotImplementedException();
        }
    }
}
