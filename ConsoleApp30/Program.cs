using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        string carmodel;
        int ceryear;
        int carcompy;
        public Program(string model,int year,int compy)
        {
            carmodel = model;
            ceryear = year;
            carcompy = compy;



            
        }
        static void Main(string[] args)
        {
            Program obj = new Program("bmw",1990,1947);
            Console.WriteLine(obj.carmodel);
            Console.WriteLine(obj.ceryear);
            Console.WriteLine(obj.carcompy);
     
            Console.ReadLine();
        }
    }
}
