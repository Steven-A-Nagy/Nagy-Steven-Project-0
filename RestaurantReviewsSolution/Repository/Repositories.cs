using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsModels;

namespace Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RepositoryContext _repoContext;

        public void AddRestaurant(Restaurant rest)
        {
            _repoContext.Restaurants.Add(rest);
            _repoContext.SaveChanges();
        }

        public void DeleteRestaurant(Restaurant rest)
        {
            _repoContext.Restaurants.Remove(rest);
            _repoContext.SaveChanges();
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _repoContext.Restaurants;
        }

        public Restaurant GetById(int id)
        {
            return _repoContext.Restaurants.First(x => x.ID == id);
        }

        public void ModifyRestaurant(Restaurant rest)
        {
            Restaurant checkID = _repoContext.Restaurants.Find(rest.ID);
            _repoContext.Entry(checkID).CurrentValues.SetValues(checkID);
            _repoContext.SaveChanges();
        }

        public void SaveRestaurants()
        {
            _repoContext.SaveChanges();
        }
    }

    public class ReviewRepository : IReviewRepository
    {
        private readonly RepositoryContext _repoContext;

        public void AddReview(Review rest)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(Review rest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetAllReviews()
        {
            return _repoContext.Reviews;
        }

        public Review GetById(int id,Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public void ModifyReview(Review rest)
        {
            throw new NotImplementedException();
        }

        public void SaveReviews()
        {
            _repoContext.SaveChanges();
        }
    }
}
