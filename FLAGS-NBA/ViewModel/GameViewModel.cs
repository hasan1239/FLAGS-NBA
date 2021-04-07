using FLAGS_NBA.API.Helper;
using FLAGS_NBA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.ViewModel
{
    class GameViewModel : BaseViewModel
    {
        private IList<Game> games;
        private string searchDate;

        public IList<Game> Games
        {
            get { return games; }
            set
            {
                games = value;
                OnPropertyChanged("Games");
            }
        }

        public string SearchDate
        {
            get { return searchDate; }
            set
            {
                searchDate = value;
                OnPropertyChanged("SearchDate");
            }
        }

        public GameViewModel()
        {
            Requests requests = new Requests();
            Games = requests.GetGamesAsync("2020-01-14").Result;
            SearchDate = "2020-01-14";
        }
    }
}
