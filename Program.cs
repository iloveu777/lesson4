using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zxc; // без инициализации 
            string zyc = null; // инициализация неопред. знач.
            //Console.WriteLine(zyc);
            string qwe = String.Empty; // строка объявл. как пустая с помощью Empty
            //Console.WriteLine(qwe);
            string asd = "123"; // иницал. строковой переменной строкой литералом(константой)
            var asdf = String.Empty; //строковое знач. переменной присваивавется без явного вызова конструктора 
            string asdfg = new String('a', '6'); // иниц. строки с использованием конструктора класса String
            char[] qwer = { 'm', 'e', 's', 's', 'a', 'g', 'e'};
            string qwer1 = new string(qwer);
            WriteLine(qwer1);
            Console.ReadKey();
        }
    }
}
