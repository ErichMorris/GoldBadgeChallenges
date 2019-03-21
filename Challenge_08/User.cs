using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_08
{
    public class User
    {
        public string Name { get; set; }
        public int SpeedCount { get; set; }
        public int SwerveCount { get; set; }
        public int StopSignRollCount { get; set; }
        public int FollowTooCLosely { get; set; }

        public User() { }

        public User(string name, int speedCount, int swerveCount, int stopSignRollCount, int followTooClosely)
        {
            name = Name;
            speedCount = SpeedCount;
            swerveCount = SwerveCount;
            stopSignRollCount = StopSignRollCount;
            followTooClosely = FollowTooCLosely;
        }
    }
}
