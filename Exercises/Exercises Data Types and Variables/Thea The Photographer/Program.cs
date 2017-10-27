using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberPictures = long.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            double filteredPictures = (numberPictures * filterFactor) / 100.0;
            filteredPictures = Math.Ceiling(filteredPictures);
            double totalTime = (numberPictures * filterTime) + (filteredPictures * uploadTime);

            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            string answer = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}", t.Days, t.Hours, t.Minutes, t.Seconds);
            Console.WriteLine(answer);
        }
    }
}
