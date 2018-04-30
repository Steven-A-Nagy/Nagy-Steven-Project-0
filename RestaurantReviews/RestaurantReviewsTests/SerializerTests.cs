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
            List<Restaurant> testList = new List<Restaurant>();
            Restaurant testaurant = new Restaurant("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            Review testReview1 = new Review(1, "FakeMan", "fake");
            Review testReview2 = new Review(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            Assert.AreEqual(@"[{""Name"":""fake"",""Address"":""fake"",""Locality"":""fake"",""City"":""fake"",""Latitude"":""fake"",""Longitude"":""fake"",""Zipcode"":""fake"",""Cuisines"":""fake"",""ReviewList"":{""0"":{""Rating"":1,""ReviewerName"":""FakeMan"",""ReviewBody"":""fake""},""1"":{""Rating"":1,""ReviewerName"":""FakeMan2"",""ReviewBody"":""fake""}}}]", returnString);
        }

        [TestMethod()]
        public void DeserializeRestaurantsTest()
        {
            Serializer test = new Serializer();
            List<Restaurant> testList = new List<Restaurant>();
            Restaurant testaurant = new Restaurant("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            Review testReview1 = new Review(1, "FakeMan", "fake");
            Review testReview2 = new Review(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            List<Restaurant> testList2 = test.DeserializeRestaurants(returnString);
            Console.WriteLine("testOutput: "+testList[0].Name+" "+ testList2[0].Name);
            Console.WriteLine("testOutput: " + testList[0].ReviewList[0].ReviewerName + " " + testList2[0].ReviewList[0].ReviewerName);
            Assert.AreEqual(testList[0].Name, testList2[0].Name);
            Assert.AreEqual(testList[0].ReviewList[0].ReviewerName, testList2[0].ReviewList[0].ReviewerName);
        }

        [TestMethod()]
        public void SerializedToFileTest()
        {
            Serializer test = new Serializer();
            List<Restaurant> testList = new List<Restaurant>();
            Restaurant testaurant = new Restaurant("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            Review testReview1 = new Review(1, "FakeMan", "fake");
            Review testReview2 = new Review(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            Console.WriteLine("serialized string: " + returnString);
            Console.WriteLine("file path: " + ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            test.SerializedToFile(returnString);
            

            string assertText = System.IO.File.ReadAllText(ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            Assert.AreEqual(@"[{""Name"":""fake"",""Address"":""fake"",""Locality"":""fake"",""City"":""fake"",""Latitude"":""fake"",""Longitude"":""fake"",""Zipcode"":""fake"",""Cuisines"":""fake"",""ReviewList"":{""0"":{""Rating"":1,""ReviewerName"":""FakeMan"",""ReviewBody"":""fake""},""1"":{""Rating"":1,""ReviewerName"":""FakeMan2"",""ReviewBody"":""fake""}}}]", returnString);
        }

        [TestMethod()]
        public void SerializedFromFileTest()
        {
            Serializer test = new Serializer();
            List<Restaurant> testList = new List<Restaurant>();
            Restaurant testaurant = new Restaurant("fake", "fake", "fake", "fake", "fake", "fake", "fake", "fake");
            Review testReview1 = new Review(1, "FakeMan", "fake");
            Review testReview2 = new Review(1, "FakeMan2", "fake");
            testaurant.AddReview(testReview1);
            testaurant.AddReview(testReview2);
            testList.Add(testaurant);
            string returnString = test.SerializeRestaurants(testList);
            Console.WriteLine("serialized string: " + returnString);
            Console.WriteLine("file path: " + ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            test.SerializedToFile(returnString);

            List<Restaurant> testList2 = test.SerializedFromFile();
            Console.WriteLine("testOutput: " + testList[0].Name + " " + testList2[0].Name);
            Console.WriteLine("testOutput: " + testList[0].ReviewList[0].ReviewerName + " " + testList2[0].ReviewList[0].ReviewerName);
            Assert.AreEqual(testList[0].Name, testList2[0].Name);
            Assert.AreEqual(testList[0].ReviewList[0].ReviewerName, testList2[0].ReviewList[0].ReviewerName);
        }
    }
}