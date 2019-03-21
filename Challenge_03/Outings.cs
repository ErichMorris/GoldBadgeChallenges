using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public enum EventType
    {
        Golf, Bowling, AmusementPark, Concert
    }
    public class Outings
    {
        public EventType TypeOfEvent { get; set; }
        public int NumberOfAttendees { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal EventTotalCost { get; set; }

        public Outings() { }

        public Outings(int numberOfAttendees, DateTime date, decimal costPerPerson, decimal eventTotalCost, EventType typeOfEvent)
        {
            NumberOfAttendees = numberOfAttendees;
            Date = date;
            CostPerPerson = costPerPerson;
            EventTotalCost = eventTotalCost;
            TypeOfEvent = typeOfEvent;
        }
    }
}
