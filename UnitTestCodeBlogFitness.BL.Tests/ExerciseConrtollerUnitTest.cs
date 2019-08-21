using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL;
using System;
using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System.Linq;

namespace UnitTestUserController
{
    [TestClass]
    public class ExerciseControllerUnitTest
    {
        [TestMethod]
        public void AddExercisesTest()
        {
            {
                //Arrange
                var userName = Guid.NewGuid().ToString();
                var activityName = Guid.NewGuid().ToString();
                var rnd = new Random();
                var userController = new UserController(userName);
                var exerciseConroller = new ExerciseController(userController.CurrentUser);
                var activity = new Activity(activityName, rnd.Next(10, 50));

                // Act
                exerciseConroller.Add(activity, DateTime.Now, DateTime.Now.AddHours(1));

                // Assert
                Assert.AreEqual(activityName, exerciseConroller.Activities.First(a => a.Name == activityName).Name);
            }
        }
    }
}
