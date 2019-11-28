using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        public List<TeamModel1> TeamMembers { get; set; } = new List<TeamModel1>();
        public string TeamName { get; set; }
    }
}
