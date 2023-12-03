
namespace DataStructuresAndAlgorithms_InCSharp.Classes
{
    internal class Person
    {
        public int Edad { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public Person(int edad, string name, string adress) 
        { 
            Edad = edad;
            Name = name;
            Adress = adress;
        }

        public override string ToString()
        {
            return Edad + ", " + Name + ", " + Adress;
        }
    }
}
