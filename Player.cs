using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FootballGame
{
    public class Player
    {
        // Attributes:
        public string playerName;
        public int skillLevel;
        public enum Positions { Forward, Midfielder, Defender, Goalkeeper };
        public Positions position;
        //Constructor
        public Player(string playerName, int skillLevel, Positions position)
        {
            this.playerName = playerName;
            this.skillLevel = skillLevel;
            this.position = position;
        }
        public void assignplayervalue(Player[] PlayerList, string[] playernames)
        {
            Random random = new Random();
            bool[] usedNames = new bool[playernames.Length];
            Positions[] positions = { Positions.Forward, Positions.Midfielder, Positions.Defender };
            int randomIndex;
            do
            {
                randomIndex = random.Next(playernames.Length);
            }
            while (usedNames[randomIndex]);
            usedNames[randomIndex] = true;
            int goalkeeperSkillLevel = random.Next(1, 101);
            PlayerList[0] = new Player(playernames[randomIndex], goalkeeperSkillLevel, Positions.Goalkeeper);
            for (int i = 1; i < PlayerList.Length; i++)
            {
                do
                {
                    randomIndex = random.Next(playernames.Length);
                }
                while (usedNames[randomIndex]);
                usedNames[randomIndex] = true;
                Positions randomPosition = positions[random.Next(positions.Length)];
                int randomSkillLevel = random.Next(1, 101);
                PlayerList[i] = new Player(playernames[randomIndex], randomSkillLevel, randomPosition);
            }
        }
    }
}