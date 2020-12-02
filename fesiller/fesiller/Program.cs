using System;
using System.Runtime.InteropServices;

namespace fesiller
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IFs and LOOPS

            //int[] aylar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //for (int i = 1; i <= aylar.Length; i++)
            //{
            //    Console.WriteLine("Ay nomre: " + i);

            //    if (i == 12 || i == 1 || i == 2)
            //    {
            //        Console.WriteLine("Winter");
            //    }

            //    if (i == 3 || i == 4 || i == 5)
            //    {
            //        Console.WriteLine("Spring");
            //    }

            //    if (i == 6 || i == 7 || i == 8)
            //    {
            //        Console.WriteLine("Summer");
            //    }

            //    if (i == 9 || i == 10 || i == 11)
            //    {
            //        Console.WriteLine("Autumn");
            //    }
            //}

            //int age = 66;


            //if (age > 65)
            //    Console.WriteLine("Old");
            //else if (age > 18)
            //    Console.WriteLine("Adult");
            //else if (age > 0)
            //    Console.WriteLine("kid");


            //Console.WriteLine("Hello World!");

            // Methods and Functions 
            #endregion


            //PrintName();
            //PrintName2();

            //string fName = ReturnFullName();
            // int sum = CalculateSum();
            // Console.WriteLine(sum);

            //Elovset(5, 6, fName);
            //Console.WriteLine(CalculateSalary(50, 3433.20m));
            //Console.WriteLine(CalculateSalary(40, 3433.20m, "Eldar"));
            //Console.WriteLine(CalculateSalary(10));

            int age = 16;

            var student1 = new Student();


            Console.WriteLine(student1.FullName());



            student1.Age = 15;
            student1.Name = "Sadiq";
            student1.GroupName = "P119";
            student1.StartTime = 9;
            student1.EndTime = 12;
            student1.Occupation = "Telebe";


            var student2 = new Student
            {
                Age = 30,
                Name = "Sadiq",
                //student2.Surname = "Abdullayev";
                GroupName = "P119",
                StartTime = 9,
                EndTime = 12,
                Occupation = "Telebe"
            };

            Console.WriteLine(student1.Occupation);
            Console.WriteLine(student2.Occupation);
            Console.WriteLine(student1.FullName());
        }



        class Student 
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public byte Age { get; set; }
            public string GroupName { get; set; }
            public int StartTime { get; set; }
            public int EndTime { get; set; }
            public string Occupation { get; set; }


            public string FullName()
            {
                return Name + " " + Surname;
            }
        }







        public static string CalculateSalary(int day, decimal dailyRate = 200, string name = "Anonym")
        {
            var salary = day * dailyRate;

            if (name == null)
                return salary.ToString();
            else
            {
                return "fghjklò" + salary.ToString();
            }


            return "asdasda";
        }








        public static int Elovset(int a, int b, string c)
        {

            return a * b;
        }

        public static void PrintName()
        {
            Console.WriteLine("Some words ");
            Console.WriteLine("SOme more words to make you happy ");
            PrintName2();
            Console.WriteLine("SOme more words to make you happy ");
            Console.WriteLine("SOme more words to make you happy ");

        }

        public static void PrintName2()
        {
            Console.WriteLine("asdasd2345678");
            Console.WriteLine("asdasd ");
            Console.WriteLine("asdasd ");
            Console.WriteLine("adfghjkl");
        }

        public static string ReturnFullName()
        {
            string firstName = "Eldar";
            string lastName = "Alasgarov";
            // string fullName = firstName + " " + lastName;

            return firstName + " " + lastName;
        }

        public static int CalculateSum()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            return a + b;
        }
    }
}
