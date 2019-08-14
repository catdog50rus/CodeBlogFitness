using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Food
    {
        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name { get;  }
       
        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории на 100 грамм продукта
        /// </summary>
        public double Calories { get; }

        /// <summary>
        /// Калории в одном грамме продукта
        /// </summary>
        private double CaloriesOneGramm { get { return Calories / 100.0; } }

        /// <summary>
        /// Белки в одном грамме продукта
        /// </summary>
        private double ProteinsOneGramm { get { return Proteins / 100.0; } }

        /// <summary>
        /// Жиры в одном грамме продукта
        /// </summary>
        private double FatsOneGramm { get { return Fats / 100.0; } }

        /// <summary>
        /// Углеводы в одном грамме продукта
        /// </summary>
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }

        public Food(string name) : this(name, 0, 0, 0, 0)
        {
        }

        public Food(string name, double proteins, double fats, double carbohydrates, double calories)
        {
            // TODO: проверка

            Name = name;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
            Calories = calories / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
