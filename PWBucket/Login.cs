using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWBucket
{
    class Login
    {
        public static bool login(string eingabe)
        {
            return pwCheck(eingabe);
        }
        static private bool pwCheck(string eingabe)
        {
            string testPW = "Test123";
            if(testPW.Equals(eingabe))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
