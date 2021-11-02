using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.AssembleOne
{
    class SportBike : Motorcycle
    {
        void AccessLevel() 
        {
            SportBike sportBike = new SportBike();
            sportBike.GearboxEngine();
            sportBike.ModelSize();
            //sportBike.BrakesMotorcycle();при использовании модификатора private можем использовать данный метод только в данном классе
        }
    }
}
