using System;

class Program
{
    static void Main(string[] args)
    {
        IVehicle[] vehicles = new IVehicle[]
        {
            new Car("Ford", "Mustang", 2020, true),
            new Bus("Mercedes", "Sprinter", 2018, 20)
        };

        bool running = true;
        while (running)
        {
            Console.WriteLine("\nWybierz pojazd do zarządzania:");
            Console.WriteLine("1. Ford Mustang (Kabriolet)");
            Console.WriteLine("2. Mercedes Sprinter (Autobus)");
            Console.WriteLine("0. Wyjdź");

            Console.Write("Twój wybór: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ManageCar(vehicles[0] as Car);
                    break;
                case "2":
                    ManageBus(vehicles[1] as Bus);
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    static void ManageCar(Car car)
    {
        if (car == null)
        {
            Console.WriteLine("Nieprawidłowy pojazd.");
            return;
        }

        bool managingCar = true;
        while (managingCar)
        {
            Console.WriteLine("\nWybierz opcję dla Ford Mustang:");
            Console.WriteLine("1. Uruchom pojazd");
            Console.WriteLine("2. Otwórz dach");
            Console.WriteLine("3. Zatrzymaj pojazd");
            Console.WriteLine("0. Powrót");

            Console.Write("Twój wybór: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    car.Start();
                    break;
                case "2":
                    car.OpenRoof();
                    break;
                case "3":
                    car.Stop();
                    break;
                case "0":
                    managingCar = false;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    static void ManageBus(Bus bus)
    {
        if (bus == null)
        {
            Console.WriteLine("Nieprawidłowy pojazd.");
            return;
        }

        bool managingBus = true;
        while (managingBus)
        {
            Console.WriteLine("\nWybierz opcję dla Mercedes Sprinter:");
            Console.WriteLine("1. Uruchom pojazd");
            Console.WriteLine("2. Załaduj pasażerów");
            Console.WriteLine("3. Zatrzymaj pojazd");
            Console.WriteLine("0. Powrót");

            Console.Write("Twój wybór: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bus.Start();
                    break;
                case "2":
                    Console.Write("Podaj liczbę pasażerów do załadunku: ");
                    if (int.TryParse(Console.ReadLine(), out int passengers))
                    {
                        bus.LoadPassengers(passengers);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa liczba pasażerów.");
                    }
                    break;
                case "3":
                    bus.Stop();
                    break;
                case "0":
                    managingBus = false;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
