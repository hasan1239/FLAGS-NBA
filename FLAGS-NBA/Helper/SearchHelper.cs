using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model
{
    public class SearchHelper
    {
        public static List<Team> SearchTeams(string searchText, List<Team> allTeams)
        {
            if (allTeams != null && allTeams.Count > 0)
            {
                string sPattern = searchText;

                return allTeams.FindAll(t => System.Text.RegularExpressions.Regex.IsMatch(t.FullName, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase));
            }

            return new List<Team>();
        }
    }
}
