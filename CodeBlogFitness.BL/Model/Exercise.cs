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

        public int ActivivtyId { get; set; }
        public virtual Activity Activity { get; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

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
