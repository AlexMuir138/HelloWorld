using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = 6.5;
            int numberTwo = 4;
            int numberThree = 120;
            int numberFour = 230;
            Console.WriteLine(Math.Pow(numberOne, numberTwo));
            Console.WriteLine(Math.Ceiling(numberOne));
            Console.WriteLine(Math.Max(numberOne, numberTwo));
            Console.WriteLine(Math.Pow(numberThree, numberOne));
            Console.WriteLine(Math.Max(numberTwo, numberFour));
            

            string drink = "wine";
            string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

            int storyLength = madTeaParty.Length;
            string toFind = "March Hare";

            string findLowerCase = toFind.ToLower(); 
            int findMarchHare = madTeaParty.IndexOf(toFind);

            Console.WriteLine(madTeaParty.Substring(findMarchHare));
            Console.WriteLine($"This scene is {storyLength} characters long.\n");
            Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");



            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} there was a kid. {middle} and fell out. {end}";


            // Print the story to the console
            Console.WriteLine(story);

            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;
            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");
            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

            string name = "Farhad Hesam Abbasi";

            // Get first letter
            int firstPosition = name.IndexOf("F");
            char firstLetter = name[firstPosition];
            // Get last name
            int charPosition = name.IndexOf("Abbasi");
            string lastName = name.Substring(charPosition);

            //Logic
            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;
            double tripDuration = distance / rate;

            bool answer = (tripDuration <= timeToDinner);
            Console.WriteLine(answer);

            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;
            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine(tripDecision);

            //IF & ELSE
            int people = 12;
            string weather = "bad";
            if(people <= 10 && weather == "nice"){
                Console.WriteLine("SaladMart");
            }else{
                Console.WriteLine("Soup N Sandwich");
            }

            int guests = 0;
            if(guests >= 4){
                Console.WriteLine("Catan");
            }else if(guests >= 1){
                Console.WriteLine("Innovation");
            }else{
                Console.WriteLine("Solitaire");
            }


            Console.WriteLine("Drama, Comedy, Adventure, Horror, or Science Fiction?");
            string genre = Console.ReadLine();
            switch(genre){
                case "Drama":
                Console.WriteLine("Citizen Kane");
                break;
                case "Comedy":
                Console.WriteLine("Duck Soup");
                break;
                case "Adventure":
                Console.WriteLine("King Kong");
                break;
                case "Horror":
                Console.WriteLine("Psycho");
                break;
                case "Science Fiction":
                Console.WriteLine("2001: A Space Odyssey");
                break;
                default:
                Console.WriteLine("Do whatever you want.");
                break;

                //Ternary
                int pepperLength = 4;
                string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
                Console.WriteLine(message);
      }

                //Methods Section

                string msg = "Yabba dabba doo!";
                Math.Min(2,4);
                Console.WriteLine(msg);
                msg.Substring(0,1);
                string designer = "Anders Hejlsberg";
                int indexOfSpace = designer.IndexOf(" ");
                string secondName = designer.Substring(indexOfSpace, 9);
                Console.WriteLine(secondName);

                //Arguments
                static void Main(string[] args)
                {
                VisitPlanets(4);
                VisitPlanets(54);
                VisitPlanets(69);
                }
                
                static void VisitPlanets(int numberOfPlanets)
                {
                Console.WriteLine($"There are {numberOfPlanets} new planets...");
                }


                static void Main(string[] args)
                {
                VisitPlanets();
                VisitPlanets(numberOfPlanets: 2, name: ".");
                }
                
                static void VisitPlanets(
                string adjective = "brave",
                string name = "Alex", 
                int numberOfPlanets = 0,
                double gForce = 4.2)
                {
                Console.WriteLine($"Welcome back, {adjective} {name}.");
                Console.WriteLine($"You visited {numberOfPlanets} new planets...");
                Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
                }

                static void Main(string[] args)
                {
                NamePets(dog: "Max", cat: "Daisy");
                NamePets(dog: "Max", cat: "Daisy", lizard: "Smaug");
                NamePets();
                }
                static void NamePets(string dog, string cat ){
                Console.WriteLine($"Your pet {dog} and {cat} will be joining our voyage across space!");
                }
                static void NamePets(string dog, string cat, string lizard ){
                Console.WriteLine($"Your pet {dog}, {lizard}, and {cat} will be joining our voyage across space!");
                }
                static void NamePets(){
                Console.WriteLine($"Aw, you have no spacefaring friends :(");
                }


        }
    }
}
