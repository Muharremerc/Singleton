using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonProjec;
using SingletonProjec.Model;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.getSingeltonEntitiy();
            var stList = singleton.getAllStudent();
            foreach (var item in stList)
            {
                Console.WriteLine(item.Name);
                
            }
            Console.ReadKey();

        }

    }
}
