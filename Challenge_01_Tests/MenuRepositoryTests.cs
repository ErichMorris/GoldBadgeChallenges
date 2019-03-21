using System;
using Challenge_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_01_Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _menuRepo = new MenuRepository();
        [TestMethod]
        public void MenuRepository_AddItemToMenu()
        {
            Menu menu = new Menu();
            _menuRepo.AddMenuToList(menu);

            var actual = _menuRepo.GetMenuList().Count;
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Menu_Repository_RemoveFromList()
        {
            Menu menu = new Menu();
            Menu _menu = new Menu();
            menu.MealNumber = "1";
            _menuRepo.AddMenuToList(menu);
            _menuRepo.AddMenuToList(_menu);
            _menuRepo.RemoveProductBySpecifications("1");
        }
        
    }
}
