using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Tests
{
    [TestClass()]
    public class ReviewClassTests
    {
        [TestMethod()]
        public void PrintReviewBodyTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food."); 
            Assert.Fail();
        }

        [TestMethod()]
        public void PrintNameTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void PrintRatingTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void PrintFullReviewTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void AddReviewTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveReviewTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void GetReviewTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void PrintReviewTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void PrintAllReviewsTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.Fail();
        }

        [TestMethod()]
        public void ReviewClassTest()
        {
            ReviewClass test1 = new ReviewClass("testRest", 5, "Ken", "Excellent food.");
            Assert.AreEqual(test1.ReviewID, "testRest");
            Assert.AreEqual(test1.Rating, 5);
            Assert.AreEqual(test1.ReviewerName, "Ken");
            Assert.AreEqual(test1.ReviewBody, "Excellent food.");
        }
    }
}