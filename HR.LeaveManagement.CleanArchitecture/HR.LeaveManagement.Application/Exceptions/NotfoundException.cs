using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class NotfoundException : Exception
    {
        public NotfoundException(string name, object key) : base($"{name} ({key}) was not found")
        {
            
        }
    }
}
