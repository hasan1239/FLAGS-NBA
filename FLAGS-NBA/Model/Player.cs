using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model
{
    public class Player : BaseModel
    {
        private string firstName;
        private string lastName;
        private string teamID;
        private string yearsPro;
        private string collegeName;
        private string country;
        private string playerID;
        private string dateOfBirth;
        private string affiliation;
        private string startNBA;
        private string heightInMeters;
        private string weightInKilograms;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
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

        public string YearsPro
        {
            get { return yearsPro; }
            set
            {
                yearsPro = value;
                OnPropertyChanged("YearsPro");
            }
        }

        public string CollegeName
        {
            get { return collegeName; }
            set
            {
                collegeName = value;
                OnPropertyChanged("CollegeName");
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

        public string PlayerID
        {
            get { return playerID; }
            set
            {
                playerID = value;
                OnPropertyChanged("PlayerID");
            }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }

        public string Affiliation
        {
            get { return affiliation; }
            set
            {
                affiliation = value;
                OnPropertyChanged("Affiliation");
            }
        }

        public string StartNBA
        {
            get { return startNBA; }
            set
            {
                startNBA = value;
                OnPropertyChanged("StartNBA");
            }
        }

        public string HeightInMeters
        {
            get { return heightInMeters; }
            set
            {
                heightInMeters = value;
                OnPropertyChanged("HeightInMeters");
            }
        }

        public string WeightInKilograms
        {
            get { return weightInKilograms; }
            set
            {
                weightInKilograms = value;
                OnPropertyChanged("WeightInKilograms");
            }
        }

        //public League leagues { get; set; }
    }
}
