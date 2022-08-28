using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of streams");
            int CountOfStreams = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of classes on stream");
            int CountClassesOnStream = int.Parse(Console.ReadLine());
            var school = new School(CountOfStreams, CountClassesOnStream);
        }
    }
}
