using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.API.Objects
{
    public class Game
    {
        public string seasonYear { get; set; }
        public string league { get; set; }
        public string gameId { get; set; }
        public string startTimeUTC { get; set; }
        public string endTimeUTC { get; set; }
        public string arena { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string clock { get; set; }
        public string gameDuration { get; set; }
        public string currentPeriod { get; set; }
        public string halftime { get; set; }
        public string EndOfPeriod { get; set; }
        public string seasonStage { get; set; }
        public string statusShortGame { get; set; }
        public string statusGame { get; set; }
        public Team vTeam { get; set; }
        public Team hTeam { get; set; }
    }
}
