using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15312101
{






    internal class Program
    {






        static void Main(string[] args)
        {
            Student student= new Student();
            student.id = "N15312101 ";
            student.name = "Ken";
            Console.WriteLine("ID:" + student.id + "Name:" + student.name);

            Student student2 = new Student();
            student2.id = "N1234567 ";
            student2.name = "王曉明";
            Console.WriteLine("ID:" + student2.id + "Name:" + student2.name);


            Console.ReadLine();


        }




    }

    public class Student
    {
        public string id;
        public string name;
        public Student()
        {

        }






    }





}
