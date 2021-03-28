using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FLAGS_NBA.Model
{
    public static class Switcher
    {
        public static Grid pageSwitcher;

        public static void Navigate(UserControl newPage)
        {
            pageSwitcher.Children.Clear();
            pageSwitcher.Children.Add(newPage);
        }
    }
}
