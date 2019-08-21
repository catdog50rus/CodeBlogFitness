using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CaloriesPerMinute { get; set; }
        public Activity(string name, double caloriesPerMinute)
        {
            // TODO Проверка
            Name = name;
            CaloriesPerMinute = caloriesPerMinute;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
