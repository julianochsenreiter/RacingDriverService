using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RacingDriverService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RacingService" in both code and config file together.
    public class RacingService : IRacingService
    {
        public TeamInfo GetTeamInfo(string team)
        {
            if (team.ToLower() == "ferrari")
            {
                return new TeamInfo
                {
                    Name = "Ferrari S.p.A.",
                    BestDriver = "Charles Leclerc",
                    Points = 406
                };
            }
            if (team.ToLower() == "redbull")
            {
                return new TeamInfo
                {
                    Name = "Red Bull Racing",
                    BestDriver = "Max Verstappen",
                    Points = 545
                };
            }
            if (team.ToLower() == "mercedes")
            {
                return new TeamInfo
                {
                    Name = "Mercedes AMG Petronas F1 Team",
                    BestDriver = "Lewis Hamilton",
                    Points = 371
                };
            }
            return null;
        }

        public string GetTime(string team)
        {
            if (team.ToLower() == "ferrari")
                return "1:20.161";
            if (team.ToLower() == "redbull")
                return "1:20.306";
            if (team.ToLower() == "mercedes")
                return "1:21.524";
            return null;
        }
    }
}
