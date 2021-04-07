using FLAGS_NBA.API;
using FLAGS_NBA.API.Helper;
using FLAGS_NBA.Model;
using FLAGS_NBA.UI.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using System.Windows.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace FLAGS_NBA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Switcher.pageSwitcher = grdPages;
            Switcher.Navigate(new WelcomePage());
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            Requests requests = new Requests();
            List<Player> players = requests.GetPlayersAsync("curry").Result;
            List<Player> lebron = requests.GetPlayersAsync("james").Result;

            List<Team> teams = requests.GetAllTeamsAsync().Result;

            string test = string.Empty;
        }*/
    }
}
