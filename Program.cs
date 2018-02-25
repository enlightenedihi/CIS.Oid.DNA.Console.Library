using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.Oid.DNA.Console.Library
{
   
}

namespace NCE
{
    public interface IDNA               // 
    {
        int DNA();
    }

    public class Program : IDNA
    {
        static void Main(string[] args)
        {
        }

        public int DNA()
        {
            return 234;
        }
    }
}
