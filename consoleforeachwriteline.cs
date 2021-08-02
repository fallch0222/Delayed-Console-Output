using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleforeachwriteline
{
    public class Class1
    {
        private static DateTime Delay(int MS) //delay
        {
            // More effective then Thread and Timer
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {

                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        static void Mainstringline(string word) //foreach
        {

            string str = word;

            foreach (char c in str)
            {
                Console.Write(c);
                Delay(100);

            }
            Console.WriteLine();

        }
    }
}
