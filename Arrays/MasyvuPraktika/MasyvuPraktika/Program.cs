﻿using System.Text;

namespace MasyvuPraktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pyramid(5);
            //Reverse(12345);
            //PrintAttendance();
            //PrintAttendanceWithInput();
            //Console.WriteLine(FindRepetitions());
            //FindRepetitionsInTwoDimentionalArray();
            FindRepetitionsInTwoDimentionalArrayString();
        }
        /// <summary>
        /// Uzduotis 1
        /// </summary>
        /// <param name="count"></param>
        public static void Pyramid(int count)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            bool flag = true;
            for (int i = 0; i  < count; i++)
            {
                if (flag)
                {
                    sb1.Insert(0, 1);
                    flag = false;
                }
                else
                {
                    sb1.Insert(0, 0);
                    flag = true;
                }

                sb2.Append(sb1).Append(Environment.NewLine);
            }
            Console.WriteLine(sb2.ToString());
        }
        /// <summary>
        /// Uzduotis 2
        /// </summary>
        /// <param name="number"></param>
        public static void Reverse(int number)
        {
            int reversed = 0;
            while(number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }
           //Console.WriteLine(((0 * 10 + 12345 % 10) * 10 + 1234 % 10));
            Console.WriteLine(reversed);
        }
        /// <summary>
        /// Uzduotis 3
        /// </summary>
        public static void PrintAttendance()
        {
            string[] students = new string[3] { "Edvinas", "Jonas", "Petras" };
            Console.WriteLine("Kiek zmoniu siandien atejo i pamoka.");
            int.TryParse(Console.ReadLine(), out int attendance);

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            if(students.Length == attendance)
            {
                for (int i = students.Length; i > 0; i--)
                {
                    Console.WriteLine(students[i - 1]);
                }
            }
        }
        /// <summary>
        /// Uzduotis 4
        /// </summary>
        public static void PrintAttendanceWithInput()
        {
            int maxLength = 0;
            Console.WriteLine("Kiek zmoniu siandien atejo i pamoka.");
            int.TryParse(Console.ReadLine(), out int attendance);

            string[] students = new string[attendance];

            Console.WriteLine("Iveskite atejusiu mokinius");
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
                if (students[i].Length > maxLength) { maxLength = students[i].Length; }
            }
            Console.WriteLine("-----------");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Length == maxLength) { Console.WriteLine(students[i]); } 
            }
        }
        /// <summary>
        /// Uzduotis 5
        /// </summary>
        public static string FindRepetitions(int[] numbers)
        {
            //int[] numbers = new int[8] { 1, 2, 2, 4, 2, 7, 6, 1 };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && !sb.ToString().Contains(numbers[j].ToString()) && i != j) { sb.Append(numbers[j]).Append(','); }
                }
            }
            return sb.ToString().Trim(',');
        }
        /// <summary>
        /// Uzduotis 6
        /// </summary>
        public static void CreateTwoDimensionalArray()
        {
            Console.WriteLine("Eiluciu kiekis:");
            int.TryParse(Console.ReadLine(), out int rows);
            Console.WriteLine("Stulpeliu kiekis:");
            int.TryParse(Console.ReadLine(), out int column);

            StringBuilder sb = new StringBuilder();

            int[,] matrix = new int[rows, column];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    sb.Append(matrix[i,j]).Append(" ");
                }
                sb.Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// Uzduotis 7
        /// </summary>
        public static void FindRepetitionsInTwoDimentionalArray()
        {
            int[,] numbers = new int[3,3] { { 1, 1, 2},
                                            { 3, 4, 8},
                                            { 5, 4, 7} };
            int arrIndex = 0;
            int[] oneDimesionNumbers = new int[numbers.Length];
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    oneDimesionNumbers[arrIndex] = numbers[i,j];
                    arrIndex++;
                }
            }
            Console.WriteLine(FindRepetitions(oneDimesionNumbers));
        }
        /// <summary>
        /// Uzduotis 8
        /// </summary>
        public static string FindRepetitions(string[] words)
        {
            //int[] numbers = new int[8] { 1, 2, 2, 4, 2, 7, 6, 1 };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i; j < words.Length; j++)
                {
                    if (words[i] == words[j] && !sb.ToString().Contains(words[j].ToString()) && i != j) { sb.Append(words[j]).Append(','); }
                }
            }
            return sb.ToString().Trim(',');
        }
        public static void FindRepetitionsInTwoDimentionalArrayString()
        {
            string[,] words = new string[3, 3] { { "Tauras", "Tomas", "Aurimas"},
                                                   { "Algirdas", "Tauras", "Aurimas"},
                                                   { "Petras", "Arnas", "Povilas"} };
            int arrIndex = 0;
            string[] oneDimesionWords = new string[words.Length];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.GetLength(0); i++)
            {
                for (int j = 0; j < words.GetLength(1); j++)
                {
                    oneDimesionWords[arrIndex] = words[i, j];
                    arrIndex++;
                }
            }
            Console.WriteLine(FindRepetitions(oneDimesionWords));
        }
        /*
         3. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
            Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
            Kada visi vardai buna ivesti programa turetu atspausdinti visu vardus atvirkstine seka.
            Pvz: 
            3
            Edvinas
            Jonas
            Petras
            Petras
            Jonas
            Edvinas
         */
        /*
           4. Parasykite programa, kuri leistu ivesti kiek zmoniu siandiena atejo i pamoka. 
        Ivedus skaiciu programa prasytu ivesti visu atejusiu zmoniu vardus. 
        Kada visi vardai buna ivesti programa turetu atspausdinti ilgiausia varda ekrane. 
        Jei vardai yra vienodo ilgio turetu atspausdinti abu vardus.            
        Pvz:             
        3            
        Edvinas            
        Jonas            
        Petras
        ---------------------            
        Edvinas
         */
        /*
         * 5. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame masyve ir juos atvaizduotu ekrane
         * PVZ: 1,2,2,4,2,7,6,1
         * Pasikartojantys skaiciai: 1, 2
         */
        /*
         *  6. Programa praso ivesti eiluciu ir stulpeliu kieki. 
         *  Ivedus turetu sukurti masyva duoto dydzio, paprasyti ivesti kiekvieno elemento skaiciu/reiksme ir atspausdintu matrica is pateiktu skaiciu
            PVZ: Ivedame 2 2. Suvedame 1, 2, 2, 3
                 1 2
                 2 3
         */
        /*
         * 7. Parasykite programa, kuri rastu visus pasikartojancius skaicius duotame dvimaciame masyve ir juos atvaizduotu ekrane
         */
        /*
         * 8. Parasykite programa, kuri rastu visus pasikartojancius vardus duotame dvimaciame masyve ir juos atvaizduotu ekrane
         */
    }
}