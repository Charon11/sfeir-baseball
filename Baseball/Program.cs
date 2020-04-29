using System;
using System.Collections.Generic;

namespace Baseball
{
    class MainClass
    {
        static string MLB_LOGO;

        public MainClass()
        {
            MLB_LOGO = "          Boston  Red Sox Baseball  Boston   Red Sox  Baseball \n"
                + "              BA                            SEB                   A \n"
                + "              LL                   S.F.Gia    BAS                 EB \n"
                + "              AL                  LBoston\"    A\'s                 \"B \n"
                + "              AS                 EBALLS.F.G      ia               nt \n"
                + "              sB                  ASEBALLS.       F.G             ia \n"
                + "              BA                   SEBALLOakland\"A\'s\"B            AS \n"
                + "              EB                 ALLS.F.GiantsBASEBALLS.          F. \n"
                + "              Gi   aBA          SEBALLOakland\"A\'s\"BASEBALL        S. \n"
                + "              F.   Gia         ntsBASEBALLS.F.GiaBASEBALLO        ak \n"
                + "               l                 and\"A\'s\"BASEBALLS.F.             Gi \n"
                + "                a                ntsBASEBALLS.F.GiaBA            S\n"
                + "                 S.F. Giants Baseball S.F. Giants Baseball'";
        }
        public static void Main(string[] args)
        {
            // David Ortiz
            string namePlayer1 = "Ortiz";
            string firstNamePlayer1 = "David";
            Player davidOrtiz = new Player();
            davidOrtiz.Name = namePlayer1;
            davidOrtiz.firstName = firstNamePlayer1;
            davidOrtiz.SetPosition("Designated Hitter");

            // David Price
            string namePlayer2 = "Price";
            string firstNamePlayer2 = "David";
            Player davidPrice = new Player();
            davidPrice.Name = namePlayer2;
            davidPrice.firstName = firstNamePlayer2;
            davidPrice.SetPosition("Pitcher");

            // David Wells
            string namePlayer3 = "Wells";
            string firstNamePlayer3 = "David";
            Player davidWells = new Player();
            davidWells.Name = namePlayer3;
            davidWells.firstName = firstNamePlayer3;
            davidWells.SetPosition("Pitcher");

            // R
            Team redSox = new Team("Red Sox", "Boston", "Fenway Park", true);

            // Add David Price, David Ortiz and David Wells
            // We had such a great team now two super famous pitchers! We gonna win
            // the MLB.
            HashSet<Player> allPlayers1 = redSox.AddAPlayerToATeam(redSox.Players, davidOrtiz);
            HashSet<Player> allPlayers2 = redSox.AddAPlayerToATeam(allPlayers1, davidPrice);
            HashSet<Player> allPlayers3 = redSox.AddAPlayerToATeam(allPlayers2, davidWells);

            redSox.Players = allPlayers3;

            // Set the team to the player
            davidPrice.CurrentTeam = redSox;
            davidOrtiz.CurrentTeam = redSox;
            davidWells.CurrentTeam = redSox;

            //TODO: Add John Farrell as a Manager?! How can I do that? C# is so complicated

            Console.Out.WriteLine(MLB_LOGO);
            Console.Out.WriteLine(" ");

            DisplayTheTeamUtils.DisplayTheTeam(redSox);
            Console.ReadLine();
        }
    }
}
