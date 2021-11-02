using HW._07.AssembleOne;

namespace HW._07.Assemply.Two
{
    class ClassForMotorcycle: Motorcycle
    {
        void MainForClass()
        {
            ClassForMotorcycle classForMotorcycle = new ClassForMotorcycle();
            //classForMotorcycle.modelInternal = "Yamaha YZF-R3";//доступен только в том классе и классах наследниках
            classForMotorcycle.modelYearProtected = 2015;//protected
            classForMotorcycle.ModelSize();//Protected Internal
            //classForMotorcycle.enginePowerConstProtected;//недотупен из-за модификатора const который только для данного класса
        }
    }
}
