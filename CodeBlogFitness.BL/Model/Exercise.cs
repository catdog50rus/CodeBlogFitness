using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Exercise
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Activity Activity { get; }
        public User User { get; }

        public Exercise(DateTime start, DateTime finish, Activity activity, User user)
        {
            // TODO Проверка
            Start = start;
            Finish = finish;
            Activity = activity;
            User = user;
        }
    }
}
