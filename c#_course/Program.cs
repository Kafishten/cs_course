using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //для замены разделителей вещественных чисел
namespace ConsoleApp2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Clear();


            Console.WriteLine("output" + "!"); // cw + Tab

            string a;
            a = Console.ReadLine();

            //Конвертация
            int b;
            string c = "1234";
            b = Convert.ToInt32(c);
            b = Convert.ToInt16(c);

            NumberFormatInfo glob = NumberFormatInfo.InvariantInfo;
            {
                glob.NumberDecimalSeparator = ".";
            }
            double abba = Convert.ToDouble(c,glob);

            string cc = "1234";
            int bb;
            bb = int.Parse(cc);

            HELLO WORLD

            // типпеременной.TryParse(переменная которую конвертировать, out переменн в которую парсить)
            // bool result = типпеременной.TryParse(...) возвращает булевое значения (для исключений)

            /*
           
             if (выражение)                    
            {                                  
            ...                                
            }                                  
                                                
            else                               
            {                                  
            ...                                
            }
             
            && сокращенный вариант
            ||
            & хуже - много действий
            |
             */

            int aa = 10;
            switch (aa)
            {
                case 0:
                    Console.WriteLine("0");
                    break;

                case 1:
                case 2:
                    Console.WriteLine("is 1 or 2");
                    break;

                default:
                    Console.WriteLine("no case");
                    break;



            }
            // [FIRST OPERAND (IF)] ? [IF TRUE] : [IF FALSE]

            int[] array;
            array = new int[5] { 1, 2, 3, 4, 5 }; //or new int[] {......} //выделение памяти
            int[] ARRAY2 = Enumerable.Repeat(5, 10).ToArray(); //массив из 10ти пятёрок
            int[] ARRAY3 = Enumerable.Range(5, 10).ToArray(); //массив из 5 6 7 8 9 10 11 12 13 14 15

            int[] myarray4 = { 1, 2, 3, 4, 5, 6 };
            //int result = myarray4.Lenght;
            //int result = myarray4.Min();
            //int result = myarray4.Sum();
            //int result = myarray4.Where(i => i%2 == 0).Sum(); //сумма четных
            //int result = myarray4.Where(i => i%2 == 0).first()
            //int result = myarray4.Where(i => i%2 == 0).firstordefault() возвр значение по умолч. е сли нет совпадений
            //int result = myarray4.Where(i => i % 2 != 0).Min(); //меньшее нечетное
            //int[] resultarray = myarray4.Distinct().ToArray(); // записать в новый массив уникальные ячейки
            //int[] result = myarray4.OrderBy(x => x<70).ToArray();
            //int[] result = myarray4.OrderByDescending(i => i).ToArray();
            //Array.sort(myarray)
            //int a = Array.find(myarray,i=>i<70)  findlast()  (для одних) 
            //int[] a = findall() для массива
            //int a findindex(myarray,i=>i==77) findlastindex()
            //int[] a = Array.reverse(myarray)
            //ARRAY[^1] послендний элемент
            //[1..4] диапозон [2..] до конца

            //двумерные массивы
            int[,] darray;
            darray = new int[5, 10];

            //зубчатые

            int[][] myarray1 = new int[3][];
            myarray1[1] = new int[3];
            myarray1[2] = new int[4];
            myarray1[0] = new int[1];
            myarray1.GetLength(0); //получить числ эл-в в текущем измерении (0 для 1го, 1 для 2го)




            // модификатор тип_возвр_знач назв(параметры){
            //  тело
            // }

            //чтобы добавить к методу описание, набрать перед его объявлением 3 / слеша


        }
    }
}
