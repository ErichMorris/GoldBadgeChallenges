using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public class ProgramUI
    {
        private ClaimRepository _claimRepo = new ClaimRepository();
        
        
        public void Run()
        {
            _claimRepo.AddClaimToQueue(new Claim("1", "Car Accident on 465", 400, "04", "25", "2018", DateTime.Now, "4/25/18", true));
            _claimRepo.AddClaimToQueue(new Claim("2", "House Fire in kitchen", 4000, "04", "26", "2018", DateTime.Now, "4/26/18", true));
            _claimRepo.AddClaimToQueue(new Claim("3", "Stolen Pancakes", 4, "04", "27", "2018", DateTime.Now, "4/27/18", true));
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu: \n" +
                    "1. See all claims: \n" +
                    "2. Take care of next claim: \n" +
                    "3. Enter a new claim: \n" +
                    "4. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:
                        SeeAllClaims();
                        break;
                    case 2:
                        TakeCareOfNextClaim();
                        break;
                    case 3:
                        EnterNewClaim();
                        break;
                }
            }
        }

        private void EnterNewClaim()
        {
            Claim newClaim = new Claim();

            //ClaimID
            Console.Clear();
            Console.WriteLine("Please enter the Claim ID");
            newClaim.ClaimID = Console.ReadLine();



            //ClaimType
            Console.Clear();
            Console.WriteLine("What type of claim is this? \n" +
                "1. Car \n" +
                "2. Home \n" +
                "3. Theft");
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

            if (input == 1)
            {
                newClaim.TypeOfClaim = ClaimType.Car;
            }
            else if (input == 2)
            {
                newClaim.TypeOfClaim = ClaimType.Home;
            }
            else if (input == 3)
            {
                newClaim.TypeOfClaim = ClaimType.Theft;
            }
            else
            {
                Console.WriteLine("Please enter the number of the option that you'd like to choose.");
            }

            //Description
            Console.Clear();
            Console.WriteLine("Please enter a brief claim description");
            newClaim.Description = Console.ReadLine();

            //ClaimAmount
            Console.Clear();
            Console.WriteLine("Please enter the dollar amount of the claim. (do not include dollar sign)");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

            //DateOfIncident
            Console.Clear();
            Console.WriteLine("Please enter the month of the incident as a number. \n" +
                "example: January = 01, February = 02, etc.");
            newClaim.MonthOfIncident = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter the day of the incident (01-31)");
            newClaim.DayOfIncident = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter the year of the incident. \n" +
                "example: 2012");


            newClaim.DateOfIncident = $"{newClaim.MonthOfIncident}/{newClaim.DayOfIncident}/{newClaim.YearOfIncident}";

            //DateOfClaim
            newClaim.DateOfClaim = DateTime.Now;

            //IsValid
            Console.Clear();
            Console.WriteLine("Is this a valid claim? y/n");
            string answerKey = Console.ReadLine().ToLower();
            if (answerKey == "y")
            {
                newClaim.IsValid = true;
            }
            else if (answerKey == "n")
            {
                newClaim.IsValid = false;
            }
            else
            {
                Console.WriteLine("Please enter either y or n");
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey();
            }
            _claimRepo.AddClaimToQueue(newClaim);
        }

        private void SeeAllClaims()
        {
            IEnumerable<Claim> claimsData = _claimRepo.GetClaims().AsEnumerable<Claim>();
            Console.Clear();
            Console.WriteLine($"ClaimID     ClaimType     Description     ClaimAmount     DateOfIncident     DateOfClaim     IsValid");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
           
            foreach (Claim claim in claimsData)
            {
                Console.WriteLine($"{claim.ClaimID,-15} {claim.TypeOfClaim, -10} {claim.Description, -15}  ${claim.ClaimAmount, -15}{claim.DateOfIncident, -15} {claim.DateOfClaim, -15} {claim.IsValid, -15}");
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
        private void TakeCareOfNextClaim()
        {
            Claim NextClaim = _claimRepo.GetClaims().Peek();
            Console.WriteLine("Here are the details for the next claim to be handled.");
            Console.WriteLine("Claim ID: {0}", NextClaim.ClaimID);
            Console.WriteLine("Type: {0}", NextClaim.TypeOfClaim);
            Console.WriteLine("Description: {0}", NextClaim.Description);
            Console.WriteLine("Amount: {0:C}", NextClaim.ClaimAmount);
            Console.WriteLine("Date of Accident: {0:MM/dd/yy}", NextClaim.DateOfIncident);
            Console.WriteLine("Date of Claim: {0:MM/dd/yy}", NextClaim.DateOfClaim);
            Console.WriteLine("Is it Valid?: {0}", NextClaim.IsValid);

            Console.WriteLine("Do you want to deal with this claim now\n" +
                "Y OR\n" +
                "N.");
            string TakeNextClaim = Console.ReadLine();
            if (TakeNextClaim.ToUpper() == "Y")
            {
                _claimRepo.GetNextClaim();
            }
        }

    }

        
    }

