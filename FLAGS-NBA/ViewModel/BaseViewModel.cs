using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FLAGS_NBA.ViewModel
{
    class BaseViewModel : INotifyPropertyChanged
    {
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                {
                    mUpdater = new Updater();
                }

                return mUpdater;
            }

            set { mUpdater = value; }
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

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
            }
        }
    }
}
