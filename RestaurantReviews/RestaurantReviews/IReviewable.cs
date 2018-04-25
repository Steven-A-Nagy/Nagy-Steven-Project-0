using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public interface IReviewable
    {
        Dictionary<int,ReviewClass> ReviewList { get; }
        void AddReview(ReviewClass NewReview);
        void RemoveReview(int ID);
        ReviewClass GetReview(int ID);
        void PrintReview(int ID);
        void PrintAllReviews();

    }
}
