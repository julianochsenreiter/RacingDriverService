using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RacingDriverService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRacingService" in both code and config file together.
    [ServiceContract]
    public interface IRacingService
    {
        [OperationContract]
        string GetTime(string team);

        [OperationContract]
        TeamInfo GetTeamInfo(string team);
    }
}
