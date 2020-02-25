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
            int countSize = 10000;

            var positions = getPosition(countSize / 10);
            db.Positions.AddRange(positions);

            var staffs = getStaff(countSize, positions);
            db.Staffs.AddRange(staffs);

            var typeAirplanes = getTypeAirplane(countSize);
            db.TypeAirplanes.AddRange(typeAirplanes);

            var airplanes = getAirplane(countSize, typeAirplanes);
            db.Airplanes.AddRange(airplanes);

            var jobAirplanes = getJobAirplane(countSize, airplanes, staffs);
            db.JobAirplanes.AddRange(jobAirplanes);

            var flights = getFlights(countSize / 10, jobAirplanes);
            db.Flights.AddRange(flights);

            var tickets = getTicket(countSize, flights);
            db.Tickets.AddRange(tickets);

            db.SaveChanges();
        }

        private static List<Position> getPosition(int countSize)
        {
            string[] JobTitle = { "Пилот", "Инженер", "Cтеарт", "Охранник" };
            double Salary = 500.0;
            string[] Responsibilities = {"Пилотирование самолетов", "Выполнение своих обязанностей",
                                            "Обслуживание пассажиров", "Охранять вверенное имуществсо"};
            string[] Requirements = { "Внимательность", "Ответственность", "Аккуратность", "Охрана" };

            List<Position> positionsList = new List<Position>(countSize);
            Random random = new Random();

            for (int i = 0; i < countSize; i++)
            {
                positionsList.Add(
                    new Position
                    {
                        JobTitle = JobTitle[random.Next(0, 3)],
                        Salary = Salary * random.Next(1, 10),
                        Responsibilities = Responsibilities[random.Next(0, 3)],
                        Requirements = Requirements[random.Next(0, 3)]
                    });
            }

            return positionsList;
        }

        private static List<Staff> getStaff(int countSize, List<Position> positions)
        {
            string[] FIOStaff = { "Воробьев Алексей Викторович", "Лемешенко Алексей Александрович", "Корнеев Дмитрий Юрьевич", "Щиров Игорь Леонидович" };
            string Gender = "Мужской";
            string[] Address = { "Гомель, ул. Сухого, д. ", "Гомель, ул. Советская, д. ", "Гомель, ул. Пенязькова, д. ", "Гомель, ул. Ирининская, д. " };
            string[] Telephone = { "375445553344", "375299791175", "375336336741", "375259866240" };
            string[] Passport = { "есть", "нет", "иностранный", "двойное гражданство" };

            Random random = new Random();
            List<Staff> staffsList = new List<Staff>(countSize);

            for (int i = 0; i < countSize; i++)
            {
                staffsList.Add(new Staff
                {
                    FIOStaff = FIOStaff[random.Next(0, 3)],
                    Gender = Gender,
                    Address = Address[random.Next(0, 3)] + random.Next(1, 100).ToString(),
                    Telephone = Telephone[random.Next(0, 3)],
                    Passport = Passport[random.Next(0, 3)],
                    Position = positions[random.Next(1, positions.Count())]
                });
            }

            return staffsList;
        }

        private static List<TypeAirplane> getTypeAirplane(int counSize)
        {
            string[] NameType = { "Грузовой", "Пассажирский", "Грузовой+Пассажирский", "Смешанный" };
            string[] Appointment = { "Перевоз грузов", "Перевоз пассажиров", "Перевоз по назначению", "Может все" };
            string[] Limitation = { "Только грузы", "Только люди", "Грузы+люди", "Грузы, люди, животные, техника" };

            Random random = new Random();
            List<TypeAirplane> typeAirplaneList = new List<TypeAirplane>(counSize);

            for (int i = 0; i < counSize; i++)
            {
                typeAirplaneList.Add(new TypeAirplane
                {
                    NameType = NameType[random.Next(0, 3)],
                    Appointment = Appointment[random.Next(0, 3)],
                    Limitation = Limitation[random.Next(0, 3)]
                });
            }

            return typeAirplaneList;
        }

        private static List<Airplane> getAirplane(int countSize, List<TypeAirplane> typeAirplanes)
        {
            string[] Model = { "Ан-112", "Аэробус", "Боинг 747", "B-17" };
            int PassengerCapacity = 10;
            double CarryingCapacity = 1000;
            string[] Specifications = { "Двух моторный", "Водный", "Российская сборка", "Воздушная крепость" };
            DateTime ReleaseDate = DateTime.Now.Date;
            int FLyingHours = 100;
            DateTime LastRepairDate = DateTime.Now.Date;

            Random random = new Random();
            List<Airplane> airplaneList = new List<Airplane>(countSize);

            for (int i = 0; i < countSize; i++)
            {
                airplaneList.Add(new Airplane
                {
                    Model = Model[random.Next(0, 3)],
                    PessengerCapacity = PassengerCapacity + random.Next(0, 100),
                    CarryingCapacity = CarryingCapacity + random.Next(0, 100),
                    Specifications = Specifications[random.Next(0, 3)],
                    ReleaseDate = ReleaseDate,
                    FlyingHours = FLyingHours + random.Next(0, 2000),
                    LastRepairDate = LastRepairDate,
                    TypeAirplane = typeAirplanes[random.Next(1, typeAirplanes.Count())]
                });
            }

            return airplaneList;
        }

        private static List<JobAirplane> getJobAirplane(int countSize, List<Airplane> airplanes, List<Staff> staffs)
        {
            Random random = new Random();
            List<JobAirplane> jobAirplaneList = new List<JobAirplane>(countSize);

            for (int i = 0; i < countSize; i++)
            {
                jobAirplaneList.Add(new JobAirplane
                {
                    Staff = staffs[random.Next(1, staffs.Count())],
                    Airplane = airplanes[random.Next(1, airplanes.Count())]
                });
            }

            return jobAirplaneList;
        }

        private static List<Flight> getFlights(int countSize, List<JobAirplane> jobAirplanes)
        {
            DateTime DateTimeInFlight = DateTime.Now;
            string[] DeparturePoint = { "Минск", "Москва", "Владивосток", "Киев" };
            string[] Destination = { "Москва", "Питер", "Сахалинск", "Брест" };
            TimeSpan TimeInFlight = DateTime.Now.TimeOfDay;

            Random random = new Random();
            List<Flight> flightList = new List<Flight>(countSize);

            for (int i = 0; i < countSize; i++)
            {
                flightList.Add(new Flight
                {
                    DateTimeFlight = DateTimeInFlight,
                    DeparturePoint = DeparturePoint[random.Next(0, 3)],
                    Destination = Destination[random.Next(0, 3)],
                    TimeInFlight = TimeInFlight,
                    JobAirplane = jobAirplanes[random.Next(1, jobAirplanes.Count())]
                });
            }

            return flightList;
        }

        private static List<Ticket> getTicket(int countSize, List<Flight> flights)
        {
            string[] FIOPassenger = { "Бобров Игорь Валерьевич", "Велецкий Станислав Михайлович", "Миньков Валентин Виктровович", "Иванаускас Ксения Андреевна" };
            string[] Passport = { "есть", "нет", "иностранный", "двойное гражданство" };
            string[] PositionPassenger = { "Охранник", "Менеджер", "Сварщик", "Программист" };
            double Price = 100;

            Random random = new Random();
            List<Ticket> ticketList = new List<Ticket>(countSize);

            for (int i = 0; i < countSize; i++)
            {
                ticketList.Add(new Ticket
                {
                    FIOPassenger = FIOPassenger[random.Next(0, 3)],
                    Passport = Passport[random.Next(0, 3)],
                    PositionPassenger = PositionPassenger[random.Next(0, 3)],
                    Seat = random.Next(1, 100),
                    Price = Price + random.Next(0, 1000) + random.NextDouble(),
                    Flight = flights[random.Next(1, flights.Count())]
                });
            }

            return ticketList;
        }
    }
}