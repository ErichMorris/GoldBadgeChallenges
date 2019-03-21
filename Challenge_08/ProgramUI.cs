using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_08
{
    public class ProgramUI
    {
        User newUser = new User();
        private UserRepository _userRepo = new UserRepository();
        public void Run()
        {
            decimal baseInsuranceCost = 150m;
            decimal newInsuranceCost = 0m;
            decimal penaltyCost = 25m;
            int timesSpeedLimit = 10;
            int timesSwerveLimit = 10;
            int timesRollStopSignLimit = 10;
            int timesFollowToCloselyLimit = 10;
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello, please answer the following questions to get your insurance rate: ");
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Please enter your name: ");
                newUser.Name = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("How many times have you sped this month?");
                newUser.SpeedCount = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("How many times have you swerved out of your lane this month?");
                newUser.SwerveCount = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("How many times have you rolled through a stop sign this month?");
                newUser.StopSignRollCount = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("How many times have you followed to closely this month?");
                newUser.StopSignRollCount = int.Parse(Console.ReadLine());

                _userRepo.AddUserToList(newUser);

                if (newUser.SpeedCount > timesSpeedLimit)
                {
                    newInsuranceCost += baseInsuranceCost + penaltyCost;
                }
                else
                {
                    newInsuranceCost = baseInsuranceCost;
                }

                if (newUser.SwerveCount > timesSwerveLimit)
                {
                    newInsuranceCost += baseInsuranceCost + penaltyCost;
                }
                else
                {
                    newInsuranceCost += baseInsuranceCost;
                }

                if (newUser.StopSignRollCount > timesRollStopSignLimit)
                {
                    newInsuranceCost += baseInsuranceCost + penaltyCost;
                }
                else
                {
                    newInsuranceCost += baseInsuranceCost;
                }

                if (newUser.FollowTooCLosely > timesFollowToCloselyLimit)
                {
                    newInsuranceCost += baseInsuranceCost + penaltyCost;
                }
                else
                {
                    newInsuranceCost += baseInsuranceCost;
                }
                Console.Clear();
                Console.WriteLine($"The cost of your adjusted insurance is {newInsuranceCost}");
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey();
            }
        }
    }
}
