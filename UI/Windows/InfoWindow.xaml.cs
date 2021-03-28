using FLAGS_NBA.API.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FLAGS_NBA.UI.Windows
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        private Team team;
        private Player player;
        private Game game;

        public Team Team
        {
            get { return team; }
            set { team = value; }
        }

        public bool IsTeam
        {
            get { return Team != null; }
        }

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public bool IsPlayer
        {
            get { return Player != null; }
        }

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public bool IsGame
        {
            get { return Game != null; }
        }

        public string TitleText
        {
            get
            {
                if (IsTeam)
                {
                    return Team.fullName;
                }
                
                if (IsPlayer)
                {
                    return Player.firstName + " " + Player.lastName;
                }

                if (IsGame)
                {
                    return Game.hTeam.shortName + "v" + Game.vTeam.shortName;
                }

                return string.Empty;
            }
        }

        public InfoWindow(Team team)
        {
            this.team = team;
            InitializeComponent();
        }

        public InfoWindow(Player player)
        {
            this.player = player;
            InitializeComponent();
        }

        public InfoWindow(Game game)
        {
            this.game = game;
            InitializeComponent();
        }
    }
}
