using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pb503_classwork
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions()
        {
            
        }
        public CustomExceptions(string ? message) : base(message) 
        {
            
        }
    }
}
