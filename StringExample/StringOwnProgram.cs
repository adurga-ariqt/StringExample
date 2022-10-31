using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    internal class StringOwnProgram
    {
        static void  Method1()
        {
            string sname = "durga";
            string pname = "Bhavani";
            string name = sname + pname;
            Console.WriteLine(name + " " + "/nlength of the string :" + name.Length + " " + name[0]);
        }
        static void Method2(string fname = "durga", string zname = "bhavani")
        {
            Console.WriteLine(fname + zname + "Anaparthi");
        
        }
        static void Main(string[] args)
        {
            Method1();
            Method2( "jenny","chinni");
            Method2(zname:"nikhil");
            Console.ReadLine();
        }
    }
}
