using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model
{
    public class BaseModel : INotifyPropertyChanged
    {
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
