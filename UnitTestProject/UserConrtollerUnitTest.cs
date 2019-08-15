using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL;
using System;
using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;

namespace UnitTestProject
{
    [TestClass]
    public class UserControllerUnitTest
    {
        [TestMethod]
        public void SetNewUserDataTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var gender = "man";
            var birthDate = DateTime.Now.AddYears(-28);
            var weight = 95;
            var height = 185;

            //Act
            var controller = new UserController(userName);
            controller.SetNewUserData(gender, birthDate, weight, height);
            var controller2 = new UserController(userName);


            //Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
            Assert.AreEqual(birthDate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
        }

        [TestMethod]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();

            //Act
            var controller = new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }

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
