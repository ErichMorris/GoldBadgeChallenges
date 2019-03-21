using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public class ClaimRepository
    {
        private Queue <Claim> queue;
        public ClaimRepository()
        {
            queue = new Queue<Claim>();
        }
        public void AddClaimToQueue(Claim newClaim)
        {
            queue.Enqueue(newClaim);
        }
        public Claim GetNextClaim()
        {
            return queue.Dequeue();
        }
        public Queue<Claim> GetClaims()
        {
            return queue;
        }
    }
}
