using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance_Repository
{

    public class TeamRepository
    {
        List<Team> _teamsOfDevsList = new List<Team>();

        public void CreateNewTeam(List<Developer> devList, string teamName, string teamID)
        {
            Team newTeam = new Team(devList, teamName, teamID);
        }

        public void CreateNewTeam(string teamName, string teamID)
        {
            Team newTeam = new Team(teamName, teamID);
        }

        public void CreateNewTeam()
        {
            Team newTeam = new Team();
        }

        public void GetTeamByTeamID()
        {

        }

        public void DeleteTeamByTeamID()
        {

        }
    }
}
