using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CesarSifr();

            //ArithmeticExpression();

            //SetUpFirstLetter();

            HideInvalidWords();

        }

        static void CesarSifr() // шифр Цезаря
        {
            /*
             * Пользователь вводит строку с клавиатуры. Необходимо 
             зашифровать данную строку используя шифр Цезаря.
             Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
             символом, находящимся на некотором постоянном числе
             позиций левее или правее него в алфавите. Например,
             в шифре со сдвигом вправо на 3, A была бы заменена на
             D, B станет E, и так далее.
             */
            for (char i = 'а'; i <= 'я'; i++)
            {
                Console.WriteLine(i + " = " + (int)i);
            }
            Console.WriteLine("========================================");
            for (char i = 'А'; i <= 'Я'; i++)
            {
                Console.WriteLine(i + " = " + (int)i);
            }


            string str = "Какой-то: текст!";
            Console.WriteLine("Исходный текст:\n" + str);
            int shift = -1;
            StringBuilder newStr = new StringBuilder();
            if (shift != 0)
            {
                int finalShift = 0;
                if(Math.Abs(shift) > 1071 - 1039)
                {
                    finalShift = Math.Abs(shift)%(1071-1039);
                }
                else
                {
                    finalShift = Math.Abs(shift);
                }
               
                
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    if (c >= 1072 && c <= 1103)
                    {
                        if (shift > 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c++;
                                if ((int)c == 1104)
                                {
                                    c = 'а';
                                }
                            }
                            newStr.Append(c);
                        }
                        else if (shift < 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c--;
                                if ((int)c == 1071)
                                {
                                    c = 'я';
                                }
                            }
                            newStr.Append(c);
                        }
                    }
                    else if (c >= 1040 && c <= 1071)
                    {
                        if (shift > 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c++;
                                if ((int)c == 1072)
                                {
                                    c = 'А';
                                }
                            }
                            newStr.Append(c);
                        }
                        else if (shift < 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c--;
                                if ((int)c == 1039)
                                {
                                    c = 'Я';
                                }
                            }
                            newStr.Append(c);
                        }
                    }
                    else
                    {
                        newStr.Append(c);
                    }
                }
                Console.WriteLine("Зашифрованный текст: ");
                Console.WriteLine(newStr);
            }
            else
            {
                Console.WriteLine("Зашифрованный текст: ");
                Console.WriteLine(str);
            }


            // дешифровальщик
            StringBuilder Str = new StringBuilder();
            if (shift > 0)
            {
                shift = shift * (-1);
            }else if(shift < 0)
            {
                shift = shift * (-1);
            }
            if (shift != 0)
            {
                int finalShift = 0;
                if (Math.Abs(shift) > 1071 - 1039)
                {
                    finalShift = Math.Abs(shift)%(1071-1039);
                }
                else
                {
                    finalShift = Math.Abs(shift);
                }

                
                for (int i = 0; i < str.Length; i++)
                {
                    char c = newStr[i];
                    if (c >= 1072 && c <= 1103)
                    {
                        if (shift > 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c++;
                                if ((int)c == 1104)
                                {
                                    c = 'а';
                                }
                            }
                            Str.Append(c);
                        }
                        else if (shift < 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c--;
                                if ((int)c == 1071)
                                {
                                    c = 'я';
                                }
                            }
                            Str.Append(c);
                        }
                    }
                    else if (c >= 1040 && c <= 1071)
                    {
                        if (shift > 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c++;
                                if ((int)c == 1072)
                                {
                                    c = 'А';
                                }
                            }
                            Str.Append(c);
                        }
                        else if (shift < 0)
                        {
                            for (int j = 0; j < finalShift; j++)
                            {
                                c--;
                                if ((int)c == 1039)
                                {
                                    c = 'Я';
                                }
                            }
                            Str.Append(c);
                        }
                    }
                    else
                    {
                        Str.Append(c);
                    }
                }
                Console.WriteLine("Исходный текст: ");
                Console.WriteLine(Str);
            }
            else
            {
                Console.WriteLine("Исходный текст: ");
                Console.WriteLine(Str);
            }
        }

        static void ArithmeticExpression()
        {
            Console.Write("Введите арифметическое выражение с операторами + и - : ");
            string Ex = Console.ReadLine();
            //string Ex = "1+2+1-3";
            //Console.Write("1+2+1-3");
            int Res = 0;
            StringBuilder str = new StringBuilder();
            int operand = 0;
            int oper = 0;
            char opPrev = '+';
            char opCur = '+';
            bool first = true;
            for (int i = 0; i < Ex.Length; i++) 
            {
                if (Ex[i] != '-' && Ex[i] != '+')
                {
                    str.Append(Ex[i]);
                }
                else
                {
                    if (first)
                    {
                        operand = Convert.ToInt32(str.ToString());
                        opPrev = Ex[i];
                        first = false;
                        str = new StringBuilder();
                        continue;
                    }

                    opCur = Ex[i];
                    if (opPrev == '+')
                    {
                        oper = Convert.ToInt32(str.ToString());
                        operand += oper;
                    }
                    else if (opPrev == '-')
                    {
                        oper = Convert.ToInt32(str.ToString());
                        operand -= oper;
                    }
                    opPrev = opCur;
                    str = new StringBuilder();
                }
            }
            if (opPrev == '+')
            {
                oper = Convert.ToInt32(str.ToString());
                operand += oper;
            }
            else if (opPrev == '-')
            {
                oper = Convert.ToInt32(str.ToString());
                operand -= oper;
            }
            Console.Write(" = " + operand + "\n");
        }
       
        static void SetUpFirstLetter()
        {
            Console.WriteLine("Введите текст:");
            //Console.ReadLine("today is a good day for walking. i will try to walk near the sea");
            
            string str = "      какое-то предложение. ешё предложение. и ещё предложение.";
            Console.WriteLine("Исходный текст:" + str);
            str = str.TrimStart(' ');
            str = str.TrimEnd(' ');
            StringBuilder newStr = new StringBuilder();
            char separator = ' ';
            for(int i = 0; i < str.Length;)
            {
                if(i == 0)
                {
                    char c = str[i];
                    newStr.Append(c.ToString().ToUpper());
                    i++;
                    if (i == str.Length)
                    {
                        break;
                    }
                }
                separator = str[i];
                if(separator == '.')
                {
                    while (str[i] == ' ' || str[i] == '.')
                    {
                        char c = str[i];
                        newStr.Append(c.ToString());
                        i++;
                        if(i == str.Length)
                        {
                            break;
                        }
                    }
                    if (i == str.Length)
                    {
                        break;
                    }
                    char ch = str[i];
                    newStr.Append(ch.ToString().ToUpper());
                    i++;
                    if (i == str.Length)
                    {
                        break;
                    }
                }
                else
                {
                    char c = str[i];
                    newStr.Append(c.ToString());
                    i++;
                    if (i == str.Length)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Конечный текст: " + newStr);
        }

        static void HideInvalidWords()
        {
            string str = "To be, or not to be, that is the question,\r\n" +
                "Or to take arms against a sea of troubles,\r\n" +
                "And by opposing end them? To die: to sleep;\r\n" +
                "No more; and by a sleep to say we end\r\n" +
                "Devoutly to be wish'd. To die, to sleep";
            string invalidWord = "die";

            char[] p = { ' ', ',', ':', '?', '.', '\r', '\n', ';'};

            string[] arrStr_ = str.Split(p);

            int countNoEmptiness = 0;

            foreach (string item in arrStr_)
            {
                if(item != "")
                {
                    countNoEmptiness++;
                }
            }

            string[] arrStr = new string[countNoEmptiness];

            for (int i = 0, j = 0; i < arrStr_.Length; i++)
            {
                if (arrStr_[i] != "")
                {
                    arrStr[j] = arrStr_[i];
                    j++;
                }
            }

            int countOfInvalidWord = 0;

            foreach (string el in arrStr)
            {
                if(el == invalidWord)
                {
                    countOfInvalidWord++;
                }
            }

            str = str.Replace(invalidWord, "***");

            Console.WriteLine(str);

            Console.WriteLine("Статистика: " + countOfInvalidWord + " замены слова " + invalidWord + ".");
        }

    }
}
