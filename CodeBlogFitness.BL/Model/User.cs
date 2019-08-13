﻿using System;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class User
    {
        #region Свойства
        /// <summary>
        /// Пользователь
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Рост.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Вес.
        /// </summary>
        public double Height { get; set; }

        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        #endregion

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="gender">Пол. </param>
        /// <param name="birthDate">Дата рождения. </param>
        /// <param name="weigth">Рост. </param>
        /// <param name="heigth">Вес. </param>
        public User(string name, 
               Gender gender, 
               DateTime birthDate, 
               double weight, 
               double height)
        {
        #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или равно null", nameof(name));
            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthDate));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю", nameof(weight));
            }
            if(height <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше или равен нулю.", nameof(height));
            }
            #endregion
           
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или равно null", nameof(name));
            }
            Name = name;

        }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}