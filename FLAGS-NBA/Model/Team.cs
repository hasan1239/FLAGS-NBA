using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model
{
    public class Team : BaseModel
    {
        private string city;
        private string fullName;
        private string teamID;
        private string nickname;
        private string logo;
        private string shortName;
        private string allStar;
        private string nbaFranchise;
        private Score score;

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        public string TeamID
        {
            get { return teamID; }
            set
            {
                teamID = value;
                OnPropertyChanged("TeamID");
            }
        }

        public string Nickname
        {
            get { return nickname; }
            set
            {
                nickname = value;
                OnPropertyChanged("Nickname");
            }
        }

        public string Logo
        {
            get { return logo; }
            set
            {
                logo = value;
                OnPropertyChanged("Logo");
            }
        }

        public string ShortName
        {
            get { return shortName; }
            set
            {
                shortName = value;
                OnPropertyChanged("ShortName");
            }
        }

        public string AllStar
        {
            get { return allStar; }
            set
            {
                allStar = value;
                OnPropertyChanged("AllStar");
            }
        }

        public string NBAFranchise
        {
            get { return nbaFranchise; }
            set
            {
                nbaFranchise = value;
                OnPropertyChanged("NBAFranchise");
            }
        }

        public Score Score
        {
            get { return score; }
            set
            {
                score = value;
                OnPropertyChanged("Score");
            }
        }

        //public League leagues { get; set; }
    }

    public class Score : BaseModel
    {
        private string points;

        public string Points
        {
            get { return points; }
            set
            {
                points = value;
                OnPropertyChanged("Points");
            }
        }
    }
}
