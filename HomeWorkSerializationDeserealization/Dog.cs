using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSerializationDeserealization
{
    [Serializable]
    public class Dog
    {
        #region Fields and Properties
        private static int id;
        public int ID { get; set; } = ++id;
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public string DogBreed { get; set; }
        #endregion

        #region Constructors
        public Dog() { }

        public Dog(string name, string color, int age, string dogBreed)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
            this.DogBreed = dogBreed;
        }
        #endregion

        #region Methods
        public void PrintDog()
        {
            Console.WriteLine($"Id: {ID}, Name: {Name}, Dog Breed: {DogBreed}, Color: {Color}, Age: {Age}.");
        }
        #endregion
    }
}
