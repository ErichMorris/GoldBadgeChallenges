using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public enum ClaimType
    {
        Car, Home, Theft
    }
    public class Claim
    {
        public string ClaimID { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public string MonthOfIncident { get; set; }
        public string DayOfIncident { get; set; }
        public string YearOfIncident { get; set; }
        public string DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public ClaimType TypeOfClaim { get; set; }

        public Claim() { }

        public Claim(string claimID, string description, decimal claimAmount, string monthOfIncident, string dayOfIncident, string yearOfIncident, DateTime dateOfClaim, string dateOfIncident, bool isValid)
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            MonthOfIncident = monthOfIncident;
            DayOfIncident = dayOfIncident;
            YearOfIncident = yearOfIncident;
            DateOfClaim = dateOfClaim;
            DateOfIncident = dateOfIncident;
            IsValid = isValid;
        }
    }
}
