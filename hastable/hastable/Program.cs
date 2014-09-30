using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_and_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("student", "nazmul,khadiza,badon,dipok,sukla");
            aHashtable.Add("family", "mukta,happy,rikta,azmal,nazmul");
            aHashtable.Add("relitionship", "momu,sima,nowrion,khadiza");
            // Console.WriteLine(aHashtable.ContainsKey("family"));
            //  Console.WriteLine(aHashtable.Contains("family"));
            //  Console.WriteLine(aHashtable.ContainsValue("nazmul,khadiza,badon,dipok,sukla"));
            foreach (var VARIABLE in aHashtable.Values)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadLine();
        }
    }
}
