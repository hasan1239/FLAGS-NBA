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
        private int ExpectedEmptyCount = 0;
        [TestMethod()]
        public void GetPlayersEmptyTest()
        {
            IList<Player> players = FLAGS_NBA.Model.RequestHelper.GetPlayers("");
            Assert.AreEqual(ExpectedEmptyCount, players.Count);
        }

        private int ExpectedFilledCount = 2;
        [TestMethod()]
        public void GetPlayersFilledTest()
        {
            IList<Player> players = FLAGS_NBA.Model.RequestHelper.GetPlayers("curry");
            Assert.AreEqual(ExpectedFilledCount, players.Count);
        }
    }
}