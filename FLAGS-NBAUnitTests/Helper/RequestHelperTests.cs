using Microsoft.VisualStudio.TestTools.UnitTesting;
using FLAGS_NBA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAGS_NBA.Model.UnitTests
{
    [TestClass()]
    public class RequestHelperTests
    {
        private int ExpectedPlayersEmptyCount = 0;
        [TestMethod()]
        public void GetPlayersEmptyTest()
        {
            IList<Player> players = RequestHelper.GetPlayers("");
            Assert.AreEqual(ExpectedPlayersEmptyCount, players.Count);
        }

        private int ExpectedPlayersFilledCount = 2;
        [TestMethod()]
        public void GetPlayersFilledTest()
        {
            IList<Player> players = RequestHelper.GetPlayers("curry");
            Assert.AreEqual(ExpectedPlayersFilledCount, players.Count);
        }

        private int ExpectedTeamsEmptyCount = 0;
        [TestMethod()]
        public void GetTeamsEmptyTest()
        {
            IList<Team> teams = RequestHelper.GetTeams("");
            Assert.AreEqual(ExpectedTeamsEmptyCount, teams.Count);
        }

        private int ExpectedTeamsFilledCount = 1;
        [TestMethod()]
        public void GetTeamsFilledTest()
        {
            IList<Team> teams = RequestHelper.GetTeams("GSW");
            Assert.AreEqual(ExpectedTeamsFilledCount, teams.Count);
        }

        private int ExpectedTeamsSearchCount = 4;
        [TestMethod()]
        public void GetTeamsSearchTest()
        {
            string searchText = "team";

            IList<Team> allTeams = RequestHelper.GetAllTeams();
            List<Team> result = SearchHelper.SearchTeams(searchText, allTeams.ToList());

            Assert.AreEqual(ExpectedTeamsSearchCount, result.Count);
        }

        private int ExpectedAllTeamsFilledCount = 36;
        [TestMethod()]
        public void GetAllTeamsFilledTest()
        {
            IList<Team> allTeams = RequestHelper.GetAllTeams();
            Assert.AreEqual(ExpectedAllTeamsFilledCount, allTeams.Count);
        }

        private int ExpectedGamesEmptyCount = 0;
        [TestMethod()]
        public void GetGamesEmptyTest()
        {
            IList<Game> games = RequestHelper.GetGames("");
            Assert.AreEqual(ExpectedGamesEmptyCount, games.Count);
        }

        private int ExpectedGamesFilledCount = 7;
        [TestMethod()]
        public void GetGamesFilledTest()
        {
            IList<Game> games = RequestHelper.GetGames("2020-01-14");
            Assert.AreEqual(ExpectedGamesFilledCount, games.Count);
        }
    }
}