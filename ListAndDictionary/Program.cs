namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            // TODO 2: Validate if the person already exists in the personList.
            // TODO 3: Add the person to the personList if they don't already exist.
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
            {
                Console.Write("Enter the person's name: ");
                string name = Console.ReadLine();
                if (!personList.Contains(name))
                {
                    personList.Add(name);
                    Console.WriteLine($"{name} added to the list.");
                    if (!personAgeDictionary.ContainsKey(name))
                    {
                        Console.Write($"Enter {name}'s age: ");
                        int age = int.Parse(Console.ReadLine());
                        personAgeDictionary.Add(name, age);
                        Console.WriteLine($"{name}'s age ({age}) added to the dictionary.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} already exists in the dictionary.");
                    }
                }
                else
                {
                    Console.WriteLine($"{name} already exists in the list.");
                }
            }

        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
            {
                Console.Write("Enter the name of the person to remove: ");
                string nameToRemove = Console.ReadLine();

                if (personList.Contains(nameToRemove))
                {
                    personList.Remove(nameToRemove);
                    Console.WriteLine($"{nameToRemove} removed from the list.");

                    if (personAgeDictionary.ContainsKey(nameToRemove))
                    {
                        personAgeDictionary.Remove(nameToRemove);
                        Console.WriteLine($"{nameToRemove}'s age removed from the dictionary.");
                    }
                    else
                    {
                        Console.WriteLine($"{nameToRemove} does not have an age in the dictionary.");
                    }
                }
                else
                {
                    Console.WriteLine($"{nameToRemove} does not exist in the list.");
                }
            }

        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            {
                Console.Write("Enter the name of the person to find: ");
                string nameToFind = Console.ReadLine();

                // TODO 14: Check if the person is in personList and provide appropriate feedback.
                if (personList.Contains(nameToFind))
                {
                    Console.WriteLine($"{nameToFind} found in the list.");
                }
                else
                {
                    Console.WriteLine($"{nameToFind} not found in the list.");
                }

                // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
                if (personAgeDictionary.ContainsKey(nameToFind))
                {
                    Console.WriteLine($"{nameToFind}'s age is {personAgeDictionary[nameToFind]}.");
                }
                else
                {
                    Console.WriteLine($"{nameToFind} does not have an age in the dictionary.");
                }
            }

        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
            {
                // TODO 16: Iterate over personList and display each person's name.
                Console.WriteLine("All persons in the list:");
                foreach (var person in personList)
                {
                    Console.WriteLine(person);
                }

                // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
                Console.WriteLine("\nAll persons in the dictionary:");
                foreach (var kvp in personAgeDictionary)
                {
                    Console.WriteLine($"{kvp.Key}: Age {kvp.Value}");
                }

                // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
                if (personList.Count == 0 && personAgeDictionary.Count == 0)
                {
                    Console.WriteLine("No persons found in the list and dictionary.");
                }
            }
        }
    }
}
    
