using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLog4Net
{
    class Test
    {
         public void testMethod()
        {
            string ex = "Test Method exception";
            Log4Net.L4Method(ex);
        }

    }
}
