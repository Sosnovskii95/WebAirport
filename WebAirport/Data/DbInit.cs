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
                for (int j = 0; j < 10; j++) 
                {
                    int rand = random.Next(0, 4);

                    var position = getPosition(rand);
                    db.Positions.Add(position);

                    var typeAirplane = getTypeAirplane(rand);
                    db.TypeAirplanes.Add(typeAirplane);

                    var staff = getStaff(rand, position);
                    db.Staffs.Add(staff);

                    var airplane = getAirplane(rand, typeAirplane);
                    db.Airplanes.Add(airplane);

                    var jobAirplane = getJobAirplane(airplane, staff);
                    db.JobAirplanes.Add(jobAirplane);

                    var flight = getFlights(rand, jobAirplane);
                    db.Flights.Add(flight);

                    for (int k = 0; k < 10; k++) 
                    {
                        db.Tickets.Add(getTicket(rand, flight));
                    }
                }
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

        private static Staff getStaff(int rand, Position position)
        {
            string[] FirsNameStaff = { "Воробьев Алексей", "Лемешенко Алексей", "Корнеев Дмитрий", "Щиров Игорь" };
            string[] LastNameStaff = { "Викторович", "Александрович", "Юрьевич", "Леонидович" };
            string Gender = "male";
            string[] Address = { "Гомель, ул. Сухого, д. ", "Гомель, ул. Советская, д. ", "Гомель, ул. Пенязькова, д. ", "Гомель, ул. Ирининская, д. " };
            string[] Telephone = { "375445553344", "375299791175", "375336336741", "375259866240" };
            string[] Passport = { "есть", "нет", "иностранный", "двойное гражданство" };

            Staff staff = new Staff
            {
                FirstNameStaff = FirsNameStaff[rand],
                LastNameStaff = LastNameStaff[rand],
                Gender = Gender,
                Address = Address[rand] + rand + 1,
                Telephone = Telephone[rand],
                Passport = Passport[rand],
                Position = position
            };

            return staff;
        }

        private static TypeAirplane getTypeAirplane(int rand)
        {
            string[] NameType = { "Грузовой", "Пассажирский", "Грузовой+Пассажирский", "Смешанный" };
            string[] Appointment = { "Перевоз грузов", "Перевоз пассажиров", "Перевоз по назначению", "Может все" };
            string[] Limitation = { "Только грузы", "Только люди", "Грузы+люди", "Грузы, люди, животные, техника" };

            TypeAirplane typeAirplane = new TypeAirplane
            {
                NameType = NameType[rand],
                Appointment = Appointment[rand],
                Limitation = Limitation[rand]
            };

            return typeAirplane;
        }

        private static Airplane getAirplane(int rand, TypeAirplane typeAirplane)
        {
            string[] Model = { "Ан-112", "Аэробус", "Боинг 747", "B-17" };
            int PassengerCapacity = 60 - (10 * rand);
            double CarryingCapacity = 1000 - (100 * rand) / (rand - 0.25);
            string[] Specifications = { "Двух моторный", "Водный", "Российская сборка", "Воздушная крепость" };
            DateTime ReleaseDate = DateTime.Now.Date;
            int FLyingHours = rand * rand * 50;
            DateTime LastRepairDate = DateTime.Now.Date;

            Airplane airplane = new Airplane
            {
                Model = Model[rand],
                PessengerCapacity = PassengerCapacity,
                CarryingCapacity = CarryingCapacity,
                Specifications = Specifications[rand],
                ReleaseDate = ReleaseDate,
                FlyingHours = FLyingHours,
                LastRepairDate = LastRepairDate,
                TypeAirplane = typeAirplane
            };

            return airplane;
        }

        private static JobAirplane getJobAirplane (Airplane airplane, Staff staff)
        {
            JobAirplane jobAirplane = new JobAirplane
            {
                Staff = staff,
                Airplane = airplane
            };

            return jobAirplane;
        }

        private static Flight getFlights(int rand, JobAirplane jobAirplane)
        {
            DateTime DateTimeInFlight = DateTime.Now;
            string[] DeparturePoint = { "Минск", "Москва", "Владивосток", "Киев" };
            string[] Destination = { "Москва", "Питер", "Сахалинск", "Брест" };
            TimeSpan TimeInFlight = DateTime.Now.TimeOfDay;

            Flight flight = new Flight
            {
                DateTimeFlight = DateTimeInFlight,
                DeparturePoint = DeparturePoint[rand],
                Destination = Destination[rand],
                TimeInFlight = TimeInFlight,
                JobAirplane = jobAirplane
            };

            return flight;
        }

        private static Ticket getTicket(int rand, Flight flight)
        {
            string[] FirstNamePassenger = { "Бобров Игорь", "Велецкий Станислав", "Миньков Валентин", "Иванаускас Ксения" };
            string[] LastNamePassenger = { "Валерьевич", "Михайлович", "Виктровович", "Андреевна" };
            string Passport = "есть";
            string[] PositionPassenger = { "Охранник", "Менеджер", "Сварщик", "Программист" };
            int Seat = (rand + 1) * 2;
            double Price = 50.5 * (rand + 1.5);

            Ticket ticket = new Ticket
            {
                FirstNamePassenger = FirstNamePassenger[rand],
                LastNamePassenger = LastNamePassenger[rand],
                Passport = Passport,
                PositionPassenger = PositionPassenger[rand],
                Seat = Seat,
                Price = Price,
                Flight = flight
            };

            return ticket;
        }
    }
}