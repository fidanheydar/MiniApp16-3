using MiniApp.Core.Models;
using MiniApp.Helpers;
using MiniApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniApp.Implementations
{
    public class TeacherService : Service, ITeacherService
    {
        private Teacher[] Teachers = new Teacher[0];
        public void Create()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Teacher Name");
            string name = Console.ReadLine();
            while (!name.CheckLength())
            {
                Console.WriteLine("Name is not valid");
                name = Console.ReadLine();
            }
            teacher.Name = name;

            Console.WriteLine("Teacher SurName");
            string surname = Console.ReadLine();
            while (!surname.CheckLength())
            {
                Console.WriteLine("Name is not valid");
                name = Console.ReadLine();
            }
            teacher.Surname = surname;

            Console.WriteLine("Teacher GroupName");
            string GroupNo = Console.ReadLine();
            while (!GroupNo.CheckLength())
            {
                Console.WriteLine("Name is not valid");
                GroupNo = Console.ReadLine();
            }
            teacher.GroupNo = GroupNo;
            Array.Resize(ref teachers, teachers.Length + 1);
            teachers[teachers.Length - 1] = teacher;

        }
        public void Update()
        {
            Console.WriteLine("Please add student  Id");
            int.TryParse(Console.ReadLine(), out int id);
            for (int i = 0; i < Teachers.Length; i++)
            {
                if (Teachers[i].Id == id)
                {
                    while (!Name.CheckLength())
                    {
                        Console.WriteLine(" Teacher Name is not valid");
                        Name = Console.ReadLine();
                    }
                    Teachers[i].Name = Name;

                    Console.WriteLine(" Teacher Surname");
                    string surname = Console.ReadLine();
                    while (!surname.CheckLength())
                    {
                        Console.WriteLine(" Teacher Surname is not valid");
                        Name = Console.ReadLine();
                    }
                    Teachers[i].Surname = surname;

                    Console.WriteLine(" Teacher GroupNo");
                    string GroupNo = Console.ReadLine();
                    while (!GroupNo.CheckLength())
                    {
                        Console.WriteLine(" Teacher Group is not valid");
                        GroupNo = Console.ReadLine();
                    }
                    Teachers[i].GroupNo = GroupNo;
                }
                return;
            }
            Console.WriteLine("Id is not found");


        }



        }
        public void Delete()
        {

            Console.WriteLine("Please add teacher Id for delete");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Teachers.Length; i++)
            {
                if (Teachers[i].Id == id)
                {
                    Teacher teacher = Teachers[Teachers.Length - 1];
                    Teachers[Teachers.Length - 1] = Teachers[i];
                    Teachers[i] = teacher;

                    Array.Resize(ref teachers, Teachers.Length - 1);
                    return;
                }
            }
            Console.WriteLine("Such Id is not found");

        }
        public void GetAll()
        {
            foreach (Teacher teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter teacher Id");
            int id = int.Parse(Console.ReadLine());
            foreach (Teacher teacher in Teachers)
            {
                if (teacher.Id == id)
                {
                    Console.WriteLine(teacher.ToString());
                    return;
                }

            }


        }
    }
}
