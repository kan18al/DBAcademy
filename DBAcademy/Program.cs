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
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Sam", Age = 26 };
                // добавляем их в бд
                //db.Users.Add(user1);
                //db.Users.Add(user2);
                db.Users.AddRange(new List<User> { user1, user2 });

                db.SaveChanges();

                // создаем два объекта Authorization
                Authorization authorization1 = new Authorization { Id = user1.Id, Login = "tom13", Password = "qwerty" };
                Authorization authorization2 = new Authorization { Id = user2.Id, Login = "sam18", Password = "ytrewq" };
                // добавляем их в бд
                //db.Authorizations.Add(authorization1);
                //db.Authorizations.Add(authorization2);
                db.Authorizations.AddRange(new List<Authorization> { authorization1, authorization2 });

                db.SaveChanges();

                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users;
                var authorizations = db.Authorizations;
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                }
                foreach (Authorization a in authorizations)
                {
                    Console.WriteLine("{0}.{1} - {2}", a.Id, a.Login, a.Password);
                }
            }
            Console.Read();

        }
    }
}
