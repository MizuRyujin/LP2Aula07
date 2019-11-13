using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public struct StcConcat
    {
        private string myStr;

        public StcConcat(string str)
        {
            myStr = str;
        }

        public void ConcatAndPrint(string text)
        {
            Console.WriteLine(text + myStr);
        }
    }
}
