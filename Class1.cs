using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw7
{
    public class ReadedFile
    {
        public string name;
        public string path;
        public bool file;
        public ReadedFile(string name, string path, bool file)
        {
            this.name = name;
            this.path = path;
            this.file = file;
        }
    }
    public static class ToReadedFile
    {
        private static string GetName(string path)
        {
            return path.Split('\\')[^1];
        }
        public static List<ReadedFile> ReadedFiles(List<string> files)
        {
            List<ReadedFile> readedFiles = new List<ReadedFile>();
            foreach (string file in files)
            {
                readedFiles.Add(new ReadedFile(GetName(file), file, File.Exists(file)));
            }
            return readedFiles;
        }

    }
    public static class GetMenu
    {
        public static List<string> ToMenuString(List<ReadedFile> files)
        {
            List<string> strings = new List<string>();
            foreach (ReadedFile file in files)
            {
                if (!file.file)
                {
                    strings.Add(file.name + '\\');
                }
                else
                {
                    strings.Add(file.name);
                }
            }
            return strings;
        }
        public static void ShowMenu(List<string> lines, string firstLine)
        {
            Console.WriteLine(firstLine);
            foreach (string line in lines)
            {
                Console.WriteLine("   " + line);
            }
        }
    }
    public class Papkas
    {
        public static List<ReadedFile> Read(string path)
        {
            List<ReadedFile> files = new List<ReadedFile>();
            if (path == null)
            {
                files.AddRange(GetDrives());
            }
            else
            {

                files.AddRange(GetFiles(path));
            }
            return files;
        }
        private static List<ReadedFile> GetFiles(string path)
        {
            List<ReadedFile> files = new List<ReadedFile>();
            files.AddRange(ToReadedFile.ReadedFiles(Directory.GetDirectories(path).ToList()));
            files.AddRange(ToReadedFile.ReadedFiles(Directory.GetFiles(path).ToList()));
            return files;
        }
        private static List<ReadedFile> GetDrives()
        {
            List<ReadedFile> drives = new List<ReadedFile>();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
                drives.Add(new ReadedFile($"{drive.Name} Свободно {Math.Round(Convert.ToDouble(drive.AvailableFreeSpace) / 1024 / 1024 / 1024, 2)} гб", drive.Name, false));
            return drives;
        }
    }
}