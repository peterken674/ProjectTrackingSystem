using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    [Serializable]
    public class Team
    {
        public Team() { }
        private int id;
        private String location;
        private String name;
        private TeamLeader leader;

        public int TeamId
        {
            get { return id; }
            set { id = value; }
        }
        public TeamLeader Leader
        {
            get { return leader; }
            set { leader = value; }
        }
        public String Location
        {
            get { return location; }
            set { location = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Team(int id, String location, String name, TeamLeader leader)
        {
            this.location = location;
            this.name = name;
            this.id = id;
            this.leader = leader;
        }
    }
}


