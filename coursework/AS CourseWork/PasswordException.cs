using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_CourseWork
{
    internal class PasswordException: Exception
    {
        
        public PasswordException()
        {
            
        }

        public PasswordException(string message) : base(message)
        {
        }
    }
}
