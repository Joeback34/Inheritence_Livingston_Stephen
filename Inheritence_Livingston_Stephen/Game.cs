using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Livingston_Stephen
{
    abstract class Game
    {   /// <summary>
    /// Gets and sets values to Esrb and Title.
    /// </summary>
        public string Esrb { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// Adds parameters to esrb and title.
        /// </summary>
        /// <param name="esrbParam"></param>
        /// <param name="titleParam"></param>
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;

            Title = titleParam;
        }
        /// <summary>
        /// prints the title and says it is starting
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        public abstract string Describe();
    }
}
