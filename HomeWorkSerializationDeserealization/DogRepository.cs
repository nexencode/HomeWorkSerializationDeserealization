using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSerializationDeserealization
{
    public static class DogRepository
    {
        const string dogFilePath = @"C:\Users\nexen\source\repos\HomeWorkSerializationDeserealization\dogs.json";

        /// <summary>
        /// Add new dogs to List and Serialize file.
        /// </summary>
        public static void AddAndSerializeDogs()
        {
            var allDogs = new List<Dog>()
            {
                new Dog("Dante", "Yellow", 12, "Labrador Retriver"),
                new Dog("Lara", "White", 10, "Gold Retriver")
            };

            AddNewDog(allDogs);

            File.WriteAllText(dogFilePath, JsonConvert.SerializeObject(allDogs));
        }

        /// <summary>
        /// User Add new dog from console input.
        /// </summary>
        public static void AddNewDog(List<Dog> listOfDogs)
        {
            Console.WriteLine("Press 'Y' to add new dog or press any key to exit from application: ");

            if (Console.ReadLine().ToLower() == "y")
            {
                #region User Input
                Console.WriteLine("Enter dog name: ");
                var dogName = Console.ReadLine();

                Console.WriteLine("Enter dog color: ");
                var dogColor = Console.ReadLine();

                Console.WriteLine("Enter dog age: ");
                var dogAge = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter dog Breed: ");
                var dogBreed = Console.ReadLine();
                #endregion

                Dog newDog = new Dog(dogName, dogColor, dogAge, dogBreed);

                listOfDogs.Add(newDog);

                AddNewDog(listOfDogs);
            }
            else
            {
                Console.WriteLine("Serialization...");
            }

        }

        /// <summary>
        /// Deserialize dogs from file and print to console.
        /// </summary>
        public static void DeserializeAndPrintAllDogs()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Deserialization...");

            List<Dog> dogsFromFile = JsonConvert.DeserializeObject<List<Dog>>(File.ReadAllText(dogFilePath));

            foreach (Dog dog in dogsFromFile)
            {
                dog.PrintDog();
            }
        }
    }
}
