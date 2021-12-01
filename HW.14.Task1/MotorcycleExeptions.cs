using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW._13.Task2
{
    class MotorcycleExeptions : Exception
    {
        public MotorcycleExeptions() 
        { 
        }
        public MotorcycleExeptions(string? message) : base(message)
        {
        }
        public MotorcycleExeptions(string? message, Exception? exception) : base(message, exception) 
        { 
        }
        protected MotorcycleExeptions(SerializationInfo info, StreamingContext contex) : base(info, contex) 
        { 
        }
    }
}
