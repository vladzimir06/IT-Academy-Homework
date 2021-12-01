using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.Task2
{
    class MotorcycleRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> _motosicle = new List<Motorcycle>();
        public MotorcycleRepository(List<Motorcycle> motorcycles)
        {
            _motosicle = motorcycles;
            Log.Information("Grud started");  
        }
        protected List<Motorcycle> moto 
        {
            get => _motosicle;
            set => _motosicle = value;
        }
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            _motosicle.Add(motorcycle);
            Log.Debug("Add Motorcycle" + motorcycle.Name);
        }
        public void DeleteMotorcycle(int idMotorcycle)
        {
            var motorcycle = GetMotorcycleById(idMotorcycle);
            _motosicle.Remove(motorcycle);
            Log.Debug($"Motorcyle {motorcycle.Name}, {motorcycle.Id} is deleted");
        }
        public Motorcycle GetMotorcycleById(int motrcycleId)
        {
            var motorcycle = _motosicle.Find(x => x.Id == motrcycleId);
            return motorcycle;
            Log.Debug($"motorcycle with Id: {motrcycleId}");
        }
        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            int index = _motosicle.FindIndex(f => f.Id == motorcycle.Id);
            _motosicle[index].Name = motorcycle.Name;
            _motosicle[index].Year = motorcycle.Year;
            _motosicle[index].Model = motorcycle.Model;
            _motosicle[index].Odometre = motorcycle.Odometre;
            Log.Debug("Moto aded" + motorcycle.Name);
        }
        public IEnumerable<Motorcycle> GetMotorcycles ()
        {
            Log.Debug("Get Motorcycle");
            return _motosicle;
        }
    }
}
