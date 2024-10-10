using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FootballGame
{
    public class Team
    {
        //Attributes:
        public string TeamName;
        public Player[] PlayerList;
        //Constructor
        public Team(string teamName, Player[] PlayerList)
        {
            this.TeamName = teamName;
            this.PlayerList = PlayerList;
        }
    }
}