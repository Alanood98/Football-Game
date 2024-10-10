using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FootballGame
{
    public class Match
    {
        public int score = 0;
        public Match(int score) { this.score = score; }
        public int coin_toss()
        {
            Random random = new Random();
            int head_tail = random.Next(0, 2);
            return head_tail;
        }
        public int calculate_power(Team team, bool is_attack)
        {
            int bower = 0;
            if (is_attack)
            {
                foreach (Player player in team.PlayerList)
                {
                    if ((player.position == Player.Positions.Forward) || (player.position == Player.Positions.Midfielder))
                    {
                        bower = bower + player.skillLevel;
                    }
                }
            }
            else
            {
                foreach (Player player in team.PlayerList)
                {
                    if ((player.position == Player.Positions.Goalkeeper) || (player.position == Player.Positions.Defender))
                    {
                        bower = bower + player.skillLevel;
                    }
                }
            }
            return bower;
        }
        public int final_result(int goal1, int goal2)
        {
            if (goal1 < goal2)
            {
                return 2;
            }
            else if (goal1 > goal2) { return 1; }
            return 0;
        }
    }
}