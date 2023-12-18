namespace FutbollSys
{
    class Program
    {
        static void Main(string[] args)
        {
            League.CreateLeague();
            Team RealMadrid = new Team("Real Madrid", 27, 36, 12);
            Team FcBarcelona = new Team("Fc Barcelona", 20, 34, 16);
            Team AtlecticoMadrid = new Team("Atletico Madrid", 25, 30, 14);
            Team RealSociedad = new Team("Real Sociedad", 19, 29, 16);
            Team Girona = new Team("Girona", 25, 35, 19);
            
            List<Team> LaLiga = new List<Team>();
            LaLiga.Add(RealMadrid);
            LaLiga.Add(FcBarcelona);
            LaLiga.Add(AtlecticoMadrid);
            LaLiga.Add(RealSociedad);
            LaLiga.Add(Girona);

            League LaLigue = new League("La liga", LaLiga, LaLiga.Count,0);
           LaLigue.ShowLeague(LaLigue);

            //Team.ShowTeams(LaLiga);
        }
    }
}