using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialConnect
{
    public class SensorBean
    {
        public  static String _315 = "21";
        public  static String _433 = "32";
        public  static String _雙頻 = "54";
        public Boolean result = false;
        public String id = "";
        public String boot_var = _雙頻;
        public Boolean canPr = false;
    }
}
