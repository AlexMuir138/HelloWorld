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
           
            
        }
    }
}
