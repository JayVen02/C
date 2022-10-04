using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DateTime_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = "";
            // First Format
            formattedDate = string.Format("{0:dd-MM-yyyy HH:mm:ss}",myDate );
            Console.WriteLine(formattedDate);
            //Second Format
            formattedDate = string.Format("{0:dddd MMMM yyyy}", myDate);
            Console.WriteLine(formattedDate);
            //Third Format
            formattedDate = string.Format("{0:dddd \nMMMM \nyyyy }",myDate);
            Console.WriteLine(formattedDate);
            Console.ReadLine();
        }
    }
}
