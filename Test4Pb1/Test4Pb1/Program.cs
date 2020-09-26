
/*Două trenuri se află la distanța Z km unul de celălalt. Ele pornesc în același timp unul către celălalt cu o viteză constantă de X km/h.
Când cele două trenuri au parcurs fiecare o pătrime din distanța inițială, o pasăre aflată pe primul tren pornește în zbor către al 2-lea tren cu o viteză de 2X.
Imediat ce a ajuns la el se întoarce către primul și repetă asta până când cele două trenuri se întâlnesc.

Să se scrie o aplicație ce determină care e distanța zburată de pasăre.
Datele de intrare sunt numere întregi și se vor citi de la tastatură, câte un număr pe linie.

Exemplu:
Pentru datele de intrare:
4
10
La consolă se va afișa:
2*/

using System;

namespace Test4Pb1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int totalDistance = Convert.ToInt32(inputData);

            inputData = Console.ReadLine();
            int trainsSpeed = Convert.ToInt32(inputData);

            int birdsSpeed = 2 * trainsSpeed;

            double traveledDistancePerTrain = totalDistance / 2;

            double OneFourthOfDistance = totalDistance * 0.25;

            double remainingDistanceWhenTheBirdStartsFlying = traveledDistancePerTrain - OneFourthOfDistance;

            double distanceFlownByTheBird = (remainingDistanceWhenTheBirdStartsFlying * birdsSpeed) / trainsSpeed;

            Console.WriteLine(distanceFlownByTheBird);
            Console.Read();
        }
    }
}
