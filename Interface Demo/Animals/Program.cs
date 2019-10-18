using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalHospitalBasic anka;
            anka = new Dog() { PetName = "Karo" };
            Console.WriteLine(anka.PetName);

            anka = new Cat() { PetName = "Flisan" };
            Console.WriteLine(anka.PetName);
        }
    }

    public interface IAnimalHospitalBasic
    {
        string ElectronicId();
        string PetName { get; set; }
    }


    public class Horse
    {

    }
    public class Dog : IAnimalHospitalBasic
    {
        public string PetName { get; set; }

        public string ElectronicId()
        {
            return "IUYN87612KJH";
        }
    }
    public class Cat : IAnimalHospitalBasic
    {
        private string _name;
        public string PetName { get { return _name; } set { _name = value; } }

        public string ElectronicId()
        {
            return "HAJSH15";
        }
    }
    public class Pig
    {

    }
}
