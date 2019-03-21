using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class OutingRepository
    {
        private List<Outings> _outingList;

        public OutingRepository()
        {
            _outingList = new List<Outings>();
        }

        public void AddOutingToList(Outings newOuting)
        {
            _outingList.Add(newOuting);
        }

        public List <Outings> GetOutingList()
        {
            return _outingList;
        }
    }
}
