using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.Task2
{
    interface IMotorcycleRepository<T>
    {
        IEnumerable<T> GetMotorcycles();
        T GetMotorcycleById(int motorcycleId);
        void CreateMotorcycle(T motorcycle);
        void DeleteMotorcycle(int motorcycleId);
        void UpdateMotorcycle(T motorcycle);
    }
}
