using System;
using Challenge_02_Retry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_02_Tests
{
    [TestClass]
    public class Claim_Repository_Tests
    {
        private ClaimRepository _claimRepo;
        [TestMethod]
        public void TestAddClaimToQueue()
        {
            Claim claims = new Claim();
            _claimRepo = new ClaimRepository();

            _claimRepo.AddClaimToQueue(claims);

            int expected = 1;
            int actual = _claimRepo.GetClaims().Count;

            Assert.AreEqual(expected, actual);

        }
    }
}
