using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class ArrayEx
    {
        public void arrayBuild (int num)
        {
            String[] arrayList = new string[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Please enter the client number " + (i+1));
                arrayList[i] = Console.ReadLine();
            }
            for(int x = 0; x < arrayList.Length; x++)
            {
                Console.WriteLine(" the name Client number  " + ( x+1 ) + " : "+ arrayList[x]);
            }
        }
       
    }
}
