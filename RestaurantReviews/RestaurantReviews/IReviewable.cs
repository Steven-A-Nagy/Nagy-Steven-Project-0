using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public interface IReviewable
    {
        List<ReviewClass> ReviewList { get; }
        void AddReview(ReviewClass NewReview);
        void RemoveReview(string ID);
        ReviewClass GetReview(string ReviewName);
        void PrintReview(string ReviewName);
        void PrintAllReviews();

    }
}
