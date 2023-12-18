using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbollSys
{
    class Team
    {
        protected string _teamName;
        protected int _points;
        protected int _goalsScored;
        protected int _goalsConceded;
        protected int _balance;

        public int Points;
        public int Balance;
        public string Name;
        public Team()
        {
            _teamName = "brak";
            _points = 0;
            _goalsScored = 0;
            _goalsConceded = 0;
            _balance = _goalsScored - _goalsConceded;
            Name = _teamName;
        }

        public Team(string teamName, int points, int goalsScored, int goalsConceded)
        {
            _teamName = teamName;
            _points = points;
            Points = points;
            _goalsScored = goalsScored;
            _goalsConceded = goalsConceded;
            _balance = goalsScored - goalsConceded;
            Balance = _balance;
            Name = _teamName;
        }
        public static void ShowTeams(List<Team> teams) 
        {
            int i = 1;
            foreach (var team in teams) 
            {
                Console.WriteLine(i++ + ". " + team._teamName + " " + team._points + " " + team._goalsScored + "-" + team._goalsConceded);
            }
        
        }
    }
}
