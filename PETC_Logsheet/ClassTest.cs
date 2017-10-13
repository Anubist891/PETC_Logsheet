using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PETC_Logsheet
{
    class ClassTest
    {
        public string MyTest { get; set; }

        public string GetTest()
        {
            MyTest = "Testing";
            return MyTest;
        }
    }
}
