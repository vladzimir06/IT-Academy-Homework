using System;

namespace HW._07.AssembleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.modelPublic = "Yamaha YZF-R3";
            //motorcycle.modelPrivate;//Private доступен только в классе'
            //Console.WriteLine(motorcycle.enginePower);//Const для работе в классе
            //motorcycle.modelYearProtected = 2222;//недоступен из-за модификатора Protected для классов в данной сборке
            //motorcycle.enginePowerPrivateProtected = 1;//Private Protected доступен в классе либо в производных в одной сборке

            //motorcycle.GearboxEngine();//Модификатор protected позволяет работать только в данном классе или в производном
            //motorcycle.BrakesMototrcycle();//Модификатор private позволяет работать только в данном классе 
            SportBike sportBike = new SportBike();
            //sportBike.GearboxEngine();//Модификатор protected позволяет работать только в данном классе или в производном
            //sportBike.BrakesMototrcycle();//Модификатор private позволяет работать только в данном классе 
            sportBike.modelPublic = "Yamaha YZF-R3";
            Console.WriteLine("Hello World!");
        }
    }
}
