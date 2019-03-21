using System;
using Challenge_08;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_08_Tests
{
    [TestClass]
    public class User_Repository_Tests
    {
        private UserRepository _userRepo;
        [TestMethod]
        public void TestAddUserToList()
        {
            User users = new User();
            _userRepo = new UserRepository();

            _userRepo.AddUserToList(users);

            int expected = 1;
            int actual = _userRepo.GetUserList().Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
