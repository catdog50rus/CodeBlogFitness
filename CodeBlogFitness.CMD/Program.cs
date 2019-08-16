using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            var userController = new UserController(name);
            var eatingController = new EatingController(userController.CurrentUser);

            if (userController.ISNewUser)
            {
                Console.WriteLine("Введите пол");
                var gender = Console.ReadLine();
                var birthDate = ParseDateTime();
                var weight = ParseDouble("вес");
                var height = ParseDouble("рост");

                userController.SetNewUserData(gender, birthDate, weight, height);
            }

            Console.WriteLine(userController.CurrentUser);

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("Е - ввести прием пищи");
            Console.WriteLine("P - Вывести съеденное");
            var key = Console.ReadKey();
            Console.WriteLine();
            if(key.Key == ConsoleKey.E)
            {
                var foods = EnterEating();
                eatingController.Add(foods.Food, foods.Weight);

                foreach (var item in eatingController.Eating.Foods)
                {
                    Console.WriteLine($"\t{item.Key} : {item.Value}грамм");
                }
            }
            if (key.Key == ConsoleKey.P)
            {
                foreach (var item in eatingController.Eating.Foods)
                {
                    Console.WriteLine($"\t{item.Key} : {item.Value}грамм");
                }
            }

        }

        private static (Food Food, double Weight) EnterEating()
        {
            Console.Write("Введите название продукта: ");
            var food = Console.ReadLine();

            var calories = ParseDouble("калорийность");
            var prots = ParseDouble("белки");
            var fats = ParseDouble("жиры");
            var carbs = ParseDouble("Углеводы");
            var weight = ParseDouble("вес порции");
            var product = new Food(food, prots, fats, carbs, calories);

            return (Food: product, Weight: weight);
        }

        private static DateTime ParseDateTime()
        {
            //DateTime birthDate;
            while (true)
            {
                Console.WriteLine("Введите Дату рождения (dd.mm.yyyy): ");
                if(DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {
                    return birthDate;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты рождения");
                }
            }
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.Write($"Введите {name}: ");
                if(double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                    
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}");
                }
            }
        }
    }
}
