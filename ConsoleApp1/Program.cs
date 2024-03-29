﻿using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (AppContext appContext = new AppContext())
            {
                User user = new User { FirstName = "Nikita", LastName = "Glazkov", Age = 30 };
                appContext.Users.Add(user);
                appContext.SaveChanges();
            }

            using (AppContext appContext = new AppContext())
            {
                var user = appContext.Users.ToList();
                
                foreach(User us in user)
                {
                    Console.WriteLine($"{us.LastName} {us.FirstName} {us.Age}");
                }
            }
        }
    }
}
