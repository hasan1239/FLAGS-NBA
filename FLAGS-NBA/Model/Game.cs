using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model
{
    public class Game : BaseModel
    {
        private string seasonYear;
        private string league;
        private string gameID;
        private string startTimeUTC;
        private string endTimeUTC;
        private string arena;
        private string city;
        private string country;
        private string clock;
        private string gameDuration;
        private string currentPeriod;
        private string halfTime;
        private string endOfPeriod;
        private string seasonStage;
        private string statusShortGame;
        private string statusGame;
        private Team vTeam;
        private Team hTeam;

        public string SeasonYear
        {
            get { return seasonYear; }
            set
            {
                seasonYear = value;
                OnPropertyChanged("SeasonYear");
            }
        }

        public string League
        {
            get { return league; }
            set
            {
                league = value;
                OnPropertyChanged("League");
            }
        }

        public string GameID
        {
            get { return gameID; }
            set
            {
                gameID = value;
                OnPropertyChanged("GameID");
            }
        }

        public string StartTimeUTC
        {
            get { return startTimeUTC; }
            set
            {
                startTimeUTC = value;
                OnPropertyChanged("StartTimeUTC");
            }
        }

        public string EndTimeUTC
        {
            get { return endTimeUTC; }
            set
            {
                endTimeUTC = value;
                OnPropertyChanged("EndTimeUTC");
            }
        }

        public string Arena
        {
            get { return arena; }
            set
            {
                arena = value;
                OnPropertyChanged("Arena");
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public string Clock
        {
            get { return clock; }
            set
            {
                clock = value;
                OnPropertyChanged("Clock");
            }
        }

        public string GameDuration
        {
            get { return gameDuration; }
            set
            {
                gameDuration = value;
                OnPropertyChanged("GameDuration");
            }
        }

        public string CurrentPeriod
        {
            get { return currentPeriod; }
            set
            {
                currentPeriod = value;
                OnPropertyChanged("CurrentPeriod");
            }
        }

        public string HalfTime
        {
            get { return halfTime; }
            set
            {
                halfTime = value;
                OnPropertyChanged("HalfTime");
            }
        }

        public string EndOfPeriod
        {
            get { return endOfPeriod; }
            set
            {
                endOfPeriod = value;
                OnPropertyChanged("EndOfPeriod");
            }
        }

        public string SeasonStage
        {
            get { return seasonStage; }
            set
            {
                seasonStage = value;
                OnPropertyChanged("SeasonStage");
            }
        }

        public string StatusShortGame
        {
            get { return statusShortGame; }
            set
            {
                statusShortGame = value;
                OnPropertyChanged("StatusShortGame");
            }
        }

        public string StatusGame
        {
            get { return statusGame; }
            set
            {
                statusGame = value;
                OnPropertyChanged("StatusGame");
            }
        }

        public Team VTeam
        {
            get { return vTeam; }
            set
            {
                vTeam = value;
                OnPropertyChanged("VTeam");
            }
        }

        public Team HTeam
        {
            get { return hTeam; }
            set
            {
                hTeam = value;
                OnPropertyChanged("HTeam");
            }
        }
    }
}
