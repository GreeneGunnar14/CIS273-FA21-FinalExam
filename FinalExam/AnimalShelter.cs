using System;
using System.Collections.Generic;
namespace FinalExam
{
    public class AnimalShelter
    {
        public AnimalShelter()
        {
        }

        LinkedList<Animal> shelterAnimals = new LinkedList<Animal>();

        public void Add(Animal animal)
        {
            shelterAnimals.AddLast(animal);
        }

        public Animal Adopt(AnimalType animalType)
        {
            LinkedListNode<Animal> currentAnimal = shelterAnimals.First;

            if (animalType == AnimalType.NoPreference)
            {
                shelterAnimals.Remove(currentAnimal);
                return currentAnimal.Value;
            }

            while (currentAnimal.Next != null)
            {
                if (currentAnimal.Value.AnimalType.Equals(animalType))
                {
                    shelterAnimals.Remove(currentAnimal);
                    return currentAnimal.Value;
                }

                currentAnimal = currentAnimal.Next;
            }

            if (currentAnimal.Value.AnimalType.Equals(animalType))
            {
                shelterAnimals.Remove(currentAnimal);
                return currentAnimal.Value;
            }

            return null;
        }

        public int TotalAnimals => shelterAnimals.Count;
    }
}
