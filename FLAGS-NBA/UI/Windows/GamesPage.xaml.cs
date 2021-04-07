using FLAGS_NBA.API.Helper;
using FLAGS_NBA.Model;
using FLAGS_NBA.ViewModel;
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
    public partial class GamesPage : UserControl
    {
        public GamesPage()
        {
            this.DataContext = new GameViewModel();
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
    }
}
