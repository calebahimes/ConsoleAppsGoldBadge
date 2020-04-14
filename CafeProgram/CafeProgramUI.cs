using CafeProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public static class CafeProgramUI
    {
        private static CafeRepository _cafeRepository = new CafeRepository();

        public static void Run()
        {
            var continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                var userInput = PromptUser("Please select an option from the menu!\n" +
                    "1. Display Menu Items\n" +
                    "2. Add a Menu Item\n" +
                    "3. Edit a Menu Item\n" +
                    "4. Delete a Menu Item");
                switch (userInput)
                {
                    case "1":
                        DisplayMenu();
                        break;
                    case "2":
                        AddMenuItem();
                        break;
                    case "3":
                        EditMenuItem();
                        break;
                    case "4":
                        DeleteMenuItem();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void DeleteMenuItem()
        {
            var itemId = PromptUser("Please enter the ID of the item you wish to delete.");
            _cafeRepository.DeleteMenuItem(int.Parse(itemId));
        }

        private static void EditMenuItem()
        {
            var mealIngredients = new List<MealIngredients>();
            var itemId = PromptUser("Please enter the ID of the item you would like to edit.");
            var mealName = PromptUser("Please enter a new Meal Name.");
            var mealDescription = PromptUser("Please enter a new Description");
            var mealPrice = PromptUser("Please enter a new Price");

            var enteringIngredients = true;
            while (enteringIngredients)
            {
                var ingredients = PromptUser("Please enter a meal ingredient\n" +
                    "1.) Lettuce\n" +
                    "2.) Tomato\n" +
                    "3.) Cheese\n" +
                    "4.) Onion\n" +
                    "5.) Ketchup\n" +
                    "6.) Mayonnaise\n" +
                    "7.) No more");

                switch (ingredients)
                {
                    case "1":
                        if (mealIngredients.Contains(MealIngredients.Lettuce))
                        {
                            Console.WriteLine("You already have Lettuce");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Lettuce);
                        }
                        break;
                    case "2":
                        if (mealIngredients.Contains(MealIngredients.Tomato))
                        {
                            Console.WriteLine("You already have Tomato");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Tomato);
                        }
                        break;
                    case "3":
                        if (mealIngredients.Contains(MealIngredients.Cheese))
                        {
                            Console.WriteLine("You already have Cheese");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Cheese);
                        }
                        break;
                    case "4":
                        if (mealIngredients.Contains(MealIngredients.Onion))
                        {
                            Console.WriteLine("You already have Onion");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Onion);
                        }
                        break;
                    case "5":
                        if (mealIngredients.Contains(MealIngredients.Ketchup))
                        {
                            Console.WriteLine("You already have Ketchup");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Ketchup);
                        }
                        break;
                    case "6":
                        if (mealIngredients.Contains(MealIngredients.Mayonnaise))
                        {
                            Console.WriteLine("You already have Mayonnaise");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Mayonnaise);
                        }
                        break;
                    case "7":
                        enteringIngredients = false;
                        break;
                    default:
                        throw new ArgumentException("That ingredient does not exist");
                }
            }
            _cafeRepository.EditMenuItem(new MenuItem
            {
                MealNumber = int.Parse(itemId),
                MealName = mealName,
                MealDescription = mealDescription,
                MealIngredients = mealIngredients,
                MealPrice = decimal.Parse(mealPrice)
            }); ;
        }

        private static void AddMenuItem()
        {
            var mealIngredients = new List<MealIngredients>();
            var mealId = PromptUser("Please enter a Meal Id");
            var mealName = PromptUser("Please enter a Meal Name");

            var enteringIngredients = true;
            while (enteringIngredients)
            {
                var ingredients = PromptUser("Please enter a meal ingredient\n" +
                    "1.) Lettuce\n" +
                    "2.) Tomato\n" +
                    "3.) Cheese\n" +
                    "4.) Onion\n" +
                    "5.) Ketchup\n" +
                    "6.) Mayonnaise\n" +
                    "7.) No more");

                switch (ingredients)
                {
                    case "1":
                        if (mealIngredients.Contains(MealIngredients.Lettuce))
                        {
                            Console.WriteLine("You already have Lettuce");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Lettuce);
                        }
                        break;
                    case "2":
                        if (mealIngredients.Contains(MealIngredients.Tomato))
                        {
                            Console.WriteLine("You already have Tomato");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Tomato);
                        }
                        break;
                    case "3":
                        if (mealIngredients.Contains(MealIngredients.Cheese))
                        {
                            Console.WriteLine("You already have Cheese");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Cheese);
                        }
                        break;
                    case "4":
                        if (mealIngredients.Contains(MealIngredients.Onion))
                        {
                            Console.WriteLine("You already have Onion");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Onion);
                        }
                        break;
                    case "5":
                        if (mealIngredients.Contains(MealIngredients.Ketchup))
                        {
                            Console.WriteLine("You already have Ketchup");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Ketchup);
                        }
                        break;
                    case "6":
                        if (mealIngredients.Contains(MealIngredients.Mayonnaise))
                        {
                            Console.WriteLine("You already have Mayonnaise");
                        }
                        else
                        {
                            mealIngredients.Add(MealIngredients.Mayonnaise);
                        }
                        break;
                    case "7":
                        enteringIngredients = false;
                        break;
                    default:
                        throw new ArgumentException("That ingredient does not exist");
                }
            }

            var mealDescription = PromptUser("Please enter a Meal Description");
            var mealPrice = PromptUser("Please enter a Meal Price");

            _cafeRepository.AddMenuItems(new MenuItem
            {
                MealNumber = int.Parse(mealId),
                MealName = mealName,
                MealDescription = mealDescription,
                MealPrice = decimal.Parse(mealPrice),
                MealIngredients = mealIngredients
            });
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            foreach (var item in _cafeRepository.GetMenu().MenuItems)
            {
                Console.WriteLine(item.MealNumber);
                Console.WriteLine(item.MealName);
                Console.WriteLine(item.MealDescription);
                foreach (var ingredient in item.MealIngredients)
                {
                    Console.WriteLine(ingredient);
                }
                Console.WriteLine(item.MealPrice);
            }
            Console.ReadKey();
        }

        private static string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
