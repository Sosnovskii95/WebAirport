using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebAirport.Models.CodeFirst;

namespace WebAirport.Data
{
    public class AirportContext : DbContext
    {
        public AirportContext(DbContextOptions<AirportContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<JobAirplane> JobAirplanes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TypeAirplane> TypeAirplanes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int countSize = 1000;
            modelBuilder.Entity<Position>().HasData(InitDb.GetPositions(countSize));
            modelBuilder.Entity<Staff>().HasData(InitDb.GetStaffs(countSize));

            modelBuilder.Entity<TypeAirplane>().HasData(InitDb.GetTypeAirplanes(countSize));
            modelBuilder.Entity<Airplane>().HasData(InitDb.GetAirplanes(countSize));

            modelBuilder.Entity<JobAirplane>().HasData(InitDb.GetJobAirplanes(countSize));

            modelBuilder.Entity<Flight>().HasData(InitDb.GetFlights(countSize));
            modelBuilder.Entity<Ticket>().HasData(InitDb.GetTickets(countSize));
        }
    }
}

class InitDb
{
    public static Position[] GetPositions(int countSize)
    {
        string[] JobTitle = { "Пилот Грузовой", "Пилот Гражданский", "Пилот Смешанный", "Пилот Стажер" };
        string[] Responsibilities = {"Пилотирование самолетов", "Пилотирование грузовых самолетов",
                                            "Пилот самолетов", "Пилот стажер"};
        string[] Requirements = { "Внимательность", "Ответственность", "Аккуратность", "Доброта" };

        Random random = new Random();
        Position[] positions = new Position[countSize];

        for (int i = 0; i < countSize; i++)
        {
            positions[i] = new Position
            {
                Id = i + 1,
                JobTitle = JobTitle[random.Next(0, 4)],
                Salary = random.Next(1, 100) * random.Next(1, 100),
                Responsibilities = Responsibilities[random.Next(0, 4)],
                Requirements = Requirements[random.Next(0, 4)]
            };
        }

        return positions;
    }

    public static Staff[] GetStaffs(int countSize)
    {
        string[] FIOStaff = { "Воробьев Алексей Викторович", "Лемешенко Алексей Александрович", "Корнеев Дмитрий Юрьевич", "Щиров Игорь Леонидович" };
        string Gender = "Мужской";
        string[] Address = { "Гомель, ул. Сухого, д. ", "Гомель, ул. Советская, д. ", "Гомель, ул. Пенязькова, д. ", "Гомель, ул. Ирининская, д. " };
        string[] Telephone = { "375445553344", "375299791175", "375336336741", "375259866240" };
        string[] Passport = { "есть", "нет", "иностранный", "двойное гражданство" };

        Random random = new Random();
        Staff[] staffs = new Staff[countSize];

        for (int i = 0; i < countSize; i++)
        {
            staffs[i] = new Staff
            {
                Id = i + 1,
                FIOStaff = FIOStaff[random.Next(0, 3)],
                Gender = Gender,
                Address = Address[random.Next(0, 3)] + random.Next(1, 100).ToString(),
                Telephone = Telephone[random.Next(0, 3)],
                Passport = Passport[random.Next(0, 3)],
                PositionId = random.Next(1, countSize)
            };
        }

        return staffs;
    }

    public static TypeAirplane[] GetTypeAirplanes(int countSize)
    {
        string[] NameType = { "Грузовой", "Пассажирский", "Грузовой+Пассажирский", "Смешанный" };
        string[] Appointment = { "Перевоз грузов", "Перевоз пассажиров", "Перевоз по назначению", "Может все" };
        string[] Limitation = { "Только грузы", "Только люди", "Грузы+люди", "Грузы, люди, животные, техника" };

        Random random = new Random();
        TypeAirplane[] typeAirplanes = new TypeAirplane[countSize];

        for (int i = 0; i < countSize; i++)
        {
            typeAirplanes[i] = new TypeAirplane
            {
                Id = i + 1,
                NameType = NameType[random.Next(0, 3)],
                Appointment = Appointment[random.Next(0, 3)],
                Limitation = Limitation[random.Next(0, 3)]
            };
        }

        return typeAirplanes;
    }

    public static Airplane[] GetAirplanes(int countSize)
    {
        string[] Model = { "Ан-112", "Аэробус", "Боинг 747", "B-17" };
        int PassengerCapacity = 10;
        double CarryingCapacity = 1000;
        string[] Specifications = { "Двух моторный", "Водный", "Российская сборка", "Воздушная крепость" };
        DateTime ReleaseDate = DateTime.Now.Date;
        int FLyingHours = 100;
        DateTime LastRepairDate = DateTime.Now.Date;

        Random random = new Random();
        Airplane[] airplanes = new Airplane[countSize];

        for (int i = 0; i < countSize; i++)
        {
            airplanes[i] = new Airplane
            {
                Id = i + 1,
                Model = Model[random.Next(0, 3)],
                PessengerCapacity = PassengerCapacity + random.Next(0, 100),
                CarryingCapacity = CarryingCapacity + random.Next(0, 100),
                Specifications = Specifications[random.Next(0, 3)],
                ReleaseDate = ReleaseDate,
                FlyingHours = FLyingHours + random.Next(0, 2000),
                LastRepairDate = LastRepairDate,
                TypeAirplaneId = random.Next(1, countSize)
            };
        }

        return airplanes;
    }

    public static JobAirplane[] GetJobAirplanes(int countSize)
    {
        Random random = new Random();
        JobAirplane[] jobAirplanes = new JobAirplane[countSize];

        for (int i = 0; i < countSize; i++)
        {
            jobAirplanes[i] = new JobAirplane
            {
                Id = i + 1,
                StaffId = random.Next(1, countSize),
                AirplaneId = random.Next(1, countSize)
            };
        }

        return jobAirplanes;
    }

    public static Flight[] GetFlights(int countSize)
    {
        string[] DeparturePoint = { "Минск", "Москва", "Владивосток", "Киев" };
        string[] Destination = { "Москва", "Питер", "Сахалинск", "Брест" };

        Random random = new Random();
        Flight[] flights = new Flight[countSize];

        for (int i = 0; i < countSize; i++)
        {
            flights[i] = new Flight
            {
                Id = i + 1,
                DateTimeFlight = new DateTime(2020, random.Next(3, 5), random.Next(1, 31), random.Next(0, 24), random.Next(0, 60), 0),
                DeparturePoint = DeparturePoint[random.Next(0, 3)],
                Destination = Destination[random.Next(0, 3)],
                TimeInFlight = new TimeSpan(random.Next(0, 24), random.Next(0, 60), 0),
                JobAirplaneId = random.Next(1, countSize)
            };
        };

        return flights;
    }

    public static Ticket[] GetTickets(int countSize)
    {
        string[] FIOPassenger = { "Бобров Игорь Валерьевич", "Велецкий Станислав Михайлович", "Миньков Валентин Виктровович", "Иванаускас Ксения Андреевна" };
        string[] Passport = { "есть", "нет", "иностранный", "двойное гражданство" };
        string[] PositionPassenger = { "Охранник", "Менеджер", "Сварщик", "Программист" };

        Random random = new Random();
        Ticket[] tickets = new Ticket[countSize];

        for (int i = 0; i < countSize; i++)
        {
            tickets[i] = new Ticket
            {
                Id = i + 1,
                FIOPassenger = FIOPassenger[random.Next(0, 3)],
                Passport = Passport[random.Next(0, 3)],
                PositionPassenger = PositionPassenger[random.Next(0, 3)],
                Seat = random.Next(1, 100),
                Price = random.Next(0, 100) * random.Next(0, 100),
                FlightId = random.Next(1, countSize)
            };
        }

        return tickets;
    }
}