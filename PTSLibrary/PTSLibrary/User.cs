using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PTSLibrary
{
    [Serializable]
   public class User
    {
        protected String name;
        protected int id;

        public String Name
        {
            get { return name; }
        }
        public int Id
        {
            get { return id; }
        }
    }
}