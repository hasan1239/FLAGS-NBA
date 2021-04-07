using FLAGS_NBA.API.Helper;
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
        public static IList<Player> GetPlayers(string lastName)
        {
            if (!string.IsNullOrEmpty(lastName))
            {
                Requests requests = new Requests();
                return requests.GetPlayersAsync(lastName).Result;

                //return new ObservableCollection<Player>(players);
            }

            return new List<Player>();
        }

        public static IList<Team> GetTeams(string shortName)
        {
            if (!string.IsNullOrEmpty(shortName))
            {
                Requests requests = new Requests();
                return requests.GetTeamsAsync(shortName).Result;

                //return new ObservableCollection<Team>(teams);
            }

            //return new ObservableCollection<Team>();
            return new List<Team>();
        }

        public static IList<Game> GetGames(string date)
        {
            if (!string.IsNullOrEmpty(date))
            {
                Requests requests = new Requests();
                return requests.GetGamesAsync(date).Result;

                //return new ObservableCollection<Game>(games);
            }

            //return new ObservableCollection<Game>();
            return new List<Game>();
        }
    }
}
