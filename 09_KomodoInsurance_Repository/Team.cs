using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance_Repository
{
    public class Team
    {
        public List<Developer> DevList { get; set; }
        public string TeamName { get; set; }
        public string TeamID { get; set; }

        public Team(List<Developer> devList, string teamName, string teamID)
        {
            DevList = devList;
            TeamName = teamName;
            TeamID = teamID;
        }

        public Team(string teamName, string teamID)
        {
            TeamName = teamName;
            TeamID = teamID;
        }

        public Team()
        {

        }
    }
}
