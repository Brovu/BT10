using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT10
{
    class KR : IComparable<KR>
    {
        String name;
        String gen;
        int power;


        public KR(String name = "", String gen = "", int power = 0) {
            this.name = name;
            this.gen = gen;
            this.power = power;
        }

        public void Xuat()
        {
            Console.WriteLine("Ten: {0}", name);
            Console.WriteLine("The he: {0}", gen);
            Console.WriteLine("Suc manh: {0}", power);
        }

        public int CompareTo(KR kr)
        {
            if (this.power < kr.power) return 1;
            else if (power == kr.power) return 0;
            else return -1;
        }
    } 

        class ListKr
        {
        List<KR> list = new List<KR>();
        public ListKr()
        {
            FileStream f = new FileStream("D:\\info.txt", FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(f);

            int n = int.Parse(rd.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = rd.ReadLine();
                string g = rd.ReadLine();
                int p = int.Parse(rd.ReadLine());
                KR kr = new KR(s, g, p);
                list.Add(kr);

            }
        }

        public void output()
        {
            foreach (KR kr in list)
            {
                kr.Xuat();
            }
        }

        public void remove()
        {
            list.RemoveAt(1);
        }

        public void SortBy()
        {
            list.Sort();
        }

    }

}
