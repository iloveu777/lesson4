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
            /*
            string zxc; // без инициализации 
            string zyc = null; // инициализация неопред. знач.
            //Console.WriteLine(zyc);
            string qwe = String.Empty; // строка объявл. как пустая с помощью Empty
            //Console.WriteLine(qwe);
            string asd = "123"; // иницал. строковой переменной строкой литералом(константой)
            var asdf = String.Empty; //строковое знач. переменной присваивавется без явного вызова конструктора 
            string asdfg = new String('a', '6'); // иниц. строки с использованием конструктора класса String
            char[] qwer = { 'm', 'e', 's', 's', 'a', 'g', 'e'};
            string qwer1 = new string(qwer); // создание строки из массива символов
            // WriteLine(qwer1);
            */

            // конкатенация
            /* string qwe = "я люблю ";
             string zxc = "программирование ";
             string asd = "на C#";
             string fgh = qwe + zxc + asd;// для 3 способа
             // 1 способ
             /* string fgh = qwe + zxc + asd;
             Console.WriteLine(fgh); */

            //2 способ
            /*  qwe += zxc;
             qwe += asd;
             Console.WriteLine(qwe); */

            //3 способ
            /* string uio = String.Concat(fgh, "!!!");
             Console.WriteLine(uio);*/
            /*
            // 4 способ
            string st1 = "Я";
            string st2 = "люблю";
            string st3 = "программирование";
            /* string st = String.Join(" ", st1, st2, st3 );
             WriteLine( st );
            string[] st = new string[] { st1, st2, st3 };
            string s = String.Join(" ", st);
            Console.WriteLine(s); */
            string a1 = "фальш";
            string b3= "монеты";
            string c4 = "в";
            string d2 = "ивые";
            string e5 = "мешках";
            //cпособ 1
            // string result = a1 + d2 + b3 +c4 +e5;
            //Console.WriteLine(result);
            /*//способ 2
            a1 += d2;
            a1 += b3;
            a1 += c4;
            a1 += e5;
            WriteLine(a1);*/
            // способ 3
            //string tstst = String.Concat(a1, d2, b3, c4, e5);
            //Console.WriteLine(tstst);
            //cпособ 4
            a1 += d2;
            string[] asd = new string[] {a1, b3,c4,e5 };
            
            string s = String.Join(" ", asd);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
