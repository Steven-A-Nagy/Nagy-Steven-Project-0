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
    public class ReviewClassTests
    {
        //https://blogs.msdn.microsoft.com/ploeh/2006/10/21/console-unit-testing/
        //[TestInitialize]
        //public void InitializeTest()
        //{
        //    StreamWriter standardOut =
        //        new StreamWriter(Console.OpenStandardOutput());
        //    standardOut.AutoFlush = true;
        //    Console.SetOut(standardOut);
        //}

        [TestMethod()]
        public void PrintReviewBodyTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintReviewBody();
                string expected =
                    string.Format("Excellent food.{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void PrintNameTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintName();
                string expected =
                    string.Format("Reviewer: Ken{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void PrintRatingTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintRating();
                string expected =
                    string.Format("Rating: 5{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void PrintFullReviewTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintFullReview();
                string expected =
                    string.Format("Reviewer: Ken{0}" + "Rating: 5{0}" + "Excellent food.{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void AddReviewTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            ReviewClass test2 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);
            Assert.AreEqual(test1.ReviewList.ContainsValue(test2), true);

        }

        [TestMethod()]
        public void RemoveReviewTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            ReviewClass test2 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);
            test1.RemoveReview(0);
            Assert.AreEqual(test1.ReviewList.ContainsValue(test2), false);

        }

        [TestMethod()]
        public void GetReviewTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            ReviewClass test2 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);
            Assert.AreEqual(test1.GetReview(0), test2);

        }

        [TestMethod()]
        public void PrintReviewTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            ReviewClass test2 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);
            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintReview(0);
                string expected =
                    string.Format("Reviewer: Ken{0}"+"Rating: 1{0}"+"Nvm, actually garbage.{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod()]
        public void PrintAllReviewsTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            ReviewClass test2 = new ReviewClass(3, "Jenna", "Eh. It was alright.");
            ReviewClass test3 = new ReviewClass(1, "Ken", "Nvm, actually garbage.");
            test1.AddReview(test2);
            test1.AddReview(test3);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                test1.PrintAllReviews();
                string expected =
                    string.Format("Reviewer: Jenna{0}"+"Rating: 3{0}"+ "Eh. It was alright.{0}" + "Reviewer: Ken{0}" + "Rating: 1{0}" + "Nvm, actually garbage.{0}", Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }

        }

        [TestMethod()]
        public void ReviewClassTest()
        {
            ReviewClass test1 = new ReviewClass(5, "Ken", "Excellent food.");
            Assert.AreEqual(test1.Rating, 5);
            Assert.AreEqual(test1.ReviewerName, "Ken");
            Assert.AreEqual(test1.ReviewBody, "Excellent food.");
        }
    }
}