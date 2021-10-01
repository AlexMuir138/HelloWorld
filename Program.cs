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






            /*
            MAD MAD LIBS
            This program is meant to mimic the classic Mad Lib algorithm. It will take user input of nouns, adjectives, verbs, etc. and print them into a story for the user.
            Author: Alex Muir
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Your application is now running...");

            // Give the Mad Lib a title:
            string title = "Mad Mad Libs";

            Console.WriteLine(title);
            // Define user input and variables:


            // The template for the story:

            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


            // Print the story:
        }
    }
}
