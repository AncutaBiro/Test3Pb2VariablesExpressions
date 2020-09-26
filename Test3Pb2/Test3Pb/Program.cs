// Un grup de X elevi au plantaat impreuna Y copaci in T time. Pastrand acelasi ritm de lucru, sa se determine de cati elevi va fi nevoie sa fie plantanti inca Z copaci in Q zile.
//Datele de intrare se introduc de la tastatura.
//   Ex:
// 2
// 6
// 3
// 10
// 2
// Rezultat:
// 5

using System;

namespace Test3Pb
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int FirstSessionStudentsNo = Convert.ToInt32(inputData);

            inputData = Console.ReadLine();
            int FirstSessionTreesNo = Convert.ToInt32(inputData);

            inputData = Console.ReadLine();
            int FirstSessionDaysNo = Convert.ToInt32(inputData);


            inputData = Console.ReadLine();
            int SecondSessionTreesNo = Convert.ToInt32(inputData);

            inputData = Console.ReadLine();
            int SecondSessionDaysNo = Convert.ToInt32(inputData);

            int FirstSessionTreesPerDay = FirstSessionTreesNo / FirstSessionDaysNo;
            int SecondSessionTreesPerDay = SecondSessionTreesNo / SecondSessionDaysNo;

            int SecondSessionStudensNo = (SecondSessionTreesPerDay * FirstSessionStudentsNo) / FirstSessionTreesPerDay;

            Console.WriteLine(SecondSessionStudensNo);
            Console.Read();
        }
    }
}
