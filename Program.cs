using System.Linq.Expressions;

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

            double A = 0, B = 0, C = 0, a = 0, b = 0, c = 0, C2 = 0, B2 = 0, A2 = 0, a2 = 0, b2 = 0, c2 = 0;
            double tjek = 0;

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

                case "Abc":

                    a= (Math.Pow(b, 2) + Math.Pow(c, 2) - 2 * b * c * Math.Cos(A*Math.PI / 180));
                    a = Math.Sqrt(a);
                    Console.WriteLine("a =" + a );

                    B= ((a * a + c * c - b * b) / (2 * a * c));
                    Console.WriteLine("B =  " + (Math.Acos(B) * 180 / Math.PI) + "\u00b0");

                    C = ((a * a + b * b - c * c) / (2 * a * b));
                    Console.WriteLine("C =  " + Math.Acos(C) * 180 / Math.PI + "\u00b0");

                    break;

                case "Bac":

                    b = (Math.Pow(a, 2) + Math.Pow(c, 2) - 2 * a * c * Math.Cos(B * Math.PI / 180));
                    b = Math.Sqrt(b);
                    Console.WriteLine("b = " + b);


                    A = ((b * b + c * c - a * a) / (2 * b * c));
                    Console.WriteLine("A =  " + Math.Acos(A) * 180 / Math.PI + "\u00b0");

                    C = ((a * a + b * b - c * c) / (2 * a * b));
                    Console.WriteLine("C =  " + Math.Acos(C) * 180 / Math.PI + "\u00b0"); 

                    break;

                case "Cab":

                    c = (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(C * Math.PI / 180));
                    c = Math.Sqrt(c);
                    Console.WriteLine("c = " + c);

                    A = ((b * b + c * c - a * a) / (2 * b * c));
                    Console.WriteLine("A =  " + Math.Acos(A) * 180 / Math.PI + "\u00b0");

                    B = ((a * a + c * c - b * b) / (2 * a * c));
                    Console.WriteLine("B =  " + (Math.Acos(B) * 180 / Math.PI) + "\u00b0");

                    break;

                case "Aac":

                    tjek = c * Math.Sin(A * Math.PI / 180) / a;
                        if(tjek < -1|| tjek > 1)
                    {

                        Console.WriteLine(" Din trekant er ikke eksisterende");

                    } 
                        else
                    {
                        Console.WriteLine("Bemærk, din trekant har 2 løsninger!"); 


                        C = (Math.Asin(c * Math.Sin(A * Math.PI / 180) / a) * (180 / Math.PI));
                        C2 = 180 - C;

                        B = 180 - C - A;
                        B2 = 180 - C2 - A;


                        b = (Math.Pow(a, 2) + Math.Pow(c, 2) - 2 * a * c * Math.Cos(B * Math.PI / 180));
                        b = Math.Sqrt(b);

                        b2 = (Math.Pow(a, 2) + Math.Pow(c, 2) - 2 * a * c * Math.Cos(B2 * Math.PI / 180));
                        b2 = Math.Sqrt(b2);

                        Console.WriteLine("Trekant 1");
                        Console.WriteLine("C =" + C);
                        Console.WriteLine("B = " + B);
                        Console.WriteLine("b = " + b);
                        Console.WriteLine();
                        Console.WriteLine("Trekant 2");
                        Console.WriteLine("C2 =" + C2);
                        Console.WriteLine("B2 = " + B2);
                        Console.WriteLine("b2 = " + b2);

                    }      
                    break;
                case "Aab":

                    tjek = b * Math.Sin(A * Math.PI / 180) / a;
                    if (tjek < -1 || tjek > 1)
                    {

                        Console.WriteLine(" Din trekant er ikke eksisterende");

                    }
                    else
                    {
                        Console.WriteLine("Bemærk, din trekant har 2 løsninger!");


                        B = (Math.Asin(b * Math.Sin(A * Math.PI / 180) / a) * (180 / Math.PI));
                        B2 = 180 - B;

                        C = 180 - B - A;
                        C2 = 180 - A - B2;


                        c = (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(C * Math.PI / 180));
                        c = Math.Sqrt(c);

                        c2 = (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(C2 * Math.PI / 180));
                        c2 = Math.Sqrt(c2);

                        Console.WriteLine("Trekant 1");
                        Console.WriteLine("C =" + C);
                        Console.WriteLine("B = " + B);
                        Console.WriteLine("c = " + c);
                        Console.WriteLine();
                        Console.WriteLine("Trekant 2");
                        Console.WriteLine("C2 =" + C2);
                        Console.WriteLine("B2 = " + B2);
                        Console.WriteLine("c2 = " + c2);

                    }
                    break;

                case "Bbc":

                    tjek = c * Math.Sin(B * Math.PI / 180) / b;
                    if (tjek < -1 || tjek > 1)
                    {

                        Console.WriteLine(" Din trekant er ikke eksisterende");

                    }
                    else
                    {
                        Console.WriteLine("Bemærk, din trekant har 2 løsninger!");


                        C = (Math.Asin(c * Math.Sin(B * Math.PI / 180) / b) * (180 / Math.PI));
                        C2 = 180 - C;

                        A = 180 - B - C;
                        A2 = 180 - B - C2;


                        a = (Math.Pow(c, 2) + Math.Pow(b, 2) - 2 * c * b * Math.Cos(A * Math.PI / 180));
                        a = Math.Sqrt(a);

                        a2 = (Math.Pow(c, 2) + Math.Pow(b, 2) - 2 * c * b * Math.Cos(A2 * Math.PI / 180));
                        a2 = Math.Sqrt(a2);

                        Console.WriteLine("Trekant 1");
                        Console.WriteLine("A =" +  A);
                        Console.WriteLine("C = " + C);
                        Console.WriteLine("a = " + a);
                        Console.WriteLine();
                        Console.WriteLine("Trekant 2");
                        Console.WriteLine("A2 =" +  A2);
                        Console.WriteLine("C2 = " + C2);
                        Console.WriteLine("a2 = " + a2);

                    }
                    break;

                case "Bab":

                    tjek = a * Math.Sin(B * Math.PI / 180) / b;
                    if (tjek < -1 || tjek > 1)
                    {

                        Console.WriteLine(" Din trekant er ikke eksisterende");

                    }
                    else
                    {
                        Console.WriteLine("Bemærk, din trekant har 2 løsninger!");


                        A = (Math.Asin(a * Math.Sin(B * Math.PI / 180) / b) * (180 / Math.PI));
                        A2 = 180 - A;

                        C = 180 - B - A;
                        C2 = 180 - B - A2;


                        c = (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(C * Math.PI / 180));
                        c = Math.Sqrt(c);

                        c2 = (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(C2 * Math.PI / 180));
                        c2 = Math.Sqrt(c2);

                        Console.WriteLine("Trekant 1");
                        Console.WriteLine("A =" +  A);
                        Console.WriteLine("C = " + C);
                        Console.WriteLine("c = " + c);
                        Console.WriteLine();
                        Console.WriteLine("Trekant 2");
                        Console.WriteLine("A2 =" +  A2);
                        Console.WriteLine("C2 = " + C2);
                        Console.WriteLine("c2 = " + c2);
                    }
                    break;

                case "Cbc":

                    tjek = b * Math.Sin(C * Math.PI / 180) / c;
                    if (tjek < -1 || tjek > 1)
                    {

                        Console.WriteLine(" Din trekant er ikke eksisterende");

                    }
                    else
                    {
                        Console.WriteLine("Bemærk, din trekant har 2 løsninger!");


                        B = (Math.Asin(b * Math.Sin(C * Math.PI / 180) / c) * (180 / Math.PI));
                        B2 = 180 - B;

                        A = 180 - B - C;
                        A2 = 180 - B2 - C;


                        a = (Math.Pow(c, 2) + Math.Pow(b, 2) - 2 * c * b * Math.Cos(A * Math.PI / 180));
                        a = Math.Sqrt(a);

                        a2 = (Math.Pow(c, 2) + Math.Pow(b, 2) - 2 * c * b * Math.Cos(A2 * Math.PI / 180));
                        a2 = Math.Sqrt(a2);

                        Console.WriteLine("Trekant 1");
                        Console.WriteLine("A =" + A);
                        Console.WriteLine("B = " + B);
                        Console.WriteLine("a = " + a);
                        Console.WriteLine();
                        Console.WriteLine("Trekant 2");
                        Console.WriteLine("A2 =" + A2);
                        Console.WriteLine("B2 = " + B2);
                        Console.WriteLine("a2 = " + a2);

                    }
                    break;

                case "Cac":
                    tjek = a * Math.Sin(C * Math.PI / 180) / c;
                    if (tjek < -1 || tjek > 1)
                    {

                        Console.WriteLine(" Din trekant er ikke eksisterende");

                    }
                    else
                    {
                        Console.WriteLine("Bemærk, din trekant har 2 løsninger!");


                        A = (Math.Asin(a * Math.Sin(C * Math.PI / 180) / c) * (180 / Math.PI));
                        A2 = 180 - A;

                        B = 180 - A - C;
                        B2 = 180 - A2 - C;


                        b = (Math.Pow(a, 2) + Math.Pow(c, 2) - 2 * a * c * Math.Cos(B * Math.PI / 180));
                        b = Math.Sqrt(b);

                        b2 = (Math.Pow(a, 2) + Math.Pow(c, 2) - 2 * a * c * Math.Cos(B2 * Math.PI / 180));
                        b2 = Math.Sqrt(b2);

                        Console.WriteLine("Trekant 1");
                        Console.WriteLine("A =" + A);
                        Console.WriteLine("B = " + B);
                        Console.WriteLine("b = " + b);
                        Console.WriteLine();
                        Console.WriteLine("Trekant 2");
                        Console.WriteLine("A2 =" + A2);
                        Console.WriteLine("B2 = " + B2);
                        Console.WriteLine("b2 = " + b2);

                    }
                    break;


                default:
                   
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