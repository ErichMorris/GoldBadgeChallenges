using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class ProgramUI
    {
        private OutingRepository _outingRepo = new OutingRepository();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu: \n" +
                    "1. Show all outings \n" +
                    "2. Add outing to list \n" +
                    "3. See individual outing type costs \n" +
                    "4. See combined cost for all outings \n" +
                    "5. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:
                        ShowAllOutings();
                        break;
                    case 2:
                        AddOutingToList();
                        break;
                    case 3:
                        SeeIndividualOutingTypeCosts();
                        break;
                    case 4:
                        SeeCombinedCostsForAllOutings();
                        break;
                    case 5:
                        running = false;
                        break;
                }
            }
        }
        private void ShowAllOutings()
        {
            Console.Clear();
            List<Outings> outing = _outingRepo.GetOutingList();
            Console.WriteLine("Event Type    Attendees    Cost Per Person    Date");
            foreach (Outings outings in outing)
            {
                Console.WriteLine($"{outings.TypeOfEvent, -10} {outings.NumberOfAttendees, -10} {outings.CostPerPerson, -10} {outings.Date, -10}");
            }
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
        private void AddOutingToList()
        {
            Outings newOuting = new Outings();

            Console.Clear();
            Console.WriteLine("Choose the type of event you would like to add: \n" +
                "1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusement Park \n" +
                "4. Concert");
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            switch (input)
            {
                case 1:
                    newOuting.TypeOfEvent = EventType.Golf;
                    break;
                case 2:
                    newOuting.TypeOfEvent = EventType.Bowling;
                    break;
                case 3:
                    newOuting.TypeOfEvent = EventType.AmusementPark;
                    break;
                case 4:
                    newOuting.TypeOfEvent = EventType.Concert;
                    break;
            }
            Console.Clear();
            Console.WriteLine("Please enter how many people attended this event: ");
            newOuting.NumberOfAttendees = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please enter the cost per attendee: ");
            newOuting.CostPerPerson = decimal.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please enter the date of the event: (example: 01/02/18)");
            newOuting.Date = DateTime.Parse(Console.ReadLine());
            _outingRepo.AddOutingToList(newOuting);
        }
        private void SeeIndividualOutingTypeCosts()
        {
            List<Outings> outing = _outingRepo.GetOutingList();
            decimal golf = 100m;
            decimal bowling = 200m;
            decimal amusementPark = 300m;
            decimal concert = 400m;
            Console.WriteLine("Choose an event type to see it's individual cost: ");
            Console.WriteLine("1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusement Park \n" +
                "4. Concert");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    foreach (Outings outings in outing)
                    {
                        if (outings.TypeOfEvent == EventType.Golf)
                        {
                            golf += outings.CostPerPerson * outings.NumberOfAttendees;
                            Console.WriteLine($"Price per event for golf: {golf}");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 2:
                    foreach (Outings outings in outing)
                    {
                        if (outings.TypeOfEvent == EventType.Bowling)
                        {
                            bowling += outings.CostPerPerson * outings.NumberOfAttendees;
                            Console.WriteLine($"Price per event for bowling: {bowling}");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 3:
                    foreach (Outings outings in outing)
                    {
                        if (outings.TypeOfEvent == EventType.AmusementPark)
                        {
                            amusementPark += outings.CostPerPerson * outings.NumberOfAttendees;
                            Console.WriteLine($"Price per event for amusement park: {amusementPark}");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 4: 
                    foreach (Outings outings in outing)
                    {
                        if (outings.TypeOfEvent == EventType.Concert)
                        {
                            concert += outings.CostPerPerson * outings.NumberOfAttendees;
                            Console.WriteLine($"Price per event for concert: {concert}");
                            Console.ReadLine();
                        }
                    }
                    break;
            }
        }
        private void SeeCombinedCostsForAllOutings()
        {
            decimal combinedCost = 0m;
            List<Outings> outing = _outingRepo.GetOutingList();
            foreach (Outings outings in outing)
            {
                combinedCost += outings.CostPerPerson * outings.NumberOfAttendees;
                Console.WriteLine($"Combined cost: {combinedCost}");
                Console.ReadLine();
            }
        }
    }
}
