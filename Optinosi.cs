using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace pw7
{

    public class Optinosi
    {
        enum Size
        {
            /// <summary>
            /// Гигабайт
            /// </summary>
            GB = 1073741824
        }
        public static void Outputi()
        {
            DriveInfo[] c = DriveInfo.GetDrives();
            Console.WriteLine("\n\n");
            foreach (DriveInfo d in c)
            {
                Console.WriteLine();
                Console.WriteLine(d.Name);
                Console.WriteLine(d.DriveFormat + " - тип диска");
                Console.WriteLine(d.TotalSize / (int)Size.GB + "ГБ - Всего места");
                Console.WriteLine(d.AvailableFreeSpace / (int)Size.GB + "ГБ - Осталось места");
            }
            Console.ReadKey();
            Program.Main(new string[0]);
        }
    }
}