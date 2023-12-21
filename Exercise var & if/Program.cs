using System;
using System.ComponentModel.Design;

namespace VarIf
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            //Zadanie 1
            //int a = 5;
            //int b = 5;
            Console.WriteLine("Wpisz pierwszą liczbę do porównania: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę do porównania: ");
            int b = int.Parse(Console.ReadLine());
            
            if (a == b) 
            {
                Console.WriteLine(a + ", " + b + " są równe");
            }
            else { Console.WriteLine(a + ", " + b + " nie są równe"); }
            //Zadanie 2
            Console.WriteLine("Wpisz liczbę do sprawdzenie czy jest parzysta lub nieparzysta");
            int c = int.Parse(Console.ReadLine());
            //int c = 15;
            double d = c % 2;
            if ( d > 0)
            {
                Console.WriteLine("Liczba " + c + " jest nieparzysta");
            }
            else
            {
                Console.WriteLine("Liczba " + c + " jest parzysta");
            }
            //Zadanie 3 
            //int e = 14;
            Console.WriteLine("Podaj liczbę do sprawdzenia czy jest dodatnia lub ujemna");
            int e = int.Parse(Console.ReadLine());
            if (e > 0)
            {
                Console.WriteLine("Liczba " + e + " jest liczba dodatnią");
            }
            else if (e < 0)
            {
                Console.WriteLine("Liczba " + e + " jest liczba ujemną");
            }
            else
            {
                Console.WriteLine("Liczba " + e + " jest równa 0");
            }
            //Zadanie 4
            //int year = 2016;
            Console.WriteLine("Podaj rok do sprawdzenia czy jest przestępny:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine(year + " nie jest rokiem przestępnym");
            }
            //Zadanie 5
            //int age = 21;
            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 21 && age <30)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else if (age >= 30 && age < 35)
            {
                Console.WriteLine("Możesz zostać posłem lub senatorem");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem");
            }
            else
            {
                Console.WriteLine("Nie możesz kandydować");
            }
            //Zadanie 6
            //int height = 140;
            Console.WriteLine("Podaj wzrost:");
            int height = int.Parse(Console.ReadLine());
            if (height <= 150)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (height > 150 && height <= 165) 
            {
                Console.WriteLine("Jesteś niski");
            }
            else if (height > 165 && height <= 175)
            {
                Console.WriteLine("Jesteś średniego wzrostu");
            }
            else 
            {
                Console.WriteLine("Jesteś Olbrzymem");
            }
            //Zadanie 7
            //int firstNumber = 25;
            //int secondNumber = 63;
            //int thirdNumber = 79;
            Console.WriteLine("Podaj pierwszą liczbę do porównania która jest największa");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę do porównania która jest największa");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę do porównania która jest największa");
            int thirdNumber = int.Parse(Console.ReadLine());
            if ((firstNumber >= secondNumber) && (firstNumber >= thirdNumber))
            {
                Console.WriteLine("Największą liczbą jest " + firstNumber);
            }
            else if ((secondNumber >= firstNumber) && (secondNumber >= thirdNumber))
            {
                Console.WriteLine("Największą liczbą jest " +  secondNumber);
            }
            else
            {
                Console.WriteLine("Największa liczbą jest " + thirdNumber);
            }
            //Zadanie 8
            // int math = 80;
            // int phys = 71;
            // int chem = 0;

            Console.WriteLine("Podaj wynik z matury z matematyki:");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z matury z fizyki:");
            int phys = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj wynik z matury z chemii:");
            int chem = int.Parse(Console.ReadLine());
            if (((math > 70 && phys > 55 && chem > 45) && (math+phys+chem)>180) || ((math + phys) > 150 ||(math + chem) > 150 ))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else 
            { 
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
            }
            //Zadanie 9
            Console.WriteLine("Wpisz temperaturę:");
            int temp = int.Parse(Console.ReadLine());
            if (temp < 0) 
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if ((temp >= 0) && (temp < 10))
            {
                Console.WriteLine("Zimno");
            }
            else if ((temp >= 10) && (temp <20))
            {
                Console.WriteLine("Chłodno");
            }
            else if ((temp >= 20) && (temp < 30))
            {
                Console.WriteLine("W sam raz");
            }
            else if ((temp >= 30) && (temp < 40))
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else
            { 
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }
            //Zadanie 10
            //int firstSide = 40;
            //int secondSide = 55;
            //int thirdSide = 65;
            Console.WriteLine("Podaj długość pierwszego boku trójkąta:");
            int firstSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku trójkąta:");
            int secondSide = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość trzeciego boku trójkąta:");
            int thirdSide = int.Parse(Console.ReadLine());
            if ((firstSide + secondSide > thirdSide) && (secondSide + thirdSide > firstSide) &&(thirdSide + firstSide > secondSide) )
            {
                Console.WriteLine("Z podanych długości boków można utworzyć trójkąt");
            }
            else
            { 
                Console.WriteLine("Z podanych długości boków nie można utworzyć trójkąta");
            }
            //Zadanie 11
            //int mark = 3;
            Console.WriteLine("Podaj ocenę w postaci liczby:");
            int mark = int.Parse(Console.ReadLine());
            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
            }
            //Zadanie 12
            // int numberDay = 4;
            Console.WriteLine("Podaj dzień tygodnia w postaci liczby:");
            int numberDay = int.Parse(Console.ReadLine());
            switch (numberDay)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
            }
            //Zadanie 13
            Console.WriteLine("Podaj pierwszą liczbę do obliczeń:");
            double firstNumberCount = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbę di obliczeń:");
            double secondNumberCount = double.Parse(Console.ReadLine());
            Console.WriteLine("Wybierz opcję obliczeń: \r\n 1. Dodawanie \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Wynik dodawania = " + (firstNumberCount + secondNumberCount));
                    break;
                case 2:
                    Console.WriteLine("Wynik odejmowania = " + (firstNumberCount - secondNumberCount));
                    break;
                case 3:
                    Console.WriteLine("Wynik mnożenia = " + (firstNumberCount * secondNumberCount));
                    break;
                case 4:
                    Console.WriteLine("Wynik dzielenia = " + (firstNumberCount / secondNumberCount));
                    break;
            }
        }

    }
}