using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollSys
{
    // stworzyc lige, z lista zespolow liga oblicza miejsce w tabeli na podstawie punktow, gdy rowne gole, klasa powinna posiadac max liczbe druzyn
    // max liczbe meczy
    class League : Team
    {
        protected List<Team> _teams = new List<Team>();
        protected int _maxTeamsNumbers;
        protected int _maxMatchesNumbers;
        protected string _name;
        protected List<Team> _leagueTable = new List<Team>();

        public League()
        {
            _maxMatchesNumbers = 0;
            _maxTeamsNumbers = 0;
        }

        public League(string name, List<Team> teams, int maxTeamsNumbers, int maxMatchesNumbers)
        {
            _name = name;
            _teams = teams;
            _maxTeamsNumbers = maxTeamsNumbers;
            _maxMatchesNumbers = maxMatchesNumbers;
            LeagueOrder(_teams);
        }

        public static void CreateLeague()
        {
            Console.WriteLine("Podaj nazwe ligi:");
            string leagueName = Console.ReadLine();
            Console.WriteLine("Wprowadz nazwe druzyny, k - konczy dodawanie druzyn");
            int points;
            int goalsScored;
            int goalsConceded;
            string teamName = Console.ReadLine();
            List <Team> teams = new List<Team>();
            while (teamName != "k")
            {
                Console.WriteLine("Podaj ilosc zdobytych przez druzyne punktow:");
                points = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ilosc zdobytych bramek przez druzyne:");
                goalsScored = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ilosc straconych bramek przez druzyne");
                goalsConceded = Int32.Parse(Console.ReadLine());
                Team team = new Team(teamName, points, goalsScored, goalsConceded);
                teams.Add(team);
                Console.WriteLine("Podaj nazwe nastepnej druzyny lub k aby zakonczyc");
                teamName = Console.ReadLine();
            }
            League league = new League(leagueName, teams, teams.Count(), (teams.Count() * 2));
            league.ShowLeague(league);
        }

        public void LeagueOrder(List<Team> teams)
        {
            _leagueTable = teams;

            // x i y to dwie druzyny(dwa obiekty) dla których porownujemy ilość w tym przypadku punktow, w przyppadku tej samej liczby punktow porownujemy bilans bramek
            _leagueTable.Sort((x, y) =>
            {
                int comparePoints = y.Points.CompareTo(x.Points);
                return comparePoints == 0 ? y.Balance.CompareTo(x.Balance) : comparePoints;
            });
        }
        public void ShowLeague(League league)
        {
                Team.ShowTeams(league._leagueTable);
        }
    }
}
