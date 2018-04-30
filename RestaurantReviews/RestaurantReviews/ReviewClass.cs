using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews
{
    public class Review //: IReviewable
    {
        public int Rating { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewBody { get; set; }
        //public Dictionary<int,Review> ReviewList { get => reviewList; }

        //private Dictionary<int, Review> reviewList = new Dictionary<int, Review>();

        public Review()
        {
            
        }

        public Review(int rat,string revName, string revBody)
        {
            Rating = rat; ReviewerName = revName; ReviewBody = revBody;
        }

        public void PrintReviewBody()
        {
            Console.WriteLine(ReviewBody);
        }

        public void PrintName()
        {
            Console.WriteLine("Reviewer: "+ReviewerName);
        }

        public void PrintRating()
        {
            Console.WriteLine("Rating: " + Rating);
        }
        
        public void PrintFullReview()
        {
            PrintName();
            PrintRating();
            PrintReviewBody();
        }

        //public void AddReview(Review NewReview)
        //{
        //    ReviewList.Add(ReviewList.Count(),NewReview);
        //}

        //public void RemoveReview(int ID)
        //{
        //    ReviewList.Remove(ID);
        //}

        //public Review GetReview(int ID)
        //{
        //    return ReviewList[ID];
        //}

        //public void PrintReview(int ID)
        //{
        //    ReviewList[ID].PrintFullReview();
        //}

        //public void PrintAllReviews()
        //{
        //    foreach(int element in ReviewList.Keys)
        //    {
        //        PrintReview(element);
        //    }
        //}
    }
}
