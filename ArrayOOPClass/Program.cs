using System;

namespace ArrayOOPClass
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Array
            //int[] numbers = new int[6];
            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[2] = 100;
            //numbers[10] = 66;

            //Array.Resize(ref numbers, 20);

            //int[] nums = { 1, 2, 5, 6, 7, 55, 25 };
            //Array.Sort(nums);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] arr = {
            //    { 2, 13 },
            //    { 3, 4 },
            //    { 5, 6 }
            //};

            //Console.WriteLine(arr[1, 1]);
            //Console.WriteLine(nums.Rank);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            //string name1 = "Orxan";
            //string surname1 = "Akbarov";
            //int age1 = 26;

            //string name2 = "Emil";
            //string surname2 = "Abdullayev";
            //int age2 = 20;

            //string name3 = "Fidan";
            //string surname3 = "Mardanli";
            //int age3 = 17;


            //Console.WriteLine(name1 + " " + surname1);


            //var obj1 = new
            //{
            //    name = "Orxan",
            //    surname = "Akbarov",
            //    age = 26
            //};

            //var obj2 = new
            //{
            //    name = "Emil",
            //    surname = "Abdullayev",
            //    age = 20
            //};

            //Console.WriteLine(obj2.name+ " " + obj2.surname);
            //Console.WriteLine($"{obj2.name} {obj2.surname} Age: {obj2.age}");







            Student st1 = new Student(77, "Buzovna");
            st1.name = "Orxan";
            st1.surname = "Akbarov";
            st1.age = 26;

            //Student st2 = new Student();
            //st2.name = "Emil";
            //st2.surname = "Abdullayev";
            //st2.age = 20;

            //Console.WriteLine(st1.FullName());
            //Console.WriteLine(st1.FullData());

            //Student st3 = new Student
            //{
            //    name = "Fuad",
            //    surname = "Dadashov",
            //    age = 28
            //};

            Student student = new Student();
            student.name = "Orxan";

            Console.WriteLine(student.GetGroupInfo());






        }
        
    }
}
