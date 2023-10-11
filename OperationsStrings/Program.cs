using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OperationsStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип операции:\n1. Объединенние строк (Concat и Join)" +
                "\n2. Сравнение строк (Compare)\n3. Поиск в строке (IndexOf и LastIndexOf)" +
                "\n4. Поиск в строке (StartsWith и EndsWith)\n5. Разделение строк (Split)" +
                "\n6. Обрезка строки (Trim)\n7. Обрезка строки (Substring)\n8. Вставка (Insert)" +
                "\n9. Удаление строк (Remove)\n10. Замена (Replace)\n11. Смена регистра (ToUpper и ToLower)");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (number)
            {
                case 1:
                    ConcatAndJoin();
                    break;
                case 2:
                    MethodCompare();
                    break;
                case 3:
                    MethodIndex();
                    break;
                case 4:
                    StartsEnds();
                    break;
                case 5:
                    MethodSplit();
                    break;
                case 6:
                    MethodTrim();
                    break;
                case 7:
                    MethodSubstring();
                    break;
                case 8:
                    MethodInsert();
                    break;
                case 9:
                    MethodRemove();
                    break;
                case 10:
                    MethodReplace();
                    break;
                case 11:
                    ToUpperAndToLower();
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.ReadKey();

        }

        private static void ConcatAndJoin()
        {
            Console.WriteLine("\nОбъединение строк с помощью метода Concat: ");
            string s1 = "hello world";
            string s2 = string.Concat(s1, "!!!"); // результат: строка "hello world!!!"
            Console.WriteLine(s2);

            Console.WriteLine("\n---------------------------------------------------------------\n");

            Console.WriteLine("Объединение строк с помощью метода Join: ");
            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };
            string s10 = string.Join(" ", values);
            Console.WriteLine(s10); // apple a day keeps a doctor away
        }


        private static void MethodCompare()
        {
            Console.WriteLine("\nСравнение строк с помощью метода Compare");
            string s1 = "hello";
            string s2 = "world";

            int result = string.Compare(s1, s2);
            if (result<0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            // результатом будет "Строка s1 перед строкой s2"
        }

        private static void MethodIndex()
        {
            Console.WriteLine("\nОпределение индекса в строке");
            string s1 = "\nhello world";
            Console.WriteLine($"Строка: {s1}");
            Console.WriteLine("\nОпределение индекса первого вхождения отдельного символа или подстроки (IndexOf)");
            char ch = 'o';
            int indexOfChar = s1.IndexOf(ch); // равно 4
            Console.WriteLine("Индекс первого вхождения \'o\': " + indexOfChar);

            string substring = "wor";
            int indexOfSubstring = s1.IndexOf(substring); // равно 6
            Console.WriteLine("Индекс первого вхождения \"wor\": " + indexOfSubstring);

            Console.WriteLine("\n---------------------------------------------------------------\n");

            Console.WriteLine("\nОпределение индекса последнего вхождения отдельного символа или подстроки (LastIndexOf)");
            // Поиск последнего вхождения символа 'l'
            Console.WriteLine("Индекс последнего вхождения \'l\': " + s1.LastIndexOf('l'));
            // Поиск последнего вхождения строки "or"
            Console.WriteLine("Индекс последнего вхождения \"or\": " + s1.LastIndexOf("or"));
        }

        private static void StartsEnds()
        {
            Console.WriteLine("Проверка совпадения строк");
            string s1 = "string";
            Console.WriteLine($"Строка: {s1}");
            Console.WriteLine("\nПроверка начинается ли строка на определенную подстроку (StartsWith)");
            if (s1.StartsWith("str"))
                Console.WriteLine("Найдено совпадение подстроки \"str\" в начале строки");
            Console.WriteLine("\n---------------------------------------------------------------\n");
            Console.WriteLine("\nПроверка заканчивается ли строка на определенную подстроку (EndsWith)");
            if (s1.EndsWith("ing"))
                Console.WriteLine("Найдено совпадение подстроки \"ing\" в конце строки");
        }

        private static void MethodSplit()
        {
            Console.WriteLine("Разделение строк с помощью метода Split");
            string text = "И поэтому   все так произошло";
            Console.WriteLine($"Строка: {text}");
            string[] words1 = text.Split(new char[] { ' ' });

            foreach (string s in words1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n---------------------------------------------------------------\n");
            string[] words2 = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string e in words2)
            {
                Console.WriteLine(e);
            }
        }

        private static void MethodTrim()
        {
            Console.WriteLine("Обрезка строки с помощью функции Trim");
            string text = " hello world ";
            Console.WriteLine("Строка: "+text);
            text = text.Trim(); // результат "hello world"
            Console.WriteLine(text);
            text = text.Trim(new char[] { 'd', 'h' }); // результат "ello worl"
            Console.WriteLine(text);
            Console.WriteLine("\n---------------------------------------------------------------\n");
            Console.WriteLine("Обрезка строки с помощью TrimStart и TrimEnd");
            text = text.TrimStart('e'); // результат "llo worl"
            Console.WriteLine(text);
            text = text.TrimEnd('l'); // результат "llo wor"
            Console.WriteLine(text);

        }

        private static void MethodSubstring()
        {
            Console.WriteLine("Обрезка строки с помощью функции Substring");
            string text = "Хороший день";
            Console.WriteLine("Строка: "+text);
            // обрезаем начиная с третьего символа
            text = text.Substring(2);
            // результат "роший день"
            Console.WriteLine(text);
            // обрезаем сначала до последних двух символов
            text = text.Substring(0, text.Length - 2);
            // результат "роший де"
            Console.WriteLine(text);
        }
        private static void MethodInsert()
        {
            Console.WriteLine("Вставка одной строки в другую с помощью функции Insert");
            
            string text = "Хороший день";
            Console.WriteLine("Первая строка: "+text);
            string substring = "замечательный ";
            Console.WriteLine("Вторая строка: "+substring);

            text = text.Insert(8, substring);
            Console.WriteLine(text);    // Хороший замечательный день
        }

        private static void MethodRemove()
        {
            Console.WriteLine("Удаление части строки с помощью метода Remove");
            string text = "Хороший день";
            Console.WriteLine("Cтрока: "+text);
            // индекс последнего символа
            int ind = text.Length - 1;
            // вырезаем последний символ
            text = text.Remove(ind);
            Console.WriteLine(text);    // Хороший ден

            // вырезаем первые два символа
            text = text.Remove(0, 2);
            Console.WriteLine(text);    // роший ден
        }
        private static void MethodReplace()
        {
            Console.WriteLine("Замена одного символа или подстроки на другую с помощью метода Replace");
            string text = "хороший день";
            Console.WriteLine("Cтрока: "+text);
            text = text.Replace("хороший", "плохой");
            Console.WriteLine(text);    // плохой день

            text = text.Replace("о", "");
            Console.WriteLine(text);    // плхй день
        }
        private static void ToUpperAndToLower()
        {
            Console.WriteLine("Приведение строки к верхнему или нижнему регистру с помощью функций ToUpper и ToLower");
            string hello = "Hello world!";
            Console.WriteLine("Cтрока: "+hello);

            Console.WriteLine(hello.ToLower()); // hello world!
            Console.WriteLine(hello.ToUpper()); // HELLO WORLD!
        }
    }
}
