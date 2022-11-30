using pw7;
using System.Diagnostics;

namespace pw7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string folder = null;
            while (true)
            {
                List<ReadedFile> list = Papkas.Read(folder);
                int pos = Menuska.Start(list, folder);
                if (pos == -1)
                    break;
                else
                    pos--;
                if (File.Exists(list[pos].path))
                {
                    Process.Start(list[pos].path);
                    break;
                }
                else
                    folder = list[pos].path;
            }
        }
    }
}