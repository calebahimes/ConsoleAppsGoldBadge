using System;
using CafeProgram;
using CafeProgram.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleChallengeTests
{
    [TestClass]
    public class CafeTest
    {
        [TestMethod]
        public void AddToMenu_ShouldGetCorrectBoolean()
        {
            Menu content = new Menu();
            MenuItem menuContent = new MenuItem();
            CafeRepository repository = new CafeRepository();

            bool addResult = repository.AddMenuItems(menuContent);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void UpdateExistingMenu_ShouldReturnTrue()
        {
            Menu content = new Menu();
            MenuItem menuContent = new MenuItem();
            CafeRepository repository = new CafeRepository();
            bool updateResults = repository.EditMenuItem(menuContent);
            Assert.IsTrue(updateResults);
        }

        [TestMethod]
        public void DeleteExistingMenu_ShouldReturnTrue()
        {
            Menu content = new Menu();
            MenuItem menuContent = new MenuItem();
            CafeRepository repository = new CafeRepository();
            bool removeResult = repository.DeleteMenuItem(menuContent.MealNumber);
            Assert.IsTrue(removeResult);
        }
    }
}
