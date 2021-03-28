using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.API.Objects
{
    public class Player
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string teamId { get; set; }
        public string yearsPro { get; set; }
        public string collegeName { get; set; }
        public string country { get; set; }
        public string playerId { get; set; }
        public string dateofBirth { get; set; }
        public string affiliation { get; set; }
        public string startNba { get; set; }
        public string heightInMeters { get; set; }
        public string weightinKilograms { get; set; }
        //public League leagues { get; set; }
    }
}
