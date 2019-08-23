using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя
    /// </summary>
    public class UserController : BaseController
    {
        /// <summary>
        /// Пользователь приложения
        /// </summary>
        public List<User> Users { get; }

        public User CurrentUser { get; }

        public bool ISNewUser { get; } = false;

        /// <summary>
        /// Создание нового контроллера
        /// </summary>
        /// <param name="user"></param>
        public UserController(string userName)
        {
            if(string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));
            }

            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);

            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
                Users.Add(CurrentUser);
                ISNewUser = true;
                Save();
            }
        }
        /// <summary>
        /// Получить сохраненный список пользователей
        /// </summary>
        /// <returns></returns>
        private List<User> GetUsersData()
        {
            return Load<User>() ?? new List<User>();
            
        }

        public void SetNewUserData(string genderName, DateTime birthDate, double weight = 1, double height = 1)
        {
            // TODO Проверка

            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            Save();
        }

        /// <summary>
        /// Сохранить данный пользователя
        /// </summary>
        /// <param name="user"></param>
        public void Save()
        {
            Save(Users);   
        }
    }
}
