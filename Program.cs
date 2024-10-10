using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml.Linq;
using static FootballGame.Player;
using static FootballGame.Program;
namespace FootballGame
{
    internal class Program
    {
        public enum Positions { Forward, Midfielder, Defender, Goalkeeper }
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Welcome to the Soccer Game Simulator!");
            Console.WriteLine("Enter name for Team 1:");
            string teamName1 = Console.ReadLine();
            Player[] PlayerList1 = new Player[11];
            Console.WriteLine("Enter name for Team 2:");
            string teamName2 = Console.ReadLine();
            Player[] PlayerList2 = new Player[11];
            string[] plyers_nam = ["Chris", "Mike", "Tom", "Jerry", "messi", "CR7", "Nymar", "Ahmed", "benzima", "Ramos", "Marselo"];
            Player player = new Player("", 0, Player.Positions.Forward);
            player.assignplayervalue(PlayerList1, plyers_nam);
            player.assignplayervalue(PlayerList2, plyers_nam);
            Team team1 = new Team(teamName1, PlayerList1);
            Team team2 = new Team(teamName2, PlayerList2);
            //display players information
            Console.WriteLine($"Team {teamName1}:");
            int count = 1;
            foreach (var p in PlayerList1)
            {
                Console.WriteLine($"{count}.{p.playerName} - {p.position} - (Skill: {p.skillLevel})");
                count++;
            }
            Console.WriteLine($"Team {teamName2}:");
            int count2 = 1;
            foreach (var p in PlayerList2)
            {
                Console.WriteLine($"{count2}.{p.playerName} - {p.position} - (Skill: {p.skillLevel})");
                count2++;
            }
            Match match = new Match(0);
            int coin = match.coin_toss();
            bool team1start = false;
            if (coin == 1)
            {
                Console.WriteLine($"Team {teamName1} will start the game.");
                team1start = true;
            }
            else
            {
                Console.WriteLine($"Team {teamName2} will start the game.");
                team1start = false;
            }
            Console.WriteLine("--- First Half ---");
            int half1_turn = 5; // Total turns in the first half
            int c = 1; // Counter for turns
            int team1_goal = 0; // Score for team 1
            int team2_goal = 0; // Score for team 2
            for (int i = 0; i < half1_turn; i++)
            {
                if (team1start)
                {
                    // Team 1 is attacking
                    if ((match.calculate_power(team1, true)) > (match.calculate_power(team2, false) + 5))
                    {
                        Console.WriteLine($"Turn {c}: {teamName1} are attacking... Goal!");
                        team1_goal++;
                    }
                    else
                    {
                        Console.WriteLine($"Turn {c}: {teamName1} are attacking... Defended successfully!");
                    }
                }
                else
                {
                    // Team 2 is attacking
                    if ((match.calculate_power(team2, true)) > (match.calculate_power(team1, false) + 5))
                    {
                        Console.WriteLine($"Turn {c}: {teamName2} are attacking... Goal!");
                        team2_goal++;
                    }
                    else
                    {
                        Console.WriteLine($"Turn {c}: {teamName2} are attacking... Defended successfully!");
                    }
                }
                // Switch attacking team for the next turn
                team1start = !team1start;
                c++; // Increment turn counter
            }
            Console.WriteLine(); 
            Console.WriteLine("--- Second Half ---");
            int half2_turn = 5; 
            for (int i = 0; i < half2_turn; i++)
            {
                if (team1start)
                {
                    // Team 1 is attacking
                    if ((match.calculate_power(team1, true)) > (match.calculate_power(team2, false) + 5))
                    {
                        Console.WriteLine($"Turn {c}: {teamName1} are attacking... Goal!");
                        team1_goal++;
                    }
                    else
                    {
                        Console.WriteLine($"Turn {c}: {teamName1} are attacking... Defended successfully!");
                    }
                }
                else
                {
                    // Team 2 is attacking
                    if ((match.calculate_power(team2, true)) > (match.calculate_power(team1, false) + 5))
                    {
                        Console.WriteLine($"Turn {c}: {teamName2} are attacking... Goal!");
                        team2_goal++;
                    }
                    else
                    {
                        Console.WriteLine($"Turn {c}: {teamName2} are attacking... Defended successfully!");
                    }
                }
                // Switch attacking team for the next turn
                team1start = !team1start;
                c++;
            }
            Console.WriteLine("Final Score:");
            Console.WriteLine($"{teamName1}: {team1_goal} | {teamName2}: {team2_goal}");
            int finalresult = match.final_result(team1_goal, team2_goal);
            if (finalresult == 1)
            {
                Console.WriteLine($"{teamName1} wins!");
            }
            else if (finalresult == 2)
            {
                Console.WriteLine($"{teamName2} wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}