using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    public class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu: \n" +
                    "1. Add a new menu item: \n" +
                    "2. Remove the last entry: \n" +
                    "3. View menu \n" +
                    "4. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:
                        AddMenuItem();
                        break;
                    case 2:
                        RemoveMenuItem();
                        break;
                    case 3:
                        ViewInformation();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void AddMenuItem()
        {
            
            Menu newMenu = new Menu();

            Console.Clear();
            Console.WriteLine("Please enter the menu item number:");
            newMenu.MealNumber = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter the menu item's name:");
            newMenu.MealName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter a brief description of the menu item:");
            newMenu.MealDescription = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter the item's ingredients:");
            newMenu.MealIngredients = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter price:");
            newMenu.MealPrice = int.Parse(Console.ReadLine());

            _menuRepo.AddMenuToList(newMenu);
        }

        private void RemoveMenuItem()
        {
            Menu newMenu = new Menu();
            Console.Clear();
            Console.WriteLine($"Item Number     Item Name     Description     Ingredients   Price");
            Console.WriteLine("-------------------------------------------------------------------");
            List<Menu> menus = _menuRepo.GetMenuList();
            foreach (Menu menu in menus)
            {
                Console.WriteLine($"{menu.MealNumber,-15}{menu.MealName,-15}{menu.MealDescription,-15}{menu.MealIngredients,-15}{menu.MealPrice,-15}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Which item would you like to remove?");
            Console.WriteLine("1");
            string deletePrompt = Console.ReadLine();
           
            
                _menuRepo.RemoveProductBySpecifications(deletePrompt);
                Console.Clear();
                Console.WriteLine($"Item Number     Item Name     Description     Ingredients   Price");
                Console.WriteLine("-------------------------------------------------------------------");
                foreach (Menu menu in menus)
                {
                    Console.WriteLine($"{menu.MealNumber,-15}{menu.MealName,-15}{menu.MealDescription,-15}{menu.MealIngredients,-15}{menu.MealPrice,-15}");
                }
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();

            
            
            
                
            
            
        }

        private void ViewInformation()
        {
            Console.Clear();
            Console.WriteLine($"Item Number     Item Name     Description     Ingredients   Price");
            Console.WriteLine("-------------------------------------------------------------------");
            List<Menu> menus = _menuRepo.GetMenuList();
            foreach (Menu menu in menus)
            {
                Console.WriteLine($"{menu.MealNumber,-15}{menu.MealName,-15}{menu.MealDescription,-15}{menu.MealIngredients,-15}{menu.MealPrice,-15}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
