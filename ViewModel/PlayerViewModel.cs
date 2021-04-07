using FLAGS_NBA.API.Helper;
using FLAGS_NBA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.ViewModel
{
    class PlayerViewModel : BaseViewModel
    {
        private IList<Player> players;

        public IList<Player> Players
        {
            get { return players; }
            set
            {
                players = value;
                OnPropertyChanged("Players");
            }
        }

        public PlayerViewModel()
        {
            Requests requests = new Requests();
            Players = requests.GetPlayersAsync("curry").Result;
        }
    }
}
