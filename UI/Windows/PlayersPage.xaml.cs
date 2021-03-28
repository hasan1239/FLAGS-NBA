using FLAGS_NBA.API.Helper;
using FLAGS_NBA.API.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FLAGS_NBA.UI.Windows
{
    /// <summary>
    /// Interaction logic for Players.xaml
    /// </summary>
    public partial class PlayersPage : UserControl
    {
        private ObservableCollection<Player> players;
        public ObservableCollection<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public PlayersPage()
        {
            if (Players == null || Players.Count == 0)
            {
                /*Requests requests = new Requests();
                List<Player> playersList = requests.GetPlayersAsync("curry").Result;
                Players = new ObservableCollection<Player>(playersList);*/

                List<Player> playerList = new List<Player>();

                Player stephen = new Player();
                stephen.affiliation = "Davidson/USA";
                stephen.collegeName = "Davidson";
                stephen.country = "USA";
                stephen.dateofBirth = "1988-03-14";
                stephen.firstName = "Stephen";
                stephen.heightInMeters = "1.9";
                stephen.lastName = "Curry";
                stephen.playerId = "124";
                stephen.startNba = "2009";
                stephen.teamId = "11";
                stephen.weightinKilograms = "83.9";
                stephen.yearsPro = "11";

                Player seth = new Player();
                seth.affiliation = "Duke/USA";
                seth.collegeName = "Duke";
                seth.country = "USA";
                seth.dateofBirth = "1990-08-23";
                seth.firstName = "Seth";
                seth.heightInMeters = "1.88";
                seth.lastName = "Curry";
                seth.playerId = "123";
                seth.startNba = "2013";
                seth.teamId = "27";
                seth.weightinKilograms = "83.9";
                seth.yearsPro = "6";

                playerList.Add(stephen);
                playerList.Add(seth);

                Players = new ObservableCollection<Player>(playerList);
            }

            InitializeComponent();
        }

        private void btnItem_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Player player = button.DataContext as Player;

            if (player != null)
            {
                new InfoWindow(player).ShowDialog();
            }
        }
    }
}
