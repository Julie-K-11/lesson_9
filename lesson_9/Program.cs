using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------1---------------------------------");
            int[] numbers = { 1, 12, 45, 67, 13, 0, 8, 45, 3, 101, 18, 29, 1, 30, 14, 21, 16, 88, 49 };

            Console.WriteLine("\nМасив : ");
            Show(numbers);

            Console.WriteLine("\nПарні цисла : ");
            var evenNums = numbers.Where(n => n % 2 == 0);
            Show(evenNums);

            Console.WriteLine("\nНепарні цілі : ");
            var oddNums = numbers.Where(n => n % 2 != 0);
            Show(oddNums);

            Console.Write("\nВведіть число : ");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Числа, що більші за {userNum} : ");
            var greaterNums = numbers.Where(n => n > userNum);
            Show(greaterNums);

            Console.Write("\nВведіть початок діапазону : ");
            int lowerNums = int.Parse(Console.ReadLine());

            Console.Write("Введіть кінець діапазону : ");
            int upperNums = int.Parse(Console.ReadLine());

            if (lowerNums > upperNums)
            {
                (lowerNums, upperNums) = (upperNums, lowerNums);
            }

            Console.WriteLine($"Числа в діапазоні від {lowerNums} до {upperNums} : ");
            var rangeNums = numbers.Where(n => n >= lowerNums && n <= upperNums);
            Show(rangeNums);

            Console.WriteLine("\nЧисла, кратні семи, відсортовані за зростанням : ");
            var multiplesNumsOfSeven = numbers.Where(n => n % 7 == 0)
                                            .OrderBy(n => n);
            Show(multiplesNumsOfSeven);

            Console.WriteLine("\nЧисла, кратні восьми, відсортовані за спаданням : ");
            var multiplesNumsOfEight = numbers.Where(n => n % 8 == 0)
                                            .OrderByDescending(n => n);
            Show(multiplesNumsOfEight);

            Console.WriteLine("\n---------------------------------2---------------------------------");
            string[] cities = { "Neyyattinkara", "Berlin", "Mexico City", "Tokyo", "Newark", "Rome", "Kyiv", "Atlanta", "Rockingham", "Nehe", "Manchester", "Asaka", "Nashik", "Yanam" };

            Console.WriteLine("\nМіста : ");
            Show(cities);

            Console.Write("\nВведіть довжину назви : ");
            int nameLength = int.Parse(Console.ReadLine());
            var citiesLength = cities.Where(city => city.Length == nameLength);
            Show(citiesLength);

            Console.WriteLine("\nМіста, з літери A : ");
            var citiesStartingWithA = cities.Where(city => city.StartsWith("A"));
            Show(citiesStartingWithA);

            Console.WriteLine("\nМіста, назви яких закінчуються літерою M : ");
            var citiesEndingWithM = cities.Where(city => city.EndsWith("m"));
            Show(citiesEndingWithM);

            Console.WriteLine("\nМіста, назви яких починаються з літери N і закінчуються літерою K : ");
            var citiesStartingWithNEndingWithK = cities.Where(city => city.StartsWith("N") && city.EndsWith("k"));
            Show(citiesStartingWithNEndingWithK);

            Console.WriteLine("\nМіста, назви яких починаються з Ne : ");
            var citiesStartingWithNe = cities.Where(city => city.StartsWith("Ne"))
                                             .OrderByDescending(city => city);
            Show(citiesStartingWithNe);

            Console.WriteLine("\n---------------------------------3---------------------------------");

            var students = new[] {
                new Student { Name = "Boris", Surname = "Smith", Age = 18, University = "Oxford" },
                new Student { Name = "Mia", Surname = "Jones", Age = 17, University = "Oxford" },
                new Student { Name = "Brody", Surname = "Brown", Age = 21, University = "MIT" },
                new Student { Name = "Michael", Surname = "Brooks", Age = 19, University = "MIT" },
                new Student { Name = "Jack", Surname = "Smith", Age = 22, University = "Oxford" },
                new Student { Name = "Emma", Surname = "Miller", Age = 28, University = "MIT" },
                new Student { Name = "Ann", Surname = "Baker", Age = 19, University = "Oxford" }
            };

            Console.WriteLine("Студенти : ");
            ShowStudent(students);

            Console.WriteLine("Студенти з ім'ям Boris : ");
            var namedBoris = students.Where(student => student.Name == "Boris");
            ShowStudent(namedBoris);

            Console.WriteLine("Студенти з прізвищем, яке починається з Bro:");
            var surnameBro = students.Where(student => student.Surname.StartsWith("Bro"));
            ShowStudent(surnameBro);

            Console.WriteLine("Студенти, старші 19 років:");
            var olderThan19 = students.Where(student => student.Age > 19);
            ShowStudent(olderThan19);

            Console.WriteLine("Студенти, старші 20 років і молодші 23 років : ");
            var between20And23 = students.Where(student => student.Age > 20 && student.Age < 23);
            ShowStudent(between20And23);

            Console.WriteLine("Студенти, які навчаються в MIT : ");
            var uniMIT = students.Where(student => student.University == "MIT");
            ShowStudent(uniMIT);

            Console.WriteLine("Студенти, які навчаються в Oxford і старші за 18 років : ");
            var uniOxfordOlderThan18 = students.Where(student => student.University == "Oxford" && student.Age > 18)
                                               .OrderByDescending(student => student.Age);
            ShowStudent(uniOxfordOlderThan18);

            Console.WriteLine();
            Console.ReadKey();

        }
        static void Show<T>(IEnumerable<T> items)
        {
            foreach (var i in items)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void ShowStudent(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Ім'я : {student.Name}");
                Console.WriteLine($"Прізвище : {student.Surname}");
                Console.WriteLine($"Вік : {student.Age}");
                Console.WriteLine($"Університет : {student.University}");
                Console.WriteLine();
            }
        }
    }
}
