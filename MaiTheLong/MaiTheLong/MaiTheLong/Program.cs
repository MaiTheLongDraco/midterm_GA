using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiTheLong
{
    internal class Program
    {
        static TestStudent test=new TestStudent () ;
         static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please select an option ");
                Console.WriteLine("==============================");
                Console.WriteLine("1.Input infomation");
                Console.WriteLine("2.Sort acending student by avg mark");
                Console.WriteLine("3. Display all the student.");
                Console.WriteLine("4. Search Student by Name");
                Console.WriteLine("5. Delete Student by student ID.");
                Console.WriteLine("6.exit");
                Console.WriteLine("==============================");
                Console.WriteLine("Option :");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key) { 
                    case 1:test.InputInfo();break;
                    case 2:test.SortByDiemTB();break;
                    case 3:test.ShowSinhVien(test.getListStudents());break;
                    case 4:test.FindByName("a");break;
                    case 5:test.DeleteById(1);break;
                    case 6:break;
                }
            } while(true);
        }
    }
}
