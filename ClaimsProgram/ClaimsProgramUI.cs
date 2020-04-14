using ClaimsProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProgram
{
    public class ClaimsProgramUI
    {
        private readonly ClaimsRepository _claimsRepository = new ClaimsRepository();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Select an option number:\n" +
                    "1. Display all Claims\n" +
                    "2. Take Care of Next Claim\n" +
                    "3. Add a New Claim\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");

                switch (userInput)
                {
                    case "1":
                        ShowAllClaims();
                        break;
                    case "2":
                        ShowNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ShowAllClaims()
        {
            Console.Clear();

            Queue<Claim> claims = _claimsRepository.GetClaims();

            Console.WriteLine("ClaimID   ClaimType   ClaimDescription   ClaimAmount         DateOfIncident                  DateOfClaim                          IsValid");

            foreach (Claim claim in claims)
            {
                Console.WriteLine($"{claim.ClaimID}         {claim.TypeOfClaim}          {claim.ClaimDescription}                {claim.ClaimAmount}            {claim.DateOfIncident}             {claim.DateOfClaim}             {claim.IsValid}");
            }
            Console.WriteLine("\n\nPress any key to return to the Main Menu.");
            Console.ReadKey();
        }

        private void ShowNextClaim()
        {
            Console.Clear();
            Queue<Claim> nextClaim = _claimsRepository.GetClaims();
            foreach (Claim claim in nextClaim)
            {
                Console.WriteLine($"ClaimID: {claim.ClaimID}\n" +
                    $"Claim Type: {claim.TypeOfClaim}\n" +
                    $"Claim Description: {claim.ClaimDescription}\n" +
                    $"Claim Amount: {claim.ClaimAmount}\n" +
                    $"Date of Incident: {claim.DateOfIncident}\n" +
                    $"Date of Claim: {claim.DateOfClaim}\n" +
                    $"Claim is Valid?: {claim.IsValid}\n\n");
            }
            Console.WriteLine("Do you want to handle this Claim now? (Y/N)");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Y":
                    nextClaim.Dequeue();
                    Console.WriteLine("Your Claim has been handled.\n" +
                        "Please press any key to return to the Main Menu.");
                    Console.ReadKey();
                    break;
                case "y":
                    nextClaim.Dequeue();
                    Console.WriteLine("Your Claim has been handled.\n" +
                        "Please press any key to return to the Main Menu.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("You have not dealt with this Claim.\n" +
                        "Please press any Key to return to the Main Menu.");
                    Console.ReadKey();
                    break;
            }
        }

        private void AddNewClaim()
        {
            Console.Clear();
            Claim newClaim = new Claim();

            Console.WriteLine("Please enter a ClaimID.");
            newClaim.ClaimID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select a Claim Type.\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft\n");

            string claimTypeString = Console.ReadLine();
            switch (claimTypeString)
            {
                case "1":
                    newClaim.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;
                default:
                    Console.WriteLine("The selection you entered was invalid.\n" +
                        "Please press any key to return to the Main Menu.\n" +
                        "Your new Claim was not added.");
                    Console.ReadKey();
                    RunMenu();
                    break;
            }

            Console.WriteLine("Please enter a Claim Description.");
            newClaim.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Please enter the Claim Amount ($).");
            newClaim.ClaimAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the date of the incident. (Month/Day/Year Ex: 01/05/20)");
            newClaim.DateOfIncident = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please enter the date of the Claim. (Month/Day/Year Ex: 01/05/20)");
            newClaim.DateOfClaim = Convert.ToDateTime(Console.ReadLine());

            _claimsRepository.AddClaim(newClaim);
            Console.WriteLine("Your Claim has been added.\n" +
                "Please press any key to return to the Main Menu.");
            Console.ReadKey();

        }
    }
}
