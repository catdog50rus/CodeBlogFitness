using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL;
using System;
using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class EatingControllerUnitTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var foodName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var eatingConroller = new EatingController(userController.CurrentUser);
            var food = new Food(foodName, rnd.Next(50, 500), rnd.Next(50, 500), rnd.Next(50, 500), rnd.Next(50, 500));

            // Act
            eatingConroller.Add(food, 100.0);

            // Assert
            Assert.AreEqual(userName, eatingConroller.Eating.User.Name);
        }
    }
}
