using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string a = "Виктор Никифоров Сиринкс    ";
            Console.WriteLine(a);
            Console.ForegroundColor = ConsoleColor.Blue;
            string b = "Бабье лето";
            Console.WriteLine(b);
            Console.ForegroundColor = ConsoleColor.Red;
            string c = "Осень терпкая, как ягода-рябина,\nбрызжет соком золотистых дней.\nВот она, хмельная сердцевина\nлета Бабьего и осени моей.\nИ не потому, что сердце ласки просит,\nнет хмельней осеннего вина.\nОсенью Весна в мою приходит осень,\nчтобы душу высветлить до дна.";
            Console.WriteLine(c);
            Console.ResetColor();
        }
    }
}