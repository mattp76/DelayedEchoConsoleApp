using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayedEchoConsoleApp.Helpers
{
    public static class StringHelper
    {
        public static string GetMessage(string dateTime, String message)
        {
            var str = String.Format("{0} : {1}", dateTime, message);
            return str;
        }
    }
}
