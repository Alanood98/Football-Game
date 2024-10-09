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
        //using array here because here same type and it is fixed size : 11 players
        private static Random random = new Random();
        private static string[] names = { "Tom", "Jerry", "Chris", "Mike", "John", "Alex", "Max", "Leo", "Sam", "Ryan", "Ethan" };
        private static string[] positions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };

        // Method to generate a random player name
        private string GenerateRandomName()
        {
            // Generate a random index from the names array
            int randomIndex = random.Next(0, names.Length);
            return names[randomIndex];
        }

        // Method to generate a random player position
        private string GenerateRandomPosition()
        {
            // Generate a random index from the positions array
            int randomIndex = random.Next(0, positions.Length);
            return positions[randomIndex];
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"player name :{PlayerName},player position:{PlayerPosition},skill:{SkillesLevel}");

        }
    }
}
