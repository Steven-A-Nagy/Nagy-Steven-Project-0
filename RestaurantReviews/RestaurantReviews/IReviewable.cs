using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public interface IReviewable
    {
        Dictionary<int,Review> ReviewList { get; }
        void AddReview(Review NewReview);
        void RemoveReview(int ID);
        Review GetReview(int ID);
        void PrintReview(int ID);
        void PrintAllReviews();

    }
}
