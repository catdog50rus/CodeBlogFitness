using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBlogFitness.BL.Controller
{
    public class DatabaseDataSaver : IDataSaver
    {
        public T Load<T>(string fileName) 
        {
            using(var db = new FitnessContext())
            {
                return db.Users.ToList();                
            }
        }

        public void Save(string fileName, object item)
        {
            using (var db = new FitnessContext())
            {
                var type = item.GetType();
                if(type == typeof(User))
                {
                    db.Users.Add(item as User);
                }
                else if(type == typeof(Gender))
                {
                    db.Genders.Add(item as Gender);
                }
                else if (type == typeof(Activity))
                {
                    db.Activities.Add(item as Activity);
                }
                else if (type == typeof(Eating))
                {
                    db.Eating.Add(item as Eating);
                }
                else if (type == typeof(Exercise))
                {
                    db.Exercises.Add(item as Exercise);
                }
                else if (type == typeof(Food))
                {
                    db.Food.Add(item as Food);
                }

                db.SaveChanges();
            }

        }
    }
}
