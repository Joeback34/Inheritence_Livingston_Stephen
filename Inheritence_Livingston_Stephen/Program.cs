using System;

namespace Inheritence_Livingston_Stephen
{
    class Program
    { /// <summary>
    /// Method that creates 2 new objects labled skyrim and myRPG.
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args) 
        {
            RPG myRPG = new RPG("M", "Fallout 3");
            Console.WriteLine(myRPG.Describe());
            myRPG.PlayGame();


            RPG skyrim = new RPG("T", "Skyrim");
            Console.WriteLine(skyrim.Describe());
            skyrim.PlayGame(); 

        }
    }
}
