using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole.Models
{
    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        // We need an operator overload for +

        public static Dog operator +(Dog first, Dog second)
        {
            //Calculate the new name
            string newName = first.Name.Substring(0, first.Name.Length / 2) + second.Name.Substring(second.Name.Length / 2);
            
            //Default age to 0

            //Calculate the new breed
            string newBreed = first.Breed.Substring(0, first.Breed.Length / 2) + second.Breed.Substring(second.Breed.Length / 2);

            return new Dog() { Name = newName, Age = 0, Breed = newBreed};
        }

        public static bool operator ==(Dog first, Dog second)
        {
            return (first.Name == second.Name) && (first.Age == second.Age) && (first.Breed == second.Breed);
        }

        public static bool operator !=(Dog first, Dog second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            return $"{Name} ({Breed}) - {Age} years old";
        }
    }
}
