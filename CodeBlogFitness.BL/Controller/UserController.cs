using CodeBlogFitness.BL.Model;
using System;

namespace CodeBlogFitness.BL.Controller
{
    class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым или null", nameof(user));
        }
        public bool Save(User user)
        {
            return true;
        }
    }
}
