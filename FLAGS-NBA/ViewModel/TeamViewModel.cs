using FLAGS_NBA.API.Helper;
using FLAGS_NBA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.ViewModel
{
    class TeamViewModel : BaseViewModel
    {
        private IList<Team> teams;
        private List<Team> allTeams;

        public IList<Team> Teams
        {
            get { return teams; }
            set
            {
                teams = value;
                OnPropertyChanged("Teams");
            }
        }

        public List<Team> AllTeams
        {
            get { return allTeams; }
            set
            {
                allTeams = value;
                OnPropertyChanged("AllTeams");
            }
        }

        public TeamViewModel()
        {
            AllTeams = RequestHelper.GetAllTeams().ToList();
            Teams = AllTeams;
        }
    }
}
