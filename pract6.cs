using System;
using static System.Console;
using static System.Convert;
using System.Collections;
using System.Collections.Generic;

          /*int ids = ToInt32(ReadLine());
            parametrs.Add(ids);
            string fio = ReadLine();
            parametrs.Add(fio);
            int group = ToInt32(ReadLine());
            parametrs.Add(group);
            int data = ToInt32(ReadLine());
            parametrs.Add(data);*/
namespace pract5
{
    
    class Program
    {
        class Lib
        {
            public class Student
            {
                public int ids;
                public string fio;
                public int group;
                public string data;
            }
            public List<Student> stud= new List<Student>();

            public void addstud(int ids, string fio, int group, string data)
            {
                stud.Add(new Student() { ids = ids, fio = fio, group = group, data = data }) ;
            }
            public void del(int ids)
            {
                for (int i = 0; i < stud.Count; i++)
                {
                    if (stud[i].ids == ids) stud.RemoveAt(i); 
                }
            }
            public void izmen(int ids, string fio, int group, string data)
            {
                for (int i = 0; i < stud.Count; i++)
                {
                    if (stud[i].ids == ids)
                    {
                        stud[i].fio = fio;
                        stud[i].group = group;
                        stud[i].data = data;
                    }
                    
                }
            }
            public void show()
            {
                foreach (var i in stud)
                {
                    WriteLine(i.fio + "\n");
                }
            }
            public void poiskID(int id)
            {
                WriteLine(stud[id].ids + "\n" + stud[id].fio + "\n" + stud[id].group + "\n" + stud[id].data + "\n");                
            }
            public void age(int idi)
            {
                DateTime idage = ToDateTime(stud[idi].data);
                /* Console.WriteLine(thisDay.ToString("d"));*/
                DateTime now = DateTime.Today;
                int age = now.Year - idage.Year;
                if (idage > now.AddYears(-age)) age--;
                WriteLine(age + " - возраст студента.");
            }
            
        }
        static void Main(string[] args)
        {
            Lib L = new Lib();
            int ids=0;
            int z;
            do
            {
                WriteLine("\nВведите: \n 1. Чтобы добавить студента \n 2. Чтобы изменить \n 3. Удалить \n 4. Вывести Ф.И.О. \n " +
                    "5. Вывести информацию по ID \n 6. Возраст выбранного по ID студента\n");
                z = ToInt32(ReadLine());
                WriteLine("\n");
                if (z == 1)
                {
                    //Добавить
                    WriteLine("\nФ.И.О.: ");
                    string fio = ReadLine();
                    WriteLine("Группа: ");
                    int group = ToInt32(ReadLine());
                    WriteLine("Дата рождения дд.мм.гггг: ");
                    string data = ReadLine();
                    L.addstud(ids, fio, group, data);
                    ids++;
                }
                else if (z == 2)
                {
                    //Изменить
                    WriteLine("\nID студента: ");
                    int idsT = ToInt32(ReadLine());
                    WriteLine("Ф.И.О.: ");
                    string fio = ReadLine();
                    WriteLine("Группа: ");
                    int group = ToInt32(ReadLine());
                    WriteLine("Дата рождения дд.мм.гггг: ");
                    string data = ReadLine();
                    L.izmen(idsT, fio, group, data);
                }
                else if (z == 3)
                {
                    //Удалить
                    ids = ToInt32(ReadLine());
                    L.del(ids);
                }
                else if (z==4) L.show(); //Показать ФИО
                else if (z == 5)
                {
                    WriteLine("Введите ID студента");
                    int idss = ToInt32(ReadLine());
                    L.poiskID(idss);
                }
                else if (z == 6)
                {
                    WriteLine("Введите ID студента");
                    int IDage = ToInt32(ReadLine());
                    L.age(IDage);
                }
                
            } while (z != 0) ;


        }
    }
}
