using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes;
            Console.WriteLine("Please enter a number of minutes to convert to Hours and Minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());
            int hours = minutes / 60;
            minutes = minutes % 60;
            Console.WriteLine("hours: " + hours + " and minutes: " + minutes);
            Console.ReadLine();


        }
    }
}
