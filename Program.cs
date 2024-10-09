namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Soccer Game Simulator!");
            Console.WriteLine("Enter name for Team 1:");
            string teamName1 = Console.ReadLine();
            Console.WriteLine("Enter name for Team 2:");
            string teamName2 = Console.ReadLine();
            Team team1 = new Team(teamName1);
            Team team2 = new Team(teamName2);
            team1.GenerateTeamPlayers(11);
            team2.GenerateTeamPlayers(11);
        }
    }
}
