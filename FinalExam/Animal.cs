using System;
namespace FinalExam
{
    public enum AnimalType
    {
        Cat,
        Dog,
        Rabbit,
        NoPreference
    }

    public class Animal
    {
        public AnimalType AnimalType { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        public Animal()
        {
        }

        public override string ToString()
        {
            return $"{Name} ({AnimalType})";
        }
    }
}
