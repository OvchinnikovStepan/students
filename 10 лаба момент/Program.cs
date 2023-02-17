using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_лаба_момент
{
    internal class Program
    {
        class Stud
        {
            public string FIO;
            public int chislo;
            public int mouth;
            public int year;
            public string group;
            public string subject;
            public string mark;
            public Stud(string FIO, int chislo, int mouth, int year, string group, string subject, string mark)
            {
                this.FIO = FIO;
                this.chislo = chislo;
                this.mouth = mouth;
                this.year = year;
                this.group = group;
                this.subject = subject;
                this.mark = mark;
            }
            public Stud() { }
        }
        static Stud[] A(Stud[] SP)
        {
            Console.WriteLine("Введите число строк в базе");
            int a = Convert.ToInt32(Console.ReadLine());
            SP = new Stud[a];
            for (int i = 0; i < a; i++)
            {
                SP[i] = new Stud();
                Console.WriteLine("Введите ФИО {0} студента", i + 1);
                SP[i].FIO = Console.ReadLine();
                Console.WriteLine("Введите дату рождения {0} студента", i + 1);
                SP[i].chislo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите месяц рождения {0} студента", i + 1);
                SP[i].mouth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите год {0} студента", i + 1);
                SP[i].year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название группы для {0} студента", i + 1);
                SP[i].group = Console.ReadLine();
                Console.WriteLine("Введите названия предмета для {0} студента", i + 1);
                SP[i].subject = Console.ReadLine();
                Console.WriteLine("Введите оценку по предмету у {0} студента", i + 1);
                SP[i].mark = Console.ReadLine();
            }
        }
    }
        static void Main() { 
            Stud[] SP=new Stud[0];
            Console.WriteLine("Что вы хотите сделать:\n 1.Заполнить список \n 2.Вывести студентов определённой группы.\n 3.Вывести студентов должиков.\n" +
                "4.Вывести студентов отличников \n 5.Вывести студентов моложе 20");
            string b = Console.ReadLine();
            if (b == "1")
            {
            A();
            }
            else if (b == "2") {
                Console.WriteLine("Введите имя группы");
                string c = Console.ReadLine();
                for (int i = 0; i < SP.Length; i++) {
                    if (SP[i].group==c) { Console.WriteLine(SP[i].FIO); }
                }
            }
            else if (b == "3")
            {
                for (int i = 0; i < SP.Length; i++)
                {
                    if ((SP[i].mark == "")||(SP[i].mark == "2")) { Console.WriteLine(SP[i].FIO); }
                }
            }
            else if (b == "3")
            {
                for (int i = 0; i < SP.Length; i++)
                {
                    if ((SP[i].mark == "") || (SP[i].mark == "2")) { Console.WriteLine(SP[i].FIO); }
                }
            }
            else if (b == "4")
            {
                for (int i = 0; i < SP.Length; i++)
                {
                    if (SP[i].mark == "5")
                    {
                        int flag = 0;
                        for (int t = 0; t < SP.Length; t++)
                        {
                            if ((SP[i].FIO == SP[t].FIO) && (SP[t].mark != "5"))
                            {
                                flag = 1;
                                break;
                            }
                       
                        }
                        if (flag == 0)
                        {
                            Console.WriteLine(SP[i].FIO);
                        }
                    }
                }
            }
            else if (b == "5")
            {
                for (int i=0; i < SP.Length; i++)
                {
                    if (SP[i].year>2002) { Console.WriteLine(SP[i].FIO); }
                }
            }
        }
    }
}
