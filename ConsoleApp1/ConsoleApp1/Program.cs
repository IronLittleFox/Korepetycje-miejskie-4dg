using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] arrayOfNumbers = new int[10];

        static void Main(string[] args)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.WriteLine($"Podaj {i} element");
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            /*
            //for (int i = 0; i < arrayOfNumbers.Length;)
            int i = 0;
            while(i < arrayOfNumbers.Length)
            {
                Console.WriteLine($"Podaj {i} element");
                string strNumber = Console.ReadLine();
                if (int.TryParse(strNumber, out int number))
                {
                    arrayOfNumbers[i] = number;
                    i++;
                }
            }
            */

            Sort();

            Console.WriteLine("Posortowana tablica:");
            foreach (int item in arrayOfNumbers)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", arrayOfNumbers));

        }

        /********************************************************
        * nazwa funkcji: FindMaxIndex
        * parametry wejściowe: startIndex - indeks od którego szukamy wartości maksymalnej
        * wartość zwracana: indeks wartości maksymalnej
        * autor: <numer PESEL zdającego>
        * ****************************************************/
        private static int FindMaxIndex(int startIndex)
        {
            int findMaxIndex = startIndex;
            for (int i = startIndex +1; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > arrayOfNumbers[findMaxIndex])
                    findMaxIndex = i;
            }
            return findMaxIndex;
        }

        /********************************************************
        * nazwa funkcji: Sort
        * parametry wejściowe: brak
        * wartość zwracana: brak
        * autor: <numer PESEL zdającego>
        * ****************************************************/
        private static void Sort()
        {
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                int maxIndex = FindMaxIndex(i);

                int tmp = arrayOfNumbers[i];
                arrayOfNumbers[i] = arrayOfNumbers[maxIndex];
                arrayOfNumbers[maxIndex] = tmp;
            }
        }
    }
}
