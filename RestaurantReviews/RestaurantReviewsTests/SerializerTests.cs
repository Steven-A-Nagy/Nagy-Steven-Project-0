using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RestaurantReviews.Tests
{
    [TestClass()]
    public class SerializerTests
    {
        [TestMethod()]
        public void SerializeRestaurantsTest()
        {
            Serializer test = new Serializer();
            List<RestaurantClass> testList = new List<RestaurantClass>();
            RestaurantClass testaurant = new RestaurantClass("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            ReviewClass testReview1 = new ReviewClass(1, "FakeMan", "fake");
            ReviewClass testReview2 = new ReviewClass(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            Assert.AreEqual(@"[{""Name"":""fake"",""Address"":""fake"",""Locality"":""fake"",""City"":""fake"",""Latitude"":""fake"",""Longitude"":""fake"",""Zipcode"":""fake"",""Cuisines"":""fake"",""ReviewList"":{""0"":{""Rating"":1,""ReviewerName"":""FakeMan"",""ReviewBody"":""fake"",""ReviewList"":{}},""1"":{""Rating"":1,""ReviewerName"":""FakeMan2"",""ReviewBody"":""fake"",""ReviewList"":{}}}}]", returnString);
        }

        [TestMethod()]
        public void DeserializeRestaurantsTest()
        {
            Serializer test = new Serializer();
            List<RestaurantClass> testList = new List<RestaurantClass>();
            RestaurantClass testaurant = new RestaurantClass("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            ReviewClass testReview1 = new ReviewClass(1, "FakeMan", "fake");
            ReviewClass testReview2 = new ReviewClass(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            List<RestaurantClass> testList2 = test.DeserializeRestaurants(returnString);
            Console.WriteLine("testOutput: "+testList[0].Name+" "+ testList2[0].Name);
            Console.WriteLine("testOutput: " + testList[0].ReviewList[0].ReviewerName + " " + testList2[0].ReviewList[0].ReviewerName);
            Assert.AreEqual(testList[0].Name, testList2[0].Name);
            Assert.AreEqual(testList[0].ReviewList[0].ReviewerName, testList2[0].ReviewList[0].ReviewerName);
        }

        [TestMethod()]
        public void SerializedToFileTest()
        {
            Serializer test = new Serializer();
            List<RestaurantClass> testList = new List<RestaurantClass>();
            RestaurantClass testaurant = new RestaurantClass("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            ReviewClass testReview1 = new ReviewClass(1, "FakeMan", "fake");
            ReviewClass testReview2 = new ReviewClass(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            Console.WriteLine("serialized string: " + returnString);
            Console.WriteLine("file path: " + ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            test.SerializedToFile(returnString);
            

            string assertText = System.IO.File.ReadAllText(ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            Assert.AreEqual(@"[{""Name"":""fake"",""Address"":""fake"",""Locality"":""fake"",""City"":""fake"",""Latitude"":""fake"",""Longitude"":""fake"",""Zipcode"":""fake"",""Cuisines"":""fake"",""ReviewList"":{""0"":{""Rating"":1,""ReviewerName"":""FakeMan"",""ReviewBody"":""fake"",""ReviewList"":{}},""1"":{""Rating"":1,""ReviewerName"":""FakeMan2"",""ReviewBody"":""fake"",""ReviewList"":{}}}}]",assertText);
        }

        [TestMethod()]
        public void SerializedFromFileTest()
        {
            Serializer test = new Serializer();
            List<RestaurantClass> testList = new List<RestaurantClass>();
            RestaurantClass testaurant = new RestaurantClass("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            ReviewClass testReview1 = new ReviewClass(1, "FakeMan", "fake");
            ReviewClass testReview2 = new ReviewClass(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            Console.WriteLine("serialized string: " + returnString);
            Console.WriteLine("file path: " + ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            test.SerializedToFile(returnString);

            List<RestaurantClass> testList2 = test.SerializedFromFile();
            Console.WriteLine("testOutput: " + testList[0].Name + " " + testList2[0].Name);
            Console.WriteLine("testOutput: " + testList[0].ReviewList[0].ReviewerName + " " + testList2[0].ReviewList[0].ReviewerName);
            Assert.AreEqual(testList[0].Name, testList2[0].Name);
            Assert.AreEqual(testList[0].ReviewList[0].ReviewerName, testList2[0].ReviewList[0].ReviewerName);
        }
    }
}