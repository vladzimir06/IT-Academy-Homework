using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.AssembleOne
{
    public class Motorcycle
    {
        private string modelPrivate = "Yamaha YZF-R3";//
        public string modelPublic = "Yamaha YZF-R3";//+
        internal string modelInternal = "Yamaha YZF-R3";//+

        const uint enginePower = 43;//+
        
        private protected uint enginePowerPrivateProtected = 43;
        public const int enginePowerProtectedInternal = 43;//+
        protected int modelYearProtected = 2015;//+

        protected internal void ModelSize() //+
        { 
        }

        protected void GearboxEngine()
        { 
        }

        private  void BrakesMototrcycle()
        {
            Console.WriteLine(enginePower);
        }
    }
}
