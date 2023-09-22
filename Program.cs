using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpace
{
    
}



namespace ConsoleApp4
{
    struct Student
    {
        public string name;
        public readonly int age;
    }

    public class MyClass
    {
        public int a;
        public int b;
        
        public MyClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void SetA(int a) 
        { 
            this.a = a;
        }

        public int Summ(int a, int b)
        {
            return a + b;
        }

        
    }

   

    internal class Program
    {
        static void Main(string[] args)
        {
            //CesarSifr();

            //ArithmeticExpression();

            //SetUpFirstLetter();

            //HideInvalidWords();

            //MyClass obj = new MyClass();
            //Console.WriteLine(obj.name);
            //Console.WriteLine(obj.age);


            //int num = 1;
            //int a = 3;
            //int b = 5;
            //Console.WriteLine(summ(ref a, ref b, out num));

            //int a = 1;
            //int b = 2;
            //MyClass myClass = new MyClass(1,2);
            //Console.WriteLine(myClass.Summ(a, b));


            Employee emp1 = new Employee();
            Employee emp2 = new Employee("Сидоров Иван Васильевич", "15.05.1980", "8-950-540-91-61", "sidor@gmail.com", "стропальщик", "работа по строповке грузов");
            Employee emp3 = new Employee();

            emp1.SetFIO("Иванов Пётр Петрович");
            emp1.SetBirthDate("14.05.1979");
            emp1.SetTelephoneNumber("8-916-122-62-33");
            emp1.SetEmail("ivanov@mail.ru");
            emp1.SetJobTitle("крановщик");
            emp1.SetJobDescription("работа на мостовом кране");
            emp1.PrintEmployee();
            Console.WriteLine();
            emp2.PrintEmployee();

            //emp3.Set.set("Игорь Владимирович Сорокин", "", "", "", "", "");
            //Console.WriteLine(emp3.GetFIO());

            //Shape shape= new Shape();
            //double hight = 0;
            //double width = 0;
            //double length = 0;
            //Console.WriteLine("Введите длину стороны куба: ");
            //hight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Площадь сторон куба равна - " + shape.SquareOf(hight));


            //Console.WriteLine("Введите длину параллелепипеда:");
            //hight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите ширину параллелепипеда:");
            //width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите высоту параллелепипеда:");
            //length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Площадь сторон параллелепипеда равна - " + shape.SquareOf(hight, width, length));

            Distance d = new Distance();
            d.Print();
            Console.WriteLine(d.MaxOf());

        }

        public static void summ(ref int a, ref int b, out int s)
        {
            s = a + b;
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

    public class Employee
    {
        private string FIO;
        private string BirthDate;
        private string TelephoneNumber;
        private string Email;
        private string JobTitle;
        private string JobDescription;

        public Employee() { }

        public Employee(string FIO, string BirthDate, string TelephoneNumber, string Email, string JobTitle, string JobDescription) 
        {
            this.FIO = FIO;
            this.BirthDate = BirthDate;
            this.TelephoneNumber = TelephoneNumber;
            this.Email = Email;
            this.JobTitle = JobTitle;
            this.JobDescription = JobDescription;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Фамилия Имя Отчество: " + FIO);
            Console.WriteLine("Дата рождения: " + BirthDate);
            Console.WriteLine("Контактный телефон: " + TelephoneNumber);
            Console.WriteLine("Электронная почта: " + Email);
            Console.WriteLine("Должность: " + JobTitle);
            Console.WriteLine("Описание должности: " + JobDescription);
        }

        public string GetFIO()
        {
            return FIO;
        }

        public string GetBirthDate()
        {
            return BirthDate;
        }

        public string GetTelephoneNumber()
        {
            return TelephoneNumber;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetJobTitle()
        {
            return JobTitle;
        }

        public string GetJobDescription()
        {
            return JobDescription;
        }

        public void SetFIO(string FIO)
        {
            this.FIO = FIO;
        }

        public void SetBirthDate(string BirthDate)
        {
            this.BirthDate=BirthDate;
        }

        public void SetTelephoneNumber(string TelephoneNumber)
        {
            this.TelephoneNumber= TelephoneNumber;
        }

        public void SetEmail(string Email)
        {
            this.Email= Email;
        }

        public void SetJobTitle(string JobTitle)
        {
            this.JobTitle= JobTitle;
        }

        public void SetJobDescription(string JobDescription)
        {
            this.JobDescription= JobDescription;
        }

        

    }

    public class Shape
    {
        public double SquareOf(double a)
        {
            return 6 * a * a;
        }

        public double SquareOf(double hight, double width, double length)
        {
            return 2*(hight*width + hight*length + width*length);
        }
    }

    public class Distance
    {
        private double a = 1;
        private double b = 2;

        public void Print()
        {
            Console.WriteLine("a = " + a + ", b = " + b);
        }

        public double Summ()
        {
            return a + b;
        }

        public double MaxOf()
        {
            return a > b ? a : b;
        }
    }
}
