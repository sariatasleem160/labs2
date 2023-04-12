using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pr1
{
    class program {
        class students
        {
            public string name;
            public int rollno;
            public float cgpa;
            public char ishostelide;
            public string department;
        }
    }

    static void Main(string[] args)
    {


        students[] s = new students[10];
        char option;
        int count = 0;
        do {
            Options = menu();
            if (option = '1')
            {
                s[count] = addStudents();
                count = count + 1;

            }
            else if (option == '2')
            {
                viewStudents(s, count);
            }
            else if (option = '3')
            {
                topStudents(s, count);
            }
            else if (option = '4')
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            while (option != '4') {
                Console.WriteLine("Press Enter to Exit");
                Console.Read();
            }
        }

        // menu();
        // addstudents();
        // viewstudents();

    }
    // static void addstudents()
    //{
    //  students s1 = new students();
    // Console.WriteLine("Enter name: ");
    //s1.name= Console.ReadLine();
    //Console.WriteLine("Enter rollono: ");
    //s1.rollno =int.Parse(Console.ReadLine());
    // Console.WriteLine("Enter cgpa: ");
    // s1.cgpa = float.Parse(Console.ReadLine());
    // Console.WriteLine("Is hostelides( Y || N");
    // s1.ishostelide = char.Parse(Console.ReadLine());
    //Console.WriteLine("Enter department: ");
    //s1.department = Console.ReadLine();



    //}

    // static char menu()
    // {
    //   Console.Clear();
    //  char choice;
    // Console.WriteLine("Press1 for adding students");
    // Console.WriteLine("Press2 for View students");
    // Console.WriteLine("Press3 for top three students");
    // Console.WriteLine("Press4 to exut");
    // choice = char.Parse(Console.ReadLine());
    // return choice;
    //}
    // static  void viewstudents(students[] s,int count )
    //{
    //  for(int i=0;i<=count; i++)
    // {
    //   Console.WriteLine("Name: {0}, Rollno: {1}, CGPA: {2}, Department: {3},ishostelide: {4}", s1.name, s1.rollno, s1.cgpa, s1.department, s1.ishostelide);
    //}
    //Console.WriteLine("press any key: ");
    //Consle.ReadKey();
    //}

    static void topStudent(students[] s, int count)
    {
        Console.Clear();
        if (count == 0)
        {
            Console.WriteLine("No Record"); }
    }
    else if(count ==  1)
        {
        viewStudents(s,1);
}
else if(count == 2)
{
    for(int i = 0; i < 2; i++)
    {
        int index = largest(s, x, count);
        students temp = s[index];
        s[index]= s[x];
        s[x] = temp;
    }
    viewStudents(s, 2);
}
else
{
    for(int x = 0; x < 3; x++)
    {
        int index = largest(s, x, count);
        students temp = s[index];
        s[index] = s[x];
        s[x] = temp;
    }
    viiewStudents(s, 3);
}
static int ((students[] s,int start,int end){
    int index = start;
    flaot largest = s[start].cgpa;
    for(int x = start; x < end; x++) {
        if(largest < s[x].cgpa)
        {
            largest = s[x].cgpa;
            index = x;
        }

            }

    return index;
}
       
    }




