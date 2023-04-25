﻿using System.Linq.Expressions;

namespace Trekants_beregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jens was here
            //Tegner trekanten 

            Console.WriteLine("            B\u00B0               ");
            Console.WriteLine("           /\\                    ");
            Console.WriteLine("          /  \\                   ");
            Console.WriteLine("         /    \\                  ");
            Console.WriteLine("      c /      \\ a               ");
            Console.WriteLine("       /        \\                ");
            Console.WriteLine("      /          \\               ");
            Console.WriteLine("     /____________\\              ");
            Console.WriteLine("   A\u00B0       b      C\u00B0   ");

            //Bruger skriver sine kendte værdier ind
            Console.WriteLine();
            Console.WriteLine("Skriv 3 af de kendte størrelser på trekanten som afbilledet");

            //Brugers værdier bliver sorteret alfabetisk 
            string istr = Console.ReadLine();
            char[] charArr = istr.ToCharArray();
            Array.Sort(charArr);
            string sortedStr = new string(charArr);

            //Console.WriteLine(sortedStr);

            double A=0, B=0, C=0, a=0, b=0, c = 0;

            switch (charArr[0])
            {
                case 'A':
                    A = GetValidDouble("Indtast din A værdi : ");
                    break;

                case 'B':
                    B = GetValidDouble("Indtast din B værdi : ");
                    break;

                case 'C':
                    C = GetValidDouble("Indtast din C værdi : ");
                    break;

                case 'a':
                    a = GetValidDouble("Indtast din a værdi : ");
                    break;

                case 'b':
                    b = GetValidDouble("Indtast din b værdi : ");
                    break;

                case 'c':
                    c = GetValidDouble("Indtast din c værdi : ");
                    break;
                default:
                    break;
            }

            switch (charArr[1])
            {
                case 'a':
                    a = GetValidDouble("Indtast din a værdi : ");
                    break;

                case 'b':
                    b = GetValidDouble("Indtast din b værdi : ");
                    break;

                case 'c':
                    c = GetValidDouble("Indtast din c værdi : ");
                    break;

                case 'A':
                    A = GetValidDouble("Indtast din A værdi : ");
                    break;

                case 'B':
                    B = GetValidDouble("Indtast din B værdi : ");
                    break;

                case 'C':
                    C = GetValidDouble("Indtast din C værdi : ");
                    break;
                default:
                    break;
            }

            switch (charArr[2])
            {
                case 'a':
                    a = GetValidDouble("Indtast din a værdi : ");
                    break;

                case 'b':
                    b = GetValidDouble("Indtast din b værdi : ");
                    break;

                case 'c':
                    c = GetValidDouble("Indtast din c værdi : ");
                    break;

                case 'A':
                    A = GetValidDouble("Indtast din A værdi : ");
                    break;

                case 'B':
                    B = GetValidDouble("Indtast din B værdi : ");
                    break;

                case 'C':
                    C = GetValidDouble("Indtast din C værdi : ");
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            switch (sortedStr)
            {
                case "abc":
                    A=((b * b + c * c - a * a) / (2 * b * c));
                    Console.WriteLine("A =  " + Math.Acos(A)* 180 / Math.PI + "\u00b0"); 
                    
                    B= ((a * a + c * c - b * b) / (2 * a * c));
                    Console.WriteLine("B =  " + Math.Acos(B) * 180 / Math.PI + "\u00b0");

                    C = ((a * a + b * b - c * c) / (2 * a * b));
                    Console.WriteLine("C =  " + Math.Acos(C) * 180 / Math.PI + "\u00b0");

                    break;



















































































                case "ABa":
                    C = 180 - A - B;
                    Console.WriteLine("C = " + C);
                    b = a / (Math.Sin(A * Math.PI / 180)) * (Math.Sin(B * Math.PI / 180));
                    Console.WriteLine("b = " + b);
                    c = a / (Math.Sin(A * Math.PI / 180)) * (Math.Sin(C * Math.PI / 180));
                    Console.WriteLine("c = " + c);

                    Console.ReadLine();
                    break;


                case "ABb":
                    C = 180 - A - B;
                    Console.WriteLine("C = " + C);
                    a = b / (Math.Sin(B * Math.PI / 180)) * (Math.Sin(A * Math.PI / 180));
                    Console.WriteLine("a = " + a);
                    c = b / (Math.Sin(B * Math.PI / 180)) * (Math.Sin(C * Math.PI / 180));
                    Console.WriteLine("c = " + c);

                    Console.ReadLine();
                    break; 

                case "ABc":
                    C = 180 - A - B;
                    Console.WriteLine("C = " + C);
                    a = c / (Math.Sin(C* Math.PI / 180)) * (Math.Sin(A* Math.PI / 180));
                    Console.WriteLine("a = " + a);
                    b = c / (Math.Sin(C * Math.PI / 180)) * (Math.Sin(B * Math.PI / 180));
                    Console.WriteLine("b = " + b);

                    Console.ReadLine();
                    break;

                case "ACa":
                    B = 180 - A - C;
                    Console.WriteLine("B = " + B);
                    b = a / (Math.Sin(A * Math.PI / 180)) * (Math.Sin(B * Math.PI / 180));
                    Console.WriteLine("b = " + b);
                    c = a / (Math.Sin(A * Math.PI / 180)) * (Math.Sin(C * Math.PI / 180));
                    Console.WriteLine("c = " + c);

                    Console.ReadLine();
                    break;

                case "ACb":
                    B = 180 - A - C;
                    Console.WriteLine("B = " + B);
                    a = b / (Math.Sin(B * Math.PI / 180)) * (Math.Sin(A * Math.PI / 180));
                    Console.WriteLine("a = " + a);
                    c = b / (Math.Sin(B * Math.PI / 180)) * (Math.Sin(C * Math.PI / 180));
                    Console.WriteLine("c = " + c);

                    Console.ReadLine();
                    break;

                case "ACc":
                    B = 180 - A - C;
                    Console.WriteLine("B = " + B);
                    a = c / (Math.Sin(C * Math.PI / 180)) * (Math.Sin(A * Math.PI / 180));
                    Console.WriteLine("a = " + a);
                    b = c / (Math.Sin(C * Math.PI / 180)) * (Math.Sin(B * Math.PI / 180));
                    Console.WriteLine("b = " + b);

                    Console.ReadLine();
                    break;

                case "BCa":
                    A = 180 - B - C;
                    Console.WriteLine("A = " + A);
                    b = a / (Math.Sin(A * Math.PI / 180)) * (Math.Sin(B * Math.PI / 180));
                    Console.WriteLine("b = " + b);
                    c = a / (Math.Sin(A * Math.PI / 180)) * (Math.Sin(C * Math.PI / 180));
                    Console.WriteLine("c = " + c);

                    Console.ReadLine();
                    break;

                case "BCb":
                    A = 180 - B - C;
                    Console.WriteLine("A = " + A);
                    a = b / (Math.Sin(B * Math.PI / 180)) * (Math.Sin(A * Math.PI / 180));
                    Console.WriteLine("a = " + a);
                    c = b / (Math.Sin(B * Math.PI / 180)) * (Math.Sin(C * Math.PI / 180));
                    Console.WriteLine("c = " + c);

                    Console.ReadLine();
                    break;

                case "BCc":
                    A = 180 - B - C;
                    Console.WriteLine("A = " + A);
                    a = c / (Math.Sin(C * Math.PI / 180)) * (Math.Sin(A * Math.PI / 180));
                    Console.WriteLine("a = " + a);
                    b = c / (Math.Sin(C * Math.PI / 180)) * (Math.Sin(B * Math.PI / 180));
                    Console.WriteLine("b = " + b);

                    Console.ReadLine();
                    break;




            }

        }

        private static double GetValidDouble(string prompt)
        {
            double userInput= 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine(prompt + " ");
                string InputString = Console.ReadLine(); 
                validInput = double.TryParse(InputString, out userInput);
                if (!validInput)
                {
                    Console.WriteLine("Indtast rigtig kommatal med punktum");
                }
            }

            return userInput;            
        }
    }
}