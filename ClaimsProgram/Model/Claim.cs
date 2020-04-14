using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProgram.Model
{
    public enum ClaimType
    {
        Car,
        Home,
        Theft
    } 
    public class Claim
    {
        public int ClaimID { get; set; }

        public ClaimType TypeOfClaim { get; set; }

        public string ClaimDescription { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public int DaysPassed
        {
            get
            {
                TimeSpan daysSinceIncident = DateOfClaim - DateOfIncident;
                double days = daysSinceIncident.TotalDays;
                double totalDays = Math.Floor(days);
                int claimSpan = Convert.ToInt32(totalDays);
                return claimSpan;
            }
        }

        public bool IsValid
        {
            get
            {
                if (DaysPassed <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
