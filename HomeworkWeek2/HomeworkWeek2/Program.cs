using System;

namespace HomeworkWeek2
{
    class Program
    {
        enum Gender
        {
            Male = 'm',
            Female = 'k'
        }
        static void Main(string[] args)
        {
            //pętle if(true) służą tworzeniu zmiennych lokalnych aby nie rezerwować 
            //nazw dla całego programu
            //#region lesson 4
            //#region 4.1
            //if (true)
            //{
            //    string Name;
            //    string Surname;
            //    int Age;
            //    Gender gender;
            //    long PESEL;
            //    long ID;
            //}
            //#endregion
            //#region 4.2
            //if (true)
            //{
            //    char a = 'a';
            //    char b = 'b';
            //    char c = 'c';

            //    Console.WriteLine($"{c}, {b}, {a}");
            //}
            //#endregion
            //#region 4.3
            //if (true)
            //{
            //    int length = int.Parse(Console.ReadLine());
            //    int Hgh = int.Parse(Console.ReadLine());
            //    Console.WriteLine(Math.Sqrt(length * length + Hgh * Hgh));
            //}
            //#endregion
            //#region 4.4
            //if (true)
            //{
            //    int num1;
            //    double num2;
            //    string str;
            //    num1 = 10;
            //    str = "Szkoła Dotneta";
            //    num2 = 12.5;
            //}
            //#endregion
            //#region 4.5
            //if (true)
            //{
            //    Console.Write("Podaj imie: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Podaj nazwisko: ");
            //    string surname = Console.ReadLine();
            //    Console.Write("Podaj wiek: ");
            //    int age = int.Parse(Console.ReadLine());
            //    Console.Write("podaj numer telefonu: ");
            //    int telNum = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj wage: ");
            //    double mass = double.Parse(Console.ReadLine());
            //}
            //#endregion
            //#endregion
            //#region lesson 7
            //#region 7.1
            //if (true)
            //{
            //    int a = 8;
            //    int b = 8;
            //    if (a == b)
            //    {
            //        Console.WriteLine("zmienne a i b są równe");
            //    }
            //}
            //#endregion
            //#region 7.2
            //if (true)
            //{
            //    Console.Write("Podaj liczbę: ");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine($"{num} jest liczbą parzystą");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num} jest liczbą nieparzystą");
            //    }
            //}
            //#endregion
            //#region 7.3
            //if (true)
            //{
            //    Console.Write("Podaj liczbę: ");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num >= 0)
            //    {
            //        Console.WriteLine($"{num} jest liczbą dodatnią");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num} jest liczbą ujemną");
            //    }
            //}
            //#endregion
            //#region 7.4
            //Console.Write("Podaj rok: ");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine($"{year} jest rokiem przestępnym");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} nie jest rokiem przestępnym");
            //}
            //#endregion
            //#region 7.5
            //if (true)
            //{
            //    Console.Write("Podaj swój wiek: ");
            //    int age = int.Parse(Console.ReadLine());
            //    if (age >= 35)
            //    {
            //        Console.Write("Możesz zostać posłem senatorem i prezydentem");
            //    }
            //    else if (age >= 30 && age < 35)
            //    {
            //        Console.Write("Możesz zostać posłem i senatorem");
            //    }
            //    else if (age >= 21 && age < 30)
            //    {
            //        Console.Write("Możesz zostać posłem");
            //    }
            //    else
            //    {
            //        Console.WriteLine("nie możesz ubiegać się o żadne stanowisko");
            //    }
            //}
            //#endregion
            //#region 7.6
            //Console.Write("Podaj swój wzrost: ");
            //int Height = int.Parse(Console.ReadLine());
            //if (Height <= 150)
            //{
            //    Console.WriteLine("gdzie jesteś? nie widze cie");
            //}
            //else if (Height <= 180 && Height > 150)
            //{
            //    Console.WriteLine("hmmmm to już nie krasnal ale możesz jeszcze troche uronąć");
            //}
            //else
            //{
            //    Console.WriteLine("jesteś olbrzymem");
            //}
            //#endregion
            //#region 7.7
            //if (true)
            //{
            //    Console.Write("Podaj pierwszą liczbę: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj drugą liczbę: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj trzecią liczbę: ");
            //    int num3 = int.Parse(Console.ReadLine());
            //    if (num1 >= num2 && num1 >= num3)
            //    {
            //        Console.WriteLine($"{num1} jest największą liczbą");
            //    }
            //    else if (num2 >= num1 && num2 >= num3)
            //    {
            //        Console.WriteLine($"{num2} jest największą liczbą");
            //    }
            //    else if (num3 >= num1 && num3 >= num2)
            //    {
            //        Console.WriteLine($"{num3} jest największą liczbą");
            //    }
            //}
            //#endregion
            //#region 7.8
            //if (true)
            //{
            //    Console.Write("Podaj wynik z matmy: ");
            //    int math = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj wynik z fizyki: ");
            //    int physic = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj wynik z chemii: ");
            //    int chem = int.Parse(Console.ReadLine());
            //    if ((math > 70 && physic > 55 && chem > 45 && math + physic + chem > 180) ||
            //        (math + physic > 180) ||
            //        (math + chem > 180))
            //    {
            //        Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            //    }
            //}
            //#endregion
            //#region 7.9
            //if (true)
            //{
            //    Console.Write("Podaj temperature: ");
            //    int temp = int.Parse(Console.ReadLine());
            //    if (temp < 0)
            //    {
            //        Console.WriteLine("cholernie piździ");
            //    }
            //    else if (temp >= 0 && temp < 10)
            //    {
            //        Console.WriteLine("zimno");
            //    }
            //    else if (temp >= 10 && temp < 20)
            //    {
            //        Console.WriteLine("chłodno");
            //    }
            //    else if (temp >= 20 && temp < 30)
            //    {
            //        Console.WriteLine("w sam raz");
            //    }
            //    else if (temp >= 30 && temp < 40)
            //    {
            //        Console.WriteLine("zaczyna być słabo, bo gorąco");
            //    }
            //    else if (temp >= 40)
            //    {
            //        Console.WriteLine("a weź wyprowadzam się na Alaskę");
            //    }
            //}
            //#endregion
            //#region 7.10
            //if (true)
            //{
            //    Console.Write("Podaj pierwszy bok trójkąta: ");
            //    int sideA = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj drugi bok trójkąta: ");
            //    int sideB = int.Parse(Console.ReadLine());
            //    Console.Write("Podaj trzeci bok trójkąta: ");
            //    int sideC = int.Parse(Console.ReadLine());
            //    if (sideA + sideB < sideC ||
            //        sideA + sideC < sideB ||
            //        sideB + sideC < sideA)
            //    {
            //        Console.WriteLine("nie można utworzyć trójkąta z tych boków");
            //    }
            //    else
            //    {
            //        Console.WriteLine("można utworzyć trójkąta z tych boków");
            //    }
            //}
            //#endregion
            //#region 7.11
            //if (true)
            //{
            //    Console.Write("Podaj ocene: ");
            //    int mark = int.Parse(Console.ReadLine());
            //    Console.Write("Słownie ta ocena to: ");
            //    switch (mark)
            //    {
            //        case 1:
            //            Console.WriteLine("Niedostateczny");
            //            break;
            //        case 2:
            //            Console.WriteLine("Dopuszczający");
            //            break;
            //        case 3:
            //            Console.WriteLine("Dostateczny");
            //            break;
            //        case 4:
            //            Console.WriteLine("Dobry");
            //            break;
            //        case 5:
            //            Console.WriteLine("Bardzo dobry");
            //            break;
            //        case 6:
            //            Console.WriteLine("Celujący");
            //            break;
            //        default:
            //            Console.WriteLine("przykro nam nie znamy takiej oceny");
            //            break;
            //    }
            //}
            //#endregion
            //#region 7.12
            //if (true)
            //{
            //    Console.Write("Podaj numer dnia tygodnia: ");
            //    int day = int.Parse(Console.ReadLine());
            //    Console.Write("ten dzień to: ");
            //    switch (day % 7)
            //    {
            //        case 1:
            //            Console.WriteLine("Poniedziałek");
            //            break;
            //        case 2:
            //            Console.WriteLine("Wtorek");
            //            break;
            //        case 3:
            //            Console.WriteLine("Środa");
            //            break;
            //        case 4:
            //            Console.WriteLine("Czwartek");
            //            break;
            //        case 5:
            //            Console.WriteLine("Piątek");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sobota");
            //            break;
            //        case 0:
            //            Console.WriteLine("Niedziela");
            //            break;
            //    }
            //}
            //#endregion
            //#region 7.13
            //if (true)
            //{
            //    Console.WriteLine("wybierz operacje:");
            //    Console.WriteLine("1) dodawanie");
            //    Console.WriteLine("2) odejmowanie");
            //    Console.WriteLine("3) mnożenie");
            //    Console.WriteLine("4) dzielenie");
            //    Console.WriteLine("5) potęga (A^B)");
            //    int choice = int.Parse(Console.ReadLine());
            //    Console.Write("Podakj liczbe A: ");
            //    int numbA = int.Parse(Console.ReadLine());
            //    Console.Write("Podakj liczbe B: ");
            //    int numbB = int.Parse(Console.ReadLine());
            //    Console.Write("Twój wynik to: ");
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine(numbA + numbB);
            //            break;
            //        case 2:
            //            Console.WriteLine(numbA - numbB);
            //            break;
            //        case 3:
            //            Console.WriteLine(numbA * numbB);
            //            break;
            //        case 4:
            //            Console.WriteLine(numbA / numbB);
            //            break;
            //        case 5:
            //            Console.WriteLine(Math.Pow(numbA, numbB));
            //            break;
            //        default:
            //            Console.WriteLine("Nie znam takiej komendy");
            //            break;
            //    }
            //}
            //#endregion
            //#endregion
            //#region lesson 8
            //#region 8.1
            //if (true)
            //{
            //    int primeNumb = 0;
            //    bool isPrime;
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        isPrime = true;
            //        if (i > 1)
            //        {
            //            for (int x = 2; x < i; x++)
            //            {
            //                if (i % x == 0)
            //                {
            //                    isPrime = false;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            isPrime = false;
            //        }
            //        if (isPrime)
            //        {
            //            primeNumb++;
            //        }
            //    }
            //    Console.WriteLine($"There are {primeNumb} prime numbers");
            //}
            //#endregion
            //#region 8.2
            //if (true)
            //{
            //    int num = 0;
            //    int even = 0;
            //    do
            //    {
            //        if (num % 2 == 0)
            //        {
            //            even++;
            //        }
            //        num++;
            //    } while (num <= 1000);
            //    Console.WriteLine($"There are {even} even numbers");
            //}
            //#endregion
            //#region 8.3
            //int A = 0;
            //int B = 1;
            //int C;
            //Console.WriteLine("pierwsze 12 wyrazów ciągu Fibonacciego");
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //for (int i = 0; i < 10; i++)
            //{
            //    C = A + B;
            //    Console.WriteLine(C);
            //    A = B;
            //    B = C;
            //}
            //#endregion
            //#region 8.4
            //Console.Write("Podaj liczbe: ");
            //int numb = int.Parse(Console.ReadLine());
            //int draw = 1;
            //for (int i = 0; draw <= numb; i++)
            //{
            //    for (int x = 0; x < i; x++)
            //    {
            //        if (draw <= numb)
            //        {
            //            Console.Write(draw + " ");
            //            draw++;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //#endregion
            //#region 8.5
            //for (int i = 0; i < 21; i++)
            //{
            //    Console.WriteLine(i * i * i);
            //}
            //#endregion
            //#region 8.6
            //double sum;
            //for (int i = 0; i < 21; i++)
            //{
            //    sum = 0;
            //    for (int x = 1; x <= i; x++)
            //    {
            //        sum += 1.0 / x;
            //    }
            //    Console.WriteLine(sum);
            //}
            //#endregion
            //#region 8.7
            //Console.Write("Podaj wysokość diamentu: ");
            //int height = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= height; i++)
            //{
            //    if (i*2 - 1 < height)
            //    {
            //        if (height % 2 == 0)
            //        {
            //            for (int x = 0; x < height/2 -i; x++)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (int x = 0; x < i * 2; x++)
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //        else
            //        {
            //            for (int x = 0; x < height/2-i + 1; x++)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (int x = 0; x < i * 2 - 1; x++)
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (height%2 == 0)
            //        {
            //            for (int x = i-height/2 - 1; x >0; x--)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (int x = 0; x < height - ((i- 1)%(height/2)) * 2; x++)
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //        else
            //        {
            //            for (int x = 0; x < i - height/2 - 1; x++)
            //            {
            //                Console.Write(" ");
            //            }
            //            for (int x = 0; x < height - (i - height / 2 - 1)*2; x++)
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //#endregion
            #region 8.8
            Console.WriteLine("Napisz wyraz");
            string word = Console.ReadLine();
            for (int i = word.Length -1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
            #endregion
            #region 8.9
            Console.Write("Wpisz liczbę dziesiętną: ");
            int dec = int.Parse(Console.ReadLine());
            int help = 1;
            string bin= "";
            while (help <=dec)
            {
                help *= 2;
            }
            help /= 2;
            while (help>0)
            {
                if (help<=dec)
                {
                    dec -= help;
                    bin += "1";
                }
                else
                {
                    bin += "0";
                }
                help /= 2;
            }
            Console.WriteLine($"systemie binarnym to: {bin}");
            #endregion
            #region 8.10
            Console.Write("Podaj pierwszą liczbę: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int num2 = int.Parse(Console.ReadLine());
            int memory1 = num1;
            int prime;
            while (num2>1)
            {
                prime = GetDivPrime(num2);
                if (num1%prime==0)
                {
                    memory1 /= prime;
                    num2 /= prime;
                }
                else
                {
                    num1 *= prime;
                    num2 /= prime;
                }
                
            }
            Console.WriteLine($"NNW: {num1}");
            #endregion
            //#endregion

        }

        private static int GetDivPrime(int num)
        {
            int prime = 2;
            int memory = prime;
            bool isPrime = false;
            while (prime <= num)
            {
                isPrime = true;
                for (int i = 2; i < prime; i++)
                {
                    if (prime % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime && num%prime == 0)
                {
                    memory = prime;
                }
                prime++;
            }
            return memory;
        }
    }
}
