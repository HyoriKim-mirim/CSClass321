using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass32
{
    internal class Program
    {
        private static int width;

        static void Main(string[] args)
        {
            /*            
                        Car car = new Car();
                        car.SetInTime();
                        car.SetOutTime();

                        Random random = new Random();
                        Console.WriteLine(random.Next(10, 100));
                        Console.WriteLine(random.Next(10, 100));
                        Console.WriteLine(random.Next(10, 100));
                        Console.WriteLine(random.Next(10, 100));

                        Console.WriteLine(random.NextDouble());
                        Console.WriteLine(random.NextDouble() * 10);

                        *//*List<int> list = new List<int>();
                                    list.Add(52);
                                    list.Add(273); 
                                    list.Add(32); 
                                    list.Add(64);*//*
                        List<int> list = new List<int>() { 54, 273, 32, 24 };
                        list.Remove(52);

                        foreach (var item in list)
                        {
                            Console.WriteLine("Count: " + list.Count + "\titem: " + item);
                        }

                        Console.WriteLine(Math.Abs(-52273));
                        Console.WriteLine(Math.Ceiling(52.273));
                        Console.WriteLine(Math.Floor(52.273));
                        Console.WriteLine(Math.Max(52, 273));
                        Console.WriteLine(Math.Min(52, 273));
                        Console.WriteLine(Math.Round(52.273));
                        Console.WriteLine(Math.PI);

                        Hamburger nyam = new Hamburger();

                        Product productA = new Product();

                        productA.name = "포켓몬빵";
                        productA.price = 1500;
                        //인스턴스 변수를 생성과 동시에 초기회 (C# 고유 문법)
                        Product productB = new Product() { name = "소금빵", price = 2000 };
                        Product productC = new Product() { price = 5500, name = "당근케이크" };
                        Product productD = new Product() { name = "보름달" };*/


            /*
            students.Add(new Student() { name = "함기훈", grade = 1 });
            students.Add(new Student() { name = "김미나", grade = 2 });
            students.Add(new Student() { name = "김다흰", grade = 2 });
            students.Add(new Student() { name = "김민정", grade = 3 });
            students.Add(new Student() { name = "김세린", grade = 3 });
            students.Add(new Student() { name = "김소연", grade = 1 });
            students.Add(new Student() { name = "김지수", grade = 1 });
            students.Add(new Student() { name = "김지호", grade = 2 });
            students.Add(new Student() { name = "김찬희", grade = 3 });
            students.Add(new Student() { name = "김하늘", grade = 2 });
            students.Add(new Student() { name = "김효리", grade = 1 });*/

            /*            List<Student> students = new List<Student>() {
                        new Student() { name = "함기훈", grade = 1 },
                        new Student() { name = "김미나", grade = 2 },
                        new Student() { name = "김다흰", grade = 2 },
                        new Student() { name = "김민정", grade = 3 },
                        new Student() { name = "김세린", grade = 3 },
                        new Student() { name = "김소연", grade = 1 },
                        new Student() { name = "김지수", grade = 1 },
                        new Student() { name = "김지호", grade = 2 },
                        new Student() { name = "김찬희", grade = 3 },
                        new Student() { name = "김하늘", grade = 2 },
                        new Student() { name = "김효리", grade = 1 }
                    };*/
            /*
                        foreach (var item in students)
                        {
                            if(item.grade > 2)
                            {
                                students.Remove(item);
                            }
                        }*/

            /*            for (int i =0; i<students.Count; i++)
                        {
                            if(students[i].grade > 2)
                            {
                                students.RemoveAt(i);
                                i--;
                            }
                        }*/

            /*            for(int i= students.Count -1; i>=0; i--)
                        {
                            if (students[i].grade > 2)
                            {
                                students.RemoveAt(i);
                            }
                        }
                        foreach (var item in students)
                        {
                            Console.WriteLine(item);
                        }*/

            Method method = new Method();
            Console.WriteLine(method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 10));
            Console.WriteLine(method.Abs(-100));
            Console.WriteLine(method.Abs(100));
            Console.WriteLine(method.Abs(100)); //Java는 가능 C#은 불가능

            Box1 box1 = new Box1(10, 10);
            box1.width = -10;
            Console.WriteLine("box1의 면적은 :" + box1.Area());

            Box2 box2 = new Box2(10, 10);
            box2.setWidth(-10);
            Console.WriteLine("box2의 면적은 :" + box1.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적은 :" + box.Area());


            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(100));
            Console.WriteLine(Fibonacci.Get(1000));
            Console.WriteLine(Fibonacci.Get(10000));

            //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog()};
            // List<Cat> Cats = new List<Cat>() { new Cat(), new Cat() };
            List<Animal> animals = new List<Animal>()
           {
               new Dog(), new Dog(), new Dog(),
               new Cat(), new Cat(), new Cat()
           };
            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();
                ((Dog)item).Bark();
            }

        }
    }
}
