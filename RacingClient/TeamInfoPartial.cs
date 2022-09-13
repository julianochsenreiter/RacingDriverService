using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingClient.RacingDriverServiceRef
{
    public partial class TeamInfo
    {
        public override string ToString()
        {
            return $"{Name} has {Points} points and its best driver is {BestDriver}.";
        }
    }
}
