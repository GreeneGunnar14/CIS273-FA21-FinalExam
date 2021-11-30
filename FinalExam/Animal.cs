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

        public Animal()
        {
        }


    }
}
