using CafeProgram.Model;
using System;

namespace CafeProgram
{
    public class CafeRepository
    {
        private Menu Menu { get; set; } = new Menu();

        public bool AddMenuItems(MenuItem menuItem)
        {
            ValidateMenuItem(menuItem);
            Menu.MenuItems.Add(menuItem);
            return true;
        }

        public bool DeleteMenuItem(int menuItemId)
        {
            var menuItem = FindMenuItem(menuItemId);
            Menu.MenuItems.Remove(menuItem);
            return true;
        }

        public bool EditMenuItem(MenuItem menuItem)
        {
            var item = FindMenuItem(menuItem.MealNumber);
            item.MealDescription = menuItem.MealDescription;
            item.MealIngredients = menuItem.MealIngredients;
            item.MealName = menuItem.MealName;
            item.MealPrice = menuItem.MealPrice;
            return true;
        }

        public Menu GetMenu() => Menu;

        private MenuItem FindMenuItem(int menuItemId)
        {
            foreach (var menuItem in Menu.MenuItems)
            {
                if (menuItem.MealNumber == menuItemId)
                {
                    return menuItem;
                }
            }

            throw new ArgumentNullException("Could not find the Menu Item with the ID of " + menuItemId);
        }

        private void ValidateMenuItem(MenuItem menuItem)
        {
            if (string.IsNullOrEmpty(menuItem.MealDescription))
            {
                throw new ArgumentNullException("The meal description cannot be null or empty");
            }

            if (string.IsNullOrEmpty(menuItem.MealName))
            {
                throw new ArgumentNullException("The meal name cannot be null or empty");
            }

            foreach (var item in Menu.MenuItems)
            {
                if (item.MealNumber == menuItem.MealNumber)
                {
                    throw new ArgumentException("This meal item already exists");
                }
            }
        }
    }
}
