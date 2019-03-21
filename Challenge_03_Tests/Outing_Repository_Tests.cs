using System;
using Challenge_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_03_Tests
{
    [TestClass]
    public class Outing_Repository_Tests
    {
        private OutingRepository _outingRepo;
        [TestMethod]
        public void TestAddClaimToQueue()
        {
            Outings outings = new Outings();
            _outingRepo = new OutingRepository();

            _outingRepo.AddOutingToList(outings);

            int expected = 1;
            int actual = _outingRepo.GetOutingList().Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
