using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RacingDriverService
{
    [DataContract]
    public class TeamInfo
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string BestDriver { get; set; }
        [DataMember]
        public int Points { get; set; }
    }
}
