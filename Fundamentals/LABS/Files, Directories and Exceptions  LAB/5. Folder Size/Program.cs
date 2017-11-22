using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double sum = 0;         
                     
            for (int i = 0; i < 5; i++)
            {      
                for (int j = 0; j < 1000; j++)
                {
                    int randomNumber = rnd.Next(0, int.MaxValue);
                    File.AppendAllText($"TestFolder\\File{i}.txt", $"{randomNumber.ToString()}"+Environment.NewLine);
                }               
            }
            string[] files =
                Directory.GetFiles("TestFolder");          
            foreach (var file in files)
            {
                sum += file.Length;
            }
            File.Delete("Output.txt");
            sum = sum / 1024 / 1024;
            File.AppendAllText("Output.txt",sum.ToString());
        }
    }
}
