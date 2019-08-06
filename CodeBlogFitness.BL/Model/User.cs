using System;

namespace CodeBlogFitness.BL.Model
{
    class User
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
               double weigth, 
               double heigth)
        {

        #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или равно null", nameof(name));
            }
            if(Gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));
            }
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthDate));
            }
            if(weigth <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю", nameof(weigth));
            }
            if(heigth <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше или равен нулю.", nameof(heigth));
            }
            #endregion
           
            Name = name;

            Gender = gender;

            BirthDate = birthDate;

            Weight = weigth;

            Height = heigth;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}