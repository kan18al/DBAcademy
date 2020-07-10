using System;
using System.Collections.Generic;

namespace DBAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                // создаем два объекта User
                User user1 = new User { Id = 0, Name = "Tom", Age = 33 };
                User user2 = new User { Id = 1, Name = "Sam", Age = 26 };

                // добавляем их в бд
                db.Users.AddRange(new List<User> { user1, user2 });

                // создаем два объекта Authorization
                Authorization authorization1 = new Authorization { Id = user1.Id, Login = "tom13", Password = "qwerty" };
                Authorization authorization2 = new Authorization { Id = user2.Id, Login = "sam18", Password = "ytrewq" };

                // добавляем их в бд
                db.Authorizations.AddRange(new List<Authorization> { authorization1, authorization2 });

                //сохраняем в бд изменения
                db.SaveChanges();


                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users;
                var authorizations = db.Authorizations;
                Console.WriteLine("Список объектов:");
                //ГДЕ ТО ПРОБЛЕМА, ЗАПУСКАЕТСЯ ПРАВИЛЬНО ТОЛЬКО ПЕРВЫЙ РАЗ!!!
                foreach (User u in users)
                {
                    Console.WriteLine("{0}login - {1} password - {2} name - {3} age - {4}", u.Id, u.Authorization.Login, u.Authorization.Password, u.Name, u.Age);
                }
            }
            Console.Read();

        }
    }
}
