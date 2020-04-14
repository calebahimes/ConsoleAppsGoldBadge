using System;
using ClaimsProgram;
using ClaimsProgram.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleChallengeTests
{
    [TestClass]
    public class ClaimsTest
    {
        [TestMethod]
        public void AddToMenu_ShouldGetCorrectBoolean()
        {
            Claim content = new Claim();
            ClaimsRepository repository = new ClaimsRepository();

            bool addResult = repository.AddClaim(content);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void UpdateExistingMenu_ShouldReturnTrue()
        {
            Claim content = new Claim();
            ClaimsRepository repository = new ClaimsRepository();
            bool updateResults = repository.GetNextClaim();
            Assert.IsTrue(updateResults);
        }
    }
}
