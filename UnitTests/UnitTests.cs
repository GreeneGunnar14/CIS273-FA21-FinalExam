using FinalExam;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ShelterSize()
        {
            Animal cat1 = new Animal();
            cat1.Name = "Jeff";
            cat1.AnimalType = AnimalType.Cat;
            cat1.Weight = 11;

            AnimalShelter shelter = new AnimalShelter();
            Assert.AreEqual(0, shelter.TotalAnimals);
            shelter.Add(cat1);
            Assert.AreEqual(1, shelter.TotalAnimals);

        }

        [TestMethod]
        public void ShelterSizeMany()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.AreEqual(0, shelter.TotalAnimals);

            for (int i = 1; i < 51; i++)
            {
                shelter.Add(new Animal());
                Assert.AreEqual(i, shelter.TotalAnimals);
            }
        }

        [TestMethod]
        public void Shelter1()
        {
            AnimalShelter shelter = new AnimalShelter();

            Animal cat1 = new Animal();
            cat1.Name = "Jeff";
            cat1.AnimalType = AnimalType.Cat;
            cat1.Weight = 11;

            Animal dog1 = new Animal();
            dog1.Name = "Strudel";
            dog1.AnimalType = AnimalType.Dog;
            dog1.Weight = 70;

            Animal rabbit1 = new Animal();
            rabbit1.Name = "Bagel";
            rabbit1.AnimalType = AnimalType.Rabbit;
            rabbit1.Weight = 4;

            Animal cat2 = new Animal();
            cat2.Name = "Brad";
            cat2.AnimalType = AnimalType.Cat;
            cat2.Weight = 12;

            Animal dog2 = new Animal();
            dog2.Name = "Biscuit";
            dog2.AnimalType = AnimalType.Dog;
            dog2.Weight = 71;

            Animal rabbit2 = new Animal();
            rabbit2.Name = "Pancake";
            rabbit2.AnimalType = AnimalType.Rabbit;
            rabbit2.Weight = 5;

            Animal cat3 = new Animal();
            cat3.Name = "Dean";
            cat3.AnimalType = AnimalType.Cat;
            cat3.Weight = 13;

            Animal dog3 = new Animal();
            dog3.Name = "Quiche";
            dog3.AnimalType = AnimalType.Dog;
            dog3.Weight = 72;

            Animal rabbit3 = new Animal();
            rabbit3.Name = "Waffle";
            rabbit3.AnimalType = AnimalType.Rabbit;
            rabbit3.Weight = 6;

            shelter.Add(cat1);
            shelter.Add(cat2);
            shelter.Add(cat3);
            shelter.Add(dog1);
            shelter.Add(dog2);
            shelter.Add(dog3);
            shelter.Add(rabbit1);
            shelter.Add(rabbit2);
            shelter.Add(rabbit3);

            Assert.AreEqual(cat1, shelter.Adopt(AnimalType.Cat));
            Assert.AreEqual(cat2, shelter.Adopt(AnimalType.Cat));
            Assert.AreEqual(cat3, shelter.Adopt(AnimalType.Cat));
            Assert.AreEqual(dog1, shelter.Adopt(AnimalType.Dog));
            Assert.AreEqual(dog2, shelter.Adopt(AnimalType.Dog));
            Assert.AreEqual(dog3, shelter.Adopt(AnimalType.Dog));
            Assert.AreEqual(rabbit1, shelter.Adopt(AnimalType.Rabbit));
            Assert.AreEqual(rabbit2, shelter.Adopt(AnimalType.Rabbit));
            Assert.AreEqual(rabbit3, shelter.Adopt(AnimalType.Rabbit));
        }

        [TestMethod]
        public void Shelter2()
        {
            AnimalShelter shelter = new AnimalShelter();

            Animal cat1 = new Animal();
            cat1.Name = "Jeff";
            cat1.AnimalType = AnimalType.Cat;
            cat1.Weight = 11;

            Animal dog1 = new Animal();
            dog1.Name = "Strudel";
            dog1.AnimalType = AnimalType.Dog;
            dog1.Weight = 70;

            Animal rabbit1 = new Animal();
            rabbit1.Name = "Bagel";
            rabbit1.AnimalType = AnimalType.Rabbit;
            rabbit1.Weight = 4;

            Animal cat2 = new Animal();
            cat2.Name = "Brad";
            cat2.AnimalType = AnimalType.Cat;
            cat2.Weight = 12;

            Animal dog2 = new Animal();
            dog2.Name = "Biscuit";
            dog2.AnimalType = AnimalType.Dog;
            dog2.Weight = 71;

            Animal rabbit2 = new Animal();
            rabbit2.Name = "Pancake";
            rabbit2.AnimalType = AnimalType.Rabbit;
            rabbit2.Weight = 5;

            Animal cat3 = new Animal();
            cat3.Name = "Dean";
            cat3.AnimalType = AnimalType.Cat;
            cat3.Weight = 13;

            Animal dog3 = new Animal();
            dog3.Name = "Quiche";
            dog3.AnimalType = AnimalType.Dog;
            dog3.Weight = 72;

            Animal rabbit3 = new Animal();
            rabbit3.Name = "Waffle";
            rabbit3.AnimalType = AnimalType.Rabbit;
            rabbit3.Weight = 6;

            shelter.Add(cat1);
            shelter.Add(cat2);
            shelter.Add(cat3);
            shelter.Add(dog1);
            shelter.Add(dog2);
            shelter.Add(dog3);
            shelter.Add(rabbit1);
            shelter.Add(rabbit2);
            shelter.Add(rabbit3);

            Assert.AreEqual(cat1, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(cat2, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(cat3, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(dog1, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(dog2, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(dog3, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(rabbit1, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(rabbit2, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(rabbit3, shelter.Adopt(AnimalType.NoPreference));
        }

        [TestMethod]
        public void Shelter3()
        {
            AnimalShelter shelter = new AnimalShelter();

            Animal cat1 = new Animal();
            cat1.Name = "Jeff";
            cat1.AnimalType = AnimalType.Cat;
            cat1.Weight = 11;

            Animal dog1 = new Animal();
            dog1.Name = "Strudel";
            dog1.AnimalType = AnimalType.Dog;
            dog1.Weight = 70;

            Animal rabbit1 = new Animal();
            rabbit1.Name = "Bagel";
            rabbit1.AnimalType = AnimalType.Rabbit;
            rabbit1.Weight = 4;

            Animal cat2 = new Animal();
            cat2.Name = "Brad";
            cat2.AnimalType = AnimalType.Cat;
            cat2.Weight = 12;

            Animal dog2 = new Animal();
            dog2.Name = "Biscuit";
            dog2.AnimalType = AnimalType.Dog;
            dog2.Weight = 71;

            Animal rabbit2 = new Animal();
            rabbit2.Name = "Pancake";
            rabbit2.AnimalType = AnimalType.Rabbit;
            rabbit2.Weight = 5;

            Animal cat3 = new Animal();
            cat3.Name = "Dean";
            cat3.AnimalType = AnimalType.Cat;
            cat3.Weight = 13;

            Animal dog3 = new Animal();
            dog3.Name = "Quiche";
            dog3.AnimalType = AnimalType.Dog;
            dog3.Weight = 72;

            Animal rabbit3 = new Animal();
            rabbit3.Name = "Waffle";
            rabbit3.AnimalType = AnimalType.Rabbit;
            rabbit3.Weight = 6;

            shelter.Add(dog1);
            shelter.Add(cat1);
            shelter.Add(rabbit1);
            shelter.Add(dog2);
            shelter.Add(cat2);
            shelter.Add(rabbit2);
            shelter.Add(dog3);
            shelter.Add(cat3);
            shelter.Add(rabbit3);

            Assert.AreEqual(dog1, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(cat1, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(rabbit1, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(dog2, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(cat2, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(rabbit2, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(dog3, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(cat3, shelter.Adopt(AnimalType.NoPreference));
            Assert.AreEqual(rabbit3, shelter.Adopt(AnimalType.NoPreference));
        }

        [TestMethod]
        public void Shelter4WeightName()
        {
            AnimalShelter shelter = new AnimalShelter();

            Animal cat1 = new Animal();
            cat1.Name = "Jeff";
            cat1.AnimalType = AnimalType.Cat;
            cat1.Weight = 11;

            Animal dog1 = new Animal();
            dog1.Name = "Strudel";
            dog1.AnimalType = AnimalType.Dog;
            dog1.Weight = 70;

            Animal rabbit1 = new Animal();
            rabbit1.Name = "Bagel";
            rabbit1.AnimalType = AnimalType.Rabbit;
            rabbit1.Weight = 4;

            Animal cat2 = new Animal();
            cat2.Name = "Brad";
            cat2.AnimalType = AnimalType.Cat;
            cat2.Weight = 12;

            Animal dog2 = new Animal();
            dog2.Name = "Biscuit";
            dog2.AnimalType = AnimalType.Dog;
            dog2.Weight = 71;

            Animal rabbit2 = new Animal();
            rabbit2.Name = "Pancake";
            rabbit2.AnimalType = AnimalType.Rabbit;
            rabbit2.Weight = 5;

            shelter.Add(dog1);
            shelter.Add(cat1);
            shelter.Add(rabbit1);
            shelter.Add(dog2);
            shelter.Add(cat2);
            shelter.Add(rabbit2);

            Animal dog1again = shelter.Adopt(AnimalType.NoPreference);
            Animal cat1again = shelter.Adopt(AnimalType.NoPreference);
            Animal rabbit1again = shelter.Adopt(AnimalType.NoPreference);
            Animal dog2again = shelter.Adopt(AnimalType.NoPreference);
            Animal cat2again = shelter.Adopt(AnimalType.NoPreference);
            Animal rabbit2again = shelter.Adopt(AnimalType.NoPreference);

            Assert.AreEqual(dog1.Name, dog1again.Name);
            Assert.AreEqual(dog1.Weight, dog1again.Weight);
            Assert.AreEqual(cat1.Name, cat1again.Name);
            Assert.AreEqual(cat1.Weight, cat1again.Weight);
            Assert.AreEqual(rabbit1.Name, rabbit1again.Name);
            Assert.AreEqual(rabbit1.Weight, rabbit1again.Weight);
            Assert.AreEqual(dog2.Name, dog2again.Name);
            Assert.AreEqual(dog2.Weight, dog2again.Weight);
            Assert.AreEqual(cat2.Name, cat2again.Name);
            Assert.AreEqual(cat2.Weight, cat2again.Weight);
        }
    }
}
