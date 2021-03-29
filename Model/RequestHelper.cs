using FLAGS_NBA.API.Helper;
using FLAGS_NBA.API.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model
{
    public class RequestHelper
    {
        public static ObservableCollection<Player> GetPlayers(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                Requests requests = new Requests();
                List<Player> players = requests.GetPlayersAsync(lastName).Result;

                return new ObservableCollection<Player>(players);
            }

            return new ObservableCollection<Player>();
        }

        public static ObservableCollection<Team> GetTeams(string shortName)
        {
            if (!string.IsNullOrEmpty(shortName))
            {
                Requests requests = new Requests();
                List<Team> teams = requests.GetTeamsAsync(shortName).Result;

                return new ObservableCollection<Team>(teams);
            }

            return new ObservableCollection<Team>();
        }

        public static ObservableCollection<Game> GetGames(string date)
        {
            if (!string.IsNullOrEmpty(date))
            {
                Requests requests = new Requests();
                List<Game> games = requests.GetGamesAsync(date).Result;

                return new ObservableCollection<Game>(games);
            }

            return new ObservableCollection<Game>();
        }
    }
}
