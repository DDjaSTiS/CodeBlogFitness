using CodeBlogFitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"></param>
        public UserController (string userName,
                               string genderName,
                               DateTime birthDate,
                               double weight,
                               double height)
        {
            //todo: Проверка данных
            var gender = new Gender(genderName);
            User= new User(userName, gender, birthDate, weight, height);
        }

        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения. </returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("users.dat", FileMode.Open))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                //todo: что делать, если пользователя не прочитали
            }
        }
        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using(var fs=new FileStream("users.dat",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        
    }
}
