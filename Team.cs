using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Team : IDisplayInfo
    {
        public string TeamName1;
        public string TeamName2;
        public List<Players> TeamNames = new List<Players>();



        public  Team(string teamName1 , string teamName2) 
        {
            TeamName1 = teamName1;
            TeamName2 = teamName2;

        }




        public void DisplayInfo()
        {


        }

    }
}
