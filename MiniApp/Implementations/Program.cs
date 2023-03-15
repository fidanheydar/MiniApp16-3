Console.WriteLine();

StudentService studentService = new StudentService();
TeacherService teacherService=new TeacherService();








Console.WriteLine("0- Exit");
Console.WriteLine("1- Create student");
Console.WriteLine("2- Show Students");
Console.WriteLine("3- Get with Id for students");
Console.WriteLine("4- Delete Student");
Console.WriteLine("5- Update a student");
Console.WriteLine("Next for Teacher");
Console.WriteLine("7- Create Tacher");
Console.WriteLine("8- Show Teachers");
Console.WriteLine("9 - Delete Teacher");
Console.WriteLine("10- Update a Teacher");

string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            studentService.Create(); break;
        case "2":
            studentService.GetAll(); break;
        case "3":
            studentService.GetById(); break;
        case "4":
            studentService.Delete(); break;
        case "5":
            studentService.Update(); break;
        case "6":
            teacherService.Create(); break;
        case "7":
            teacherService.GetAll(); break;
        case "8":
            teacherService.GetById(); break;
        case "9":
            teacherService.Delete(); break;
        case "10":
            teacherService.Update(); break;
    }




    Console.WriteLine("0- Exit");
    Console.WriteLine("1- Create student");
    Console.WriteLine("2- Show Students");
    Console.WriteLine("3- Get with Id for students");
    Console.WriteLine("4- Delete Student");
    Console.WriteLine("5- Update a student");
    Console.WriteLine("Next for Teacher");
    Console.WriteLine("7- Create Tacher");
    Console.WriteLine("8- Show Teachers");
    Console.WriteLine("9 - Delete Teacher");
    Console.WriteLine("10- Update a Teacher");

    request = Console.ReadLine();
}

