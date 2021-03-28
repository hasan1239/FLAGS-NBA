using FLAGS_NBA.API.Helper;
using FLAGS_NBA.API.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for Games.xaml
    /// </summary>
    public partial class GamesPage : UserControl, INotifyPropertyChanged
    {
        private ObservableCollection<Game> games;
        public ObservableCollection<Game> Games
        {
            get { return games; }
            set 
            { 
                games = value;
                OnPropertyChanged("Games");
            }
        }

        public GamesPage()
        {
            if (Games == null || Games.Count == 0)
            {
                Requests requests = new Requests();
                List<Game> playersList = requests.GetGamesAsync("2020-01-14").Result;
                Games = new ObservableCollection<Game>(playersList);

                /*List<Game> gamesList = new List<Game>();

                Game game1 = new Game();
                game1.seasonYear = "2018";
                game1.league = "utah";
                game1.gameId = "5706";
                game1.startTimeUTC = "2018-07-02T23:00:00.000Z";
                game1.endTimeUTC = "2018-07-03T00:48:00.000Z";
                game1.arena = "Vivint Smart Home Arena";
                game1.city = "Salt Lake City";
                game1.country = "USA";
                game1.clock = "";
                game1.gameDuration = "1:44";
                game1.currentPeriod = "4/4";
                game1.halftime = "0";
                game1.EndOfPeriod = "0";
                game1.seasonStage = "2";
                game1.statusShortGame = "3";
                game1.statusGame = "Finished";

                Team team1 = new Team();
                team1.fullName = "Golden State Warriors";
                team1.nickname = "Warriors";
                team1.shortName = "GSW";
                team1.city = "Golden State";
                team1.nbaFranchise = "1";
                team1.allStar = "0";
                team1.logo = "https://upload.wikimedia.org/wikipedia/fr/thumb/d/de/Warriors_de_Golden_State_logo.svg/1200px-Warriors_de_Golden_State_logo.svg.png";
                team1.score = new Score() { points = "145" };

                Team team2 = new Team();
                team2.fullName = "Mulwaukee Bucks";
                team2.nickname = "Bucks";
                team2.shortName = "MIL";
                team2.city = "Milwaukee";
                team2.nbaFranchise = "1";
                team2.allStar = "0";
                team2.logo = "https://upload.wikimedia.org/wikipedia/fr/3/34/Bucks2015.png";
                team2.score = new Score() { points = "98" };

                game1.vTeam = team1;
                game1.hTeam = team2;

                gamesList.Add(game1);

                Games = new ObservableCollection<Game>(gamesList);*/
            }

            InitializeComponent();
        }

        private void btnItem_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Game game = button.DataContext as Game;

            if (game != null)
            {
                new InfoWindow(game).ShowDialog();
            }
        }

        #region INotifyPropertyChanged Members

        // INotifyPropertyChanged event for auto refreshing changes to UI
        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
