using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team : IDisplayInfo
    {
        public string TeamName;
        public Players players;
        public Players[] Players;
        static   int Score =0;
        



        public  Team(string teamName , int score) 
        {
            TeamName = teamName;
            Score = score;
            Players = new Players[11];

        }

        public void GenerateTeamPlayers()
        {
            for (int i = 0; i < Players.Length; i++)
            {
                Players[i] = Players.GenerateRandomPlayer();
            }
        }

        // Display team information
        public void DisplayInfo()
        {
            Console.WriteLine($"Team Name: {TeamName}, Score: {Score}");
            Console.WriteLine("Team Roster:");
            foreach (var player in Players)
            {
                player.DisplayInfo();
            }
        }
    }

}

