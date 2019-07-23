using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    [Serializable]
   public class Task
    {
        public Task() { }

        private Guid taskId;
        private String name;
        private Status status;
        public string NameAndStatus
        {
            get { return name + "-" + status; }
            
        }
        public Guid TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Status theStatus
        {
            get { return status; }
            set { status = value; }
        }
        public Task(Guid taskId, String name, Status status)
        {
            this.taskId = taskId;
            this.name = name;
            this.status = status;

        }
    }
}