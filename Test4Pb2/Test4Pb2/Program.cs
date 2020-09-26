/*Trebuie pus parchet laminat într-o cameră de N x M mp.
Dimensiunea unei plăci de parchet e de A x B mp.
Pierderile sunt de 15%.
Scrie o aplicație care calculează de cât parchet e nevoie.
Datele de intrare sunt numere întregi și se vor citi de la tastatură, câte un număr pe linie, în următoarea ordine: N, M, A, B.
Exemplu:
Pentru datele de intrare:
2
3
1
2
La consolă se va afișa:
4*/

using System;

namespace Test4Pb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputdata = Console.ReadLine();
            int widthRoom = Convert.ToInt32(inputdata);

            inputdata = Console.ReadLine();
            int lengthRoom = Convert.ToInt32(inputdata);

            inputdata = Console.ReadLine();
            int widthTile = Convert.ToInt32(inputdata);

            inputdata = Console.ReadLine();
            int lengthTile = Convert.ToInt32(inputdata);

            double roomSqm = (double)lengthRoom * widthRoom;

            double tileSqm = (double)lengthTile * widthTile;

            double wasteInPercentage = (double) 15 / 100;

            double wasteTiles = (double) ((roomSqm / tileSqm) * wasteInPercentage);

            double totalTiles = Math.Ceiling ((roomSqm / tileSqm) + wasteTiles);

            Console.WriteLine(totalTiles);
            Console.Read();
        }
    }
}
