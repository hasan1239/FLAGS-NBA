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
    /// Interaction logic for Teams.xaml
    /// </summary>
    public partial class TeamsPage : UserControl, INotifyPropertyChanged
    {
        private ObservableCollection<Team> teams;
        public ObservableCollection<Team> Teams
        {
            get { return teams; }
            set 
            { 
                teams = value;
                OnPropertyChanged("Teams");
            }
        }

        public TeamsPage()
        {
            if (Teams == null || Teams.Count == 0)
            {
                /*Requests requests = new Requests();
                List<Team> teamsList = requests.GetAllTeamsAsync().Result;
                Teams = new ObservableCollection<Team>(teamsList);*/

                List<Team> teamList = new List<Team>();

                Team team1 = new Team();
                team1.fullName = "Golden State Warriors";
                team1.nickname = "Warriors";
                team1.shortName = "GSW";
                team1.city = "Golden State";
                team1.nbaFranchise = "1";
                team1.allStar = "0";
                team1.logo = "https://upload.wikimedia.org/wikipedia/fr/thumb/d/de/Warriors_de_Golden_State_logo.svg/1200px-Warriors_de_Golden_State_logo.svg.png";

                Team team2 = new Team();
                team2.fullName = "Mulwaukee Bucks";
                team2.nickname = "Bucks";
                team2.shortName = "MIL";
                team2.city = "Milwaukee";
                team2.nbaFranchise = "1";
                team2.allStar = "0";
                team2.logo = "https://upload.wikimedia.org/wikipedia/fr/3/34/Bucks2015.png";

                teamList.Add(team1);
                teamList.Add(team2);
                Teams = new ObservableCollection<Team>(teamList);
            }

            InitializeComponent();
        }

        private void btnItem_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Team team = button.DataContext as Team;

            if (team != null)
            {
                new InfoWindow(team).ShowDialog();
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
