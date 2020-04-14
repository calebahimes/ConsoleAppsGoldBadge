using ClaimsProgram.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsProgram
{
    public class ClaimsRepository
    {
        protected readonly Queue<Claim> _claims = new Queue<Claim>();

        public bool AddClaim(Claim newClaim)
        {
            _claims.Enqueue(newClaim);
            return true;
        }

        public Queue<Claim> GetClaims()
        {
            return _claims;
        }

        public bool GetNextClaim()
        {
            _claims.Dequeue();
            return true;
        }
    }
}
