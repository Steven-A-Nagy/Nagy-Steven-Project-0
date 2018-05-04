using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RestaurantReviewsModels;
using System.Data.Entity;
using BusinessLogic;

namespace Repository.Tests
{
    [TestClass()]
    public class RestaurantRepositoryTests
    {
        private readonly Mock<RepositoryContext> TestRepo;
        private readonly Mock<DbSet<Restaurant>> TestSet;

        public RestaurantRepositoryTests()
        {
            TestRepo = new Mock<RepositoryContext>();

            TestRepo.Setup(m => m.Restaurants).Returns(TestSet.Object);
        }

        [TestMethod()]
        public void AddRestaurantTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteRestaurantTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllRestaurantsTest()
        {
            var service = new RestaurantRepository(TestRepo.Object);
            var restById = service.GetAllRestaurants();

            Assert.IsInstanceOfType(restById, typeof(IEnumerable<Restaurant>));
            //Assert.AreEqual(restById.ElementAt(0).restName, "fake");
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyRestaurantTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SaveRestaurantsTest()
        {
            Assert.Fail();
        }
    }
}