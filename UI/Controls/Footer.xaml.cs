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
using System.Windows.Threading;

namespace FLAGS_NBA.UI.Controls
{
    /// <summary>
    /// Interaction logic for Footer.xaml
    /// </summary>
    public partial class Footer : UserControl
    {
        private SettingsPage settingsPage;

        public SettingsPage SettingsPage
        {
            get { return settingsPage; }
            set { settingsPage = value; }
        }

        public Footer()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal, delegate
                {
                    this.txtDateTime.Text = DateTime.Now.ToString("G");
                }, this.Dispatcher);
        }

        private void tglBtnDarkMode_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.DarkTheme = true;
            Properties.Settings.Default.Save();
        }

        private void tglBtnDarkMode_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.DarkTheme = false;
            Properties.Settings.Default.Save();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            if (settingsPage == null)
            {
                SettingsPage = new SettingsPage();
            }

            Switcher.Navigate(SettingsPage);
        }
    }
}
