using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0'dan 1000000 a kadar sayıları dosyaya yaz
            for (int i = 0; i < 731000; i++)
            {
                File.AppendAllText("d:\\sayilar.txt", i.ToString());
            }
        }
    }
}
