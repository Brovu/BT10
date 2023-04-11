using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            ListKr kr = new ListKr();
            kr.SortBy();
            //kr.remove();
            kr.output();
            Console.ReadKey();
        }
    }
}
