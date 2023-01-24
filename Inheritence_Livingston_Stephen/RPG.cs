using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence_Livingston_Stephen
{
    class RPG : Game
    {   /// <summary>
    /// Inherits from the Game class and describes the game using the override method. 
    /// </summary>
    /// <param name="esrbParam"></param>
    /// <param name="titleParam"></param>
        public RPG(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            
            Esrb = esrbParam;
        }
        public override string Describe()
        {
            return $"{Title} is a RPG game rated {Esrb}!";


        }
    }
}
