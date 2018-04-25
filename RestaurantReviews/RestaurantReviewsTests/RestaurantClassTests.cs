using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReviews.Tests
{
    [TestClass()]
    public class RestaurantClassTests
    {
        [TestMethod()]
        public void AddReviewTest()
        {
            RestaurantClass test1 = new RestaurantClass("Otto Enoteca & Pizzeria", "1 5th Avenue, New York, NY 10003", "Greenwich Village", "New York City", "40.732013", "-73.996155", "10003", "Cafe");
            ReviewClass testR1 = new ReviewClass(5, "Ken", "Excellent food.");
            test1.AddReview(testR1);
            Assert.AreEqual(test1.ReviewList.ContainsValue(testR1), true);
        }

        [TestMethod()]
        public void RemoveReviewTest()
        {
            RestaurantClass test1 = new RestaurantClass("Otto Enoteca & Pizzeria", "1 5th Avenue, New York, NY 10003", "Greenwich Village", "New York City", "40.732013", "-73.996155", "10003", "Cafe");
            ReviewClass testR1 = new ReviewClass(5, "Ken", "Excellent food.");
            test1.AddReview(testR1);
            test1.RemoveReview(0);
            Assert.AreEqual(test1.ReviewList.ContainsValue(testR1), false);
        }

        [TestMethod()]
        public void GetReviewTest()
        {
            RestaurantClass test1 = new RestaurantClass("Otto Enoteca & Pizzeria", "1 5th Avenue, New York, NY 10003", "Greenwich Village", "New York City", "40.732013", "-73.996155", "10003", "Cafe");
            ReviewClass testR1 = new ReviewClass(5, "Ken", "Excellent food.");
            test1.AddReview(testR1);
            Assert.AreEqual(test1.GetReview(0), testR1);
        }

        [TestMethod()]
        public void PrintReviewTest()
        {
            RestaurantClass test1 = new RestaurantClass("Otto Enoteca & Pizzeria", "1 5th Avenue, New York, NY 10003", "Greenwich Village", "New York City", "40.732013", "-73.996155", "10003", "Cafe");
            ReviewClass test2 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintReview(0);
                string expected =
                    string.Format("Reviewer: Ken{0}" + "Rating: 1{0}" + "Nvm, actually garbage.{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void PrintAllReviewsTest()
        {
            RestaurantClass test1 = new RestaurantClass("Otto Enoteca & Pizzeria", "1 5th Avenue, New York, NY 10003", "Greenwich Village", "New York City", "40.732013", "-73.996155", "10003", "Cafe");
            ReviewClass test2 = new ReviewClass(3, "Jenna", "Eh. It was alright.");
            ReviewClass test3 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);
            test1.AddReview(test3);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintAllReviews();
                string expected =
                    string.Format("Reviewer: Jenna{0}" + "Rating: 3{0}" + "Eh. It was alright.{0}" + "Reviewer: Ken{0}" + "Rating: 1{0}" + "Nvm, actually garbage.{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void RestaurantClassTest()
        {
            RestaurantClass test1 = new RestaurantClass("Otto Enoteca & Pizzeria", "1 5th Avenue, New York, NY 10003", "Greenwich Village", "New York City", "40.732013", "-73.996155", "10003", "Cafe");
            Assert.AreEqual(test1.Name, "Otto Enoteca & Pizzeria");
            Assert.AreEqual(test1.Address, "1 5th Avenue, New York, NY 10003");
            Assert.AreEqual(test1.City, "New York City");
            Assert.AreEqual(test1.Locality, "Greenwich Village");
            Assert.AreEqual(test1.Latitude, "40.732013");
            Assert.AreEqual(test1.Longitude, "-73.996155");
            Assert.AreEqual(test1.Zipcode, "10003");
            Assert.AreEqual(test1.Cuisines, "Cafe");
        }

    }
}