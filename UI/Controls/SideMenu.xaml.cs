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
        private GamesPage gamesPage;
        private TeamsPage teamsPage;
        private PlayersPage playersPage;

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

        public SideMenu()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            ListViewItem item = sender as ListViewItem;

            if (item.Tag.ToString() == "Games")
            {
                if (GamesPage == null)
                {
                    GamesPage = new GamesPage();
                }

                Switcher.Navigate(GamesPage);
            }
            else if (item.Tag.ToString() == "Teams")
            {
                if (TeamsPage == null)
                {
                    TeamsPage = new TeamsPage();
                }

                Switcher.Navigate(TeamsPage);
            }
            else
            {
                if (PlayersPage == null)
                {
                    PlayersPage = new PlayersPage();
                }

                Switcher.Navigate(PlayersPage);
            }
        }

        private void IconTextBox_Click(object sender, RoutedEventArgs e)
        {
            string test = searchTextBox.Text;


        }
    }
}
