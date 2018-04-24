using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public class ReviewClass : IReviewable
    {
        public string ReviewID { get; set; }
        public int Rating { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewBody { get; set; }
        public List<ReviewClass> ReviewList { get => reviewList; }

        private List<ReviewClass> reviewList = new List<ReviewClass>();

        public ReviewClass()
        {

        }

        public ReviewClass(string rID, int rat,string revName, string revBody)
        {
            ReviewID = rID; Rating = rat; ReviewerName = revName; ReviewBody = revBody;
        }

        public void PrintReviewBody()
        {
            throw new NotImplementedException();
        }

        public void PrintName()
        {
            throw new NotImplementedException();
        }

        public void PrintRating()
        {
            throw new NotImplementedException();
        }
        
        public void PrintFullReview()
        {
            throw new NotImplementedException();
        }

        public void AddReview(ReviewClass NewReview)
        {
            throw new NotImplementedException();
        }

        public void RemoveReview(string ID)
        {
            throw new NotImplementedException();
        }

        public ReviewClass GetReview(string ReviewName)
        {
            throw new NotImplementedException();
        }

        public void PrintReview(string ReviewName)
        {
            throw new NotImplementedException();
        }

        public void PrintAllReviews()
        {
            throw new NotImplementedException();
        }
    }
}
