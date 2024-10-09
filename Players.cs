using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballGame.Players;

namespace FootballGame
{
    public class Players : IDisplayInfo
    {
        public string PlayerName;
        public PlayerPosition  playerPosition;
        public int SkillesLevel;
        public Team team;
        public enum PlayerPosition
        {
            Forward, Midfielder, Defender, Goalkeeper
        }


        public  Players(string playerName, PlayerPosition playerPosition, int skillesLevel)
        {
            PlayerName=playerName;
            this.playerPosition=playerPosition;
            SkillesLevel=skillesLevel;
        }
        //using array here because here same type and it is fixed size : 11 players
        public static Random random = new Random();
        public static string[] names = { "Tom", "Jerry", "Chris", "Mike", "John", "Alex", "Max", "Leo", "Sam", "Ryan", "Ethan" };
        public static string[] positions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };

        // Method to generate a random player
        public Players GenerateRandomPlayer()
        {
            string randomName = GenerateRandomName();
            PlayerPosition randomPosition = GenerateRandomPosition();
            int randomSkillLevel = GenerateRandomSkillLevel();

            return new Players(randomName, randomPosition, randomSkillLevel);
        }

        // Method to generate a random player name
        public string GenerateRandomName()
        {
            // Generate a random index from the names array
            int randomIndex = random.Next(0, names.Length);
            return names[randomIndex];
        }

        // Method to generate a random player position
        public string GenerateRandomPosition()
        {
            // Generate a random index from the positions array
            int randomIndex = random.Next(0, positions.Length);
            return positions[randomIndex];
        }


        // Method to generate a random skill level (1 to 100)
        public int GenerateRandomSkillLevel()
        {
            // Generate a random skill level between 1 and 100
            return random.Next(1, 101);
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"player name :{PlayerName},player position:{playerPosition},skill:{SkillesLevel}");

        }
    }
}
