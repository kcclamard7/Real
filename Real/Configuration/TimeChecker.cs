using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real.Configuration
{
    public class TimeChecker
    {
        
        public bool isRegularTime()
        {
           
            return  DateTime.Now.Hour  > 18;
        }
            
    }
}
