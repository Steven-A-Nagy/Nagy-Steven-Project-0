using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RestaurantReviewsModels;
using Repository;

namespace BusinessLogic.Tests
{
    [TestClass()]
    public class RestServicesTests
    {
        private readonly Mock<IRestaurantRepository> MockRepo;

        public RestServicesTests()
        {
            MockRepo = new Mock<IRestaurantRepository>();
            MockRepo.Setup(x => x.AddRestaurant(It.IsAny<Restaurant>()));
        }

        [TestMethod()]
        public void AddRestTest()
        {
            var service = new RestServices(MockRepo.Object);
            Restaurant testaurant = new Restaurant(); testaurant.ID = 0; testaurant.restName = "fakeRestName"; testaurant.city = "fakeCity"; testaurant.latitude = "fake"; testaurant.longitude = "fake"; testaurant.locality = "land o fakes"; testaurant.ID = 0; testaurant.restAddress = "fakeAddress"; testaurant.cuisines = "fakeCuisine"; testaurant.zipcode = "12345";
            service.AddRest(testaurant);
            MockRepo.Verify(m => m.AddRestaurant(It.IsAny<Restaurant>()), Times.Once);
        }

        [TestMethod()]
        public void AllRestsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteRestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRestaurantByIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortRestaurantsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getAverageRatingTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TopThreeRestsTest()
        {
            var service = new RestServices(MockRepo.Object);
            service.TopThreeRests();

            MockRepo.Verify(m => m.GetAllRestaurants(), Times.Once);
        }

        [TestMethod()]
        public void UpdateRestTest()
        {
            Assert.Fail();
        }
    }
}