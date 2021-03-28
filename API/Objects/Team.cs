using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.API.Objects
{
    public class Team
    {
        public string city { get; set; }
        public string fullName { get; set; }
        public string teamId { get; set; }
        public string nickname { get; set; }
        public string logo { get; set; }
        public string shortName { get; set; }
        public string allStar { get; set; }
        public string nbaFranchise { get; set; }
        public Score score { get; set; }
        //public League leagues { get; set; }
    }

    public class Score
    {
        public string points { get; set; }
    }
}
