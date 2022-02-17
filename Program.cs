using System;
using System.Collections.Generic;
using System.Linq;


namespace CA02172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            var firstPerson = new Person("Arthur",new List<Pet>())
            {
                Pets = new List<Pet>()
                {
                    new Pet ("Rambo",2),
                    new Pet("Destroyer3000",4),
                    new Pet("Annabelle",7)
                }
            };
            var secondPerson = new Person("Myke", new List<Pet>())
            {
                Pets = new List<Pet>()
                {
                    new Pet("DojaCat",5),
                    new Pet("Toxin",3),
                    
                }
            };
            var thirdPerson = new Person("David", new List<Pet>())
            {
                Pets = new List<Pet>()
                {
                    new Pet("Venom",11),
                    new Pet("Doctor Strange",13),

                }
            };

            persons.Add(firstPerson);    
            persons.Add(secondPerson);
            persons.Add(thirdPerson);
            var petsList = persons.SelectMany(person => person.Pets).ToList();
            var petsListWithA = petsList.Where(pet => pet.Name.StartsWith('A')).ToList();
            var petsWithAge = petsListWithA.Where(pet => pet.Age > 5).ToList();
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public List<Pet> Pets { get; set; }
        public Person(string name, List<Pet> pets)
        {
            Name = name;
            Pets = pets;
        }
    }
    public class Pet
    {
        public string Name;
        public int Age;

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
