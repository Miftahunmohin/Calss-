using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpBrack
{
    class Program
    {
        static void Main(string[] args)
        {
      


            //////string[] items = new string[] {"C#", "Visual Basic", 
            //////"Java", "Perl"};
          
        

            //string removes = "";
            //if (_Ipk.Length < 16)
            //{
            //    removes = _Ipk.Remove(_Ipk.Length - 3);
            //}
            //else if (_Ipk.Length < 15)
            //{
            //    removes = _Ipk.Remove(_Ipk.Length - 2);
            //}
            //if (_Ipk.Length < 14)
            //{
            //    removes = _Ipk.Remove(_Ipk.Length - 1);
            //}

            Console.WriteLine("please Enter your IP Address:");
            string _Ipk = Console.ReadLine();

            Console.WriteLine("please Enter your Netmask");
            double divaided = Convert.ToDouble(Console.ReadLine());

            if(divaided==30){
                divaided = 4;
            }
            else if(divaided==29){
                divaided = 8;
            }
            else if (divaided == 28)
            {
                divaided = 16;
            }
            else if (divaided == 27)
            {
                divaided = 32;
            }
            else if (divaided == 26)
            {
                divaided = 64;
            }
            else if (divaided == 25)
            {
                divaided = 128;
            }
            else if (divaided == 24)
            {
                divaided = 256;
            }

            string[] elemantId = _Ipk.Split('.');
          string _workId = elemantId[3];

          //  Console.WriteLine("it is langs foreach:" + _workId);
            getipadress(divaided, _workId, _Ipk);
            Console.ReadLine();
        }
        public static void getipadress(double divaided, string _workId, string _Ipk)
        {
            double result = 0;
            double finalResult = 0;
            double _workIdIs = Convert.ToDouble(_workId);
            for (double i = 0; i <= _workIdIs; i++)
            {

                result = i * divaided;
                if (result <= _workIdIs)
                {
                    finalResult = result;
                }
            }
            string subnet=Convert.ToString(256-divaided);

            double hostMin     =(finalResult+1);
            double otherId     =(finalResult + divaided);
            double broadCastId =(otherId -1);
            double hostMax     =(broadCastId -1);



          //  string hostMin= _Ipk.Replace(_workId, Convert.ToString(finalResult + 1));
            string k=(_Ipk.Replace(_workId, Convert.ToString(finalResult))).ToString();

            Console.WriteLine("Network Address:" + k); 
            Console.WriteLine("subnet id: 255.255.255." + subnet);
            Console.WriteLine("hostMin id:" +     (_Ipk.Replace(_workId, Convert.ToString(hostMin))).ToString());
            Console.WriteLine("hostMax id:" +     (_Ipk.Replace(_workId, Convert.ToString(hostMax))).ToString());
            Console.WriteLine("broadCastId id:" + (_Ipk.Replace(_workId, Convert.ToString(broadCastId))).ToString());
            Console.WriteLine("Other Net id:" +   (_Ipk.Replace(_workId, Convert.ToString(otherId)).ToString()));
         //   Console.WriteLine(_Ipsd);
        }
    }
}
 