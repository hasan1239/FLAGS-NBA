using FLAGS_NBA.Model;
using FLAGS_NBA.UI.Windows;
using System;
using System.Collections.Generic;
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

namespace FLAGS_NBA.UI.Controls
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {
        private WelcomePage welcomePage;
        private GamesPage gamesPage;
        private TeamsPage teamsPage;
        private PlayersPage playersPage;
        private object currentPage;

        public WelcomePage WelcomePage
        {
            get { return welcomePage; }
            set { welcomePage = value; }
        }

        public GamesPage GamesPage
        {
            get { return gamesPage; }
            set { gamesPage = value; }
        }

        public TeamsPage TeamsPage
        {
            get { return teamsPage; }
            set { teamsPage = value; }
        }

        public PlayersPage PlayersPage
        {
            get { return playersPage; }
            set { playersPage = value; }
        }

        public object CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
            }
        }

        public SideMenu()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            ListViewItem item = sender as ListViewItem;

            if (item.Tag.ToString() == "Home")
            {
                if (WelcomePage == null)
                {
                    WelcomePage = new WelcomePage();
                }

                Switcher.Navigate(WelcomePage);
                CurrentPage = WelcomePage;
            }
            else if (item.Tag.ToString() == "Games")
            {
                if (GamesPage == null)
                {
                    GamesPage = new GamesPage();
                }

                Switcher.Navigate(GamesPage);
                CurrentPage = GamesPage;
            }
            else if (item.Tag.ToString() == "Teams")
            {
                if (TeamsPage == null)
                {
                    TeamsPage = new TeamsPage();
                }

                Switcher.Navigate(TeamsPage);
                CurrentPage = TeamsPage;
            }
            else
            {
                if (PlayersPage == null)
                {
                    PlayersPage = new PlayersPage();
                }

                Switcher.Navigate(PlayersPage);
                CurrentPage = PlayersPage;
            }
        }

        private void IconTextBox_Click(object sender, RoutedEventArgs e)
        {
            string searchText = searchTextBox.Text;

            if (GamesPage != null && CurrentPage is GamesPage)
            {
                GamesPage.Games = RequestHelper.GetGames(searchText);
            }
            else if (TeamsPage != null && CurrentPage is TeamsPage)
            {
                //Used this approach to make it more efficient and minimise sending requests to API
                teamsPage.Teams = SearchHelper.SearchTeams(searchText, teamsPage.AllTeams);

                //TeamsPage.Teams = RequestHelper.GetTeams(searchText);
            }
            else if (PlayersPage != null && CurrentPage is PlayersPage)
            {
                PlayersPage.Players = RequestHelper.GetPlayers(searchText);
            }
        }
    }
}
