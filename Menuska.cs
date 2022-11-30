using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pw7
{
    public class Menuska
    {

        public static int Start(List<ReadedFile> files, string firstLine)
        {
            Console.Clear();
            Cursor cursor = new Cursor(files.Count, 1, 1);
            GetMenu.ShowMenu(GetMenu.ToMenuString(files), firstLine);
            while (true)
            {
                Console.SetCursorPosition(0, cursor.pos);
                Console.Write("->");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        Optinosi.Outputi();
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(0, cursor.pos);
                        Console.Write("  ");
                        if (cursor.pos == cursor.min)
                            cursor.pos = cursor.max;
                        else
                            cursor.pos--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(0, cursor.pos);
                        Console.Write("  ");
                        if (cursor.pos == cursor.max)
                            cursor.pos = cursor.min;
                        else
                            cursor.pos++;
                        break;
                    case ConsoleKey.Escape:
                        return -1;
                    case ConsoleKey.Enter:
                        return cursor.pos;
                }
            }
        }
    }
}