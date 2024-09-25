using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MyList
    {
        List<int> list = new List<int>();
        public MyList() { 
        }

        public void AddNumber(int num) {
            list.Add(num);
        }

        public void PrintNumbers(){
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void RandomNumbers()
        {
            Random rnd = new Random();
            list.Clear();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(100));
            }
        }
    }
}
