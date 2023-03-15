using MiniApp.Core.Models;
using MiniApp.Helpers;
using MiniApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniApp.Implementations
{
    public class StudentService : Service, IStudentService
    {
        private Student[] Students = new Student[0];
        private string Name;

        public void Create()
        {
            Student student = new Student();
            Console.WriteLine(" StudentName");
            string name = Console.ReadLine();
            while (!name.CheckLength())
            {
                Console.WriteLine("Name is not valid");
                name = Console.ReadLine();
            }
            student.Name = name;


            Console.WriteLine(" Student Surname");
            string surname = Console.ReadLine();
            while (!surname.CheckLength())
            {
                Console.WriteLine("Surname is not valid");
                name = Console.ReadLine();
            }
            student.Surname = surname;

            Console.WriteLine(" Student GroupNo");
            string GroupNo = Console.ReadLine();
            while (!GroupNo.CheckLength())
            {
                Console.WriteLine("Group is not valid");
                GroupNo = Console.ReadLine();
            }
            student.GroupNo = GroupNo;

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;



        }


        public void Delete()
        {
            Console.WriteLine("Please add student Id for delete");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Student student = Students[Students.Length - 1];
                    Students[Students.Length - 1] = Students[i];
                    Students[i] = student;
                    Array.Resize(ref Students, Students.Length - 1);

                }
                return;
            }
            Console.WriteLine("Id is not found");
        }
        public void Update()
        {
            Console.WriteLine("Please add student  Id");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    while (!Name.CheckLength())
                    {
                        Console.WriteLine(" Student Name is not valid");
                        Name = Console.ReadLine();
                    }
                    Students[i].Name = Name;


                    Console.WriteLine(" Student Surname");
                    string surname = Console.ReadLine();
                    while (!surname.CheckLength())
                    {
                        Console.WriteLine(" Student Surname is not valid");
                        Name = Console.ReadLine();
                    }
                    Students[i].Surname = surname;

                    Console.WriteLine(" Student GroupNo");
                    string GroupNo = Console.ReadLine();
                    while (!GroupNo.CheckLength())
                    {
                        Console.WriteLine(" Student Group is not valid");
                        GroupNo = Console.ReadLine();
                    }
                    Students[i].GroupNo = GroupNo;
                }
                return;
            }
            Console.WriteLine("Id is not found");
        }


        public void GetAll()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter student Id ");
            int id = int.Parse(Console.ReadLine());
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    Console.WriteLine(student.ToString());
                    return;
                }
            }
        }
    }

    }


