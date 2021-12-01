using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    public class Program<T>
    {
        static void Main(string[] args)
        {
            List<string> menuList = new List<string> { "Kurslarım", "Tüm Kurslar", "Kampa Hazırılık", "Sık Sorulan Sorular" };
            List<string> courseList = new List<string> { "C#", "Java", "Temel" };

            foreach (var menu in menuList)

            {
                Console.WriteLine(menuList);
            }
            foreach (var couse in courseList)
            {
                Console.WriteLine(courseList);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
