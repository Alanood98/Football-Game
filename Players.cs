using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Players : IDisplayInfo
    {
        public string PlayerName;
        public string PlayerPosition;
        public int SkillesLevel;


        public  Players(string playerName, string playerPosition, int skillesLevel)
        {
            PlayerName=playerName;
            PlayerPosition=playerPosition;
            SkillesLevel=skillesLevel;
        }
        private static Random random = new Random();
        private static string[] names = { "Tom", "Jerry", "Chris", "Mike", "John", "Alex", "Max", "Leo", "Sam", "Ryan", "Ethan" };
        private static string[] positions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };
        

        
        public void DisplayInfo()
        {
            Console.WriteLine($"player name :{PlayerName},player position:{PlayerPosition},skill:{SkillesLevel}");

        }
    }
}
