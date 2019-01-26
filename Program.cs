using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlay gameplay = new GamePlay();
            UserInterface userinterface = new UserInterface();
            userinterface.RunUserInterFace();
            gameplay.RunGame();

        }//end Main
    }//end Class
}//end Namespace
