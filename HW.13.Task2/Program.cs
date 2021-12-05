using Serilog;
using System;
using System.Collections.Generic;

namespace HW._13.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                         .MinimumLevel.Debug()
                         .WriteTo.File("Logger.txt", (Serilog.Events.LogEventLevel)RollingInterval.Hour)
                         .CreateLogger();
            int id = 0;
            try
            {
                List<Motorcycle> motorcycles = new List<Motorcycle>();
                motorcycles.Add(new Motorcycle { Id = 1, Name = "BMW", Model = "M 1000 RR", Year = 2018, Odometre = 7000 });
                motorcycles.Add(new Motorcycle { Id = 2, Name = "BMW", Model = "S 1000 RR", Year = 2017, Odometre = 8000 });
                motorcycles.Add(new Motorcycle { Id = 3, Name = "BMW", Model = "R 1250 Rs", Year = 2016, Odometre = 5000 });

                MotorcycleRepository motorcycleRepository = new MotorcycleRepository(motorcycles);
                var motorcycle = motorcycleRepository.GetMotorcycles();
                foreach (var motor in motorcycle)
                {
                    Console.WriteLine(motorcycle.ToString());
                }

                Console.WriteLine("Enter Id");
                id = int.Parse(Console.ReadLine());
                var findMoto = motorcycleRepository.GetMotorcycleById(id);
                Console.WriteLine(findMoto.ToString());

                var newMoto = new Motorcycle { Id = 4, Name = "Suzuki", Model = "M 2002 d", Year = 2002, Odometre = 3000 };
                id = int.Parse(Console.ReadLine());
                motorcycleRepository.CreateMotorcycle(newMoto);

                Console.WriteLine("Id for delete");
                id = int.Parse(Console.ReadLine());
                motorcycleRepository.DeleteMotorcycle(id);

                var updateMoto = motorcycleRepository.GetMotorcycleById(4);
                updateMoto.Odometre = 10000;
                updateMoto.Year = 2001;
                motorcycleRepository.UpdateMotorcycle(updateMoto);
                Console.WriteLine(updateMoto.ToString());

                motorcycle = motorcycleRepository.GetMotorcycles();
                foreach (var motor in motorcycle)
                {
                    Console.WriteLine(motorcycle.ToString());
                }
            }
            catch (Exception ex)
            {
                ex = new MotorcycleExeptions($"No Moto with Id: {id}"); 
                Log.Error(ex.StackTrace);
            }
            finally
            {
                Log.Information("end Program");
            }
        }
    }
}
