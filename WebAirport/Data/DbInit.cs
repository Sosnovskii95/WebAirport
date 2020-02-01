using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAirport.Models;

namespace WebAirport.Data
{
    public static class DbInit
    {
        public static void Initialize(AirportContext db)
        {
            int max = 100;
            Random random = new Random(1);
            for (int i = 0; i < max; i++)
            {
                int rand = random.Next(0, 4);
                db.Positions.Add(getPosition(rand));
            }
            db.SaveChanges();

        }

        private static Position getPosition(int rand)
        {
            string[] JobTitle = { "Пилот", "Инженер", "Cтеарт", "Охранник" };
            double Salary = 500.0;
            string[] Responsibilities = {"Пилотирование самолетов", "Выполнение своих обязанностей",
                                            "Обслуживание пассажиров", "Охранять вверенное имуществсо"};
            string[] Requirements = { "Внимательность", "Ответственность", "Аккуратность", "Охрана" };


            Position position = new Position
            {
                JobTitle = JobTitle[rand],
                Salary = Salary * rand,
                Responsibilities = Responsibilities[rand],
                Requirements = Requirements[rand]
            };


            return position;
        }
    }
}