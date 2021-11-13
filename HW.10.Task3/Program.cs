using System;
using System.Collections.Generic;
using System.Linq;

namespace HW._10.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int experience = 0;
            List<string> developersList = new List<string> ();
            TypeDevelopers typeDevelopers = new TypeDevelopers();
            /*typeDevelopers.DeveloperType = "Junior";
            typeDevelopers.Responsebilities();
            typeDevelopers.GetResponsebilities();*/
            Developers developers = new Developers("Sam Solution", "Vadzim Papko", 1);
            developersList.Add(developers.ShowDevelover("Architect"));

            Developers developers1 = new Developers("Sam Solution", "Koshuba Vladzimir", 7);
            developersList.Add(developers1.ShowDevelover("Junior"));

            for (int i = 0; i < developersList.Count; i++)
            {
                string[] devStrings = developersList[i].Split(" ");
                if (Convert.ToInt32(devStrings[7]) > experience) 
                {
                    experience = Convert.ToInt32(devStrings[7]);
                    var buf = developersList[i];
                    developersList[i] = developersList[i + 1];
                    developersList[i + 1] = buf;
                }
            }
            foreach (var item in developersList)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
