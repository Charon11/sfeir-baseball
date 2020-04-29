using System;
using System.Collections.Generic;

namespace Baseball
{
    public class Team
    {
        private string name;
        private string cityLocation;
        private bool isMajorLeagueTeam;
        private HashSet<Player> players;

        public Team(string name, string cityLocation, string stadiumName, Boolean isMajorLeagueTeam)
        {
            this.name = name;
            this.cityLocation = cityLocation;
            StadiumName = stadiumName;
            this.isMajorLeagueTeam = isMajorLeagueTeam;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        public string CityLocation
        {
            get
            {
                return cityLocation;
            }
            set
            {
                cityLocation = value;
            }
        }

        public string StadiumName { get; set; }

        public bool IsMajorLeagueTeam
        {
            get
            {
                return isMajorLeagueTeam;
            }
            set
            {
                this.isMajorLeagueTeam = value;
            }
        }

        public HashSet<Player> Players
        {
            get
            {
                return players;
            }
            set
            {            players = value;
            }
        }

        public HashSet<Player> AddAPlayerToATeam(HashSet<Player> players, Player playerToAdd)
        {
            // All safe man I know my job
            HashSet<Player> playersTmp = players == null ? new HashSet<Player>() : players;
            playersTmp.Add(playerToAdd);
            return playersTmp;
        }


        public override string ToString()
        {
            return "Team [name=" + Name + ", cityLocation=" + CityLocation + ", statiumName=" + StadiumName
                    + ", isMajorLeagueTeam=" + IsMajorLeagueTeam + ", players=" + Players + " \n]";
        }

        public HashSet<Player> GetPitchers()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "pitcher")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetCatchers()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "catcher")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetInfields()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "infield")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetOutfields()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "outfield")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

        public HashSet<Player> GetDesignatedHitters()
        {
            HashSet<Player> result = new HashSet<Player>();
            Player[] playerArrays = new Player[players.Count];
            players.CopyTo(playerArrays);
            for (int i = 0; i < playerArrays.Length; i++)
            {
                Player currentPlayer = playerArrays[i];
                if (currentPlayer.GetPosition().ToLower() == "designated hitter")
                {
                    result.Add(currentPlayer);
                }
            }
            return result;
        }

    }
}

