namespace Task_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task Data Types");

            Console.WriteLine("Task nr 1");
            //Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane to:
            //Imię, Nazwisko, Wiek, płeć (m lub k), Pesel, numer pracownika.
            //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje.
            string Name;
            Name = "Jan";
            Console.WriteLine(Name);
            string Surname;
            Surname = "Kowalski";
            Console.WriteLine(Surname);
            int Age;
            Age = 30;
            Console.WriteLine(Age);
            string Pesel;
            Pesel = "73049580955";
            Console.WriteLine(Pesel);
            string WorkerNumber;
            WorkerNumber = "435";
            Console.WriteLine(WorkerNumber);
            char Sex;
            Sex = 'm';
            Console.WriteLine(Sex);

            Console.WriteLine("Task nr 2");
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą,
            //a nastepnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
            char Litera = 'A';
            Litera = 'B';
            Litera = 'C';
            Console.WriteLine("C; B; A");

            //Kolejna próba dla zad nr 2:

            char A = 'A';
            char B = 'B';
            char C = 'C';
            Console.WriteLine(@"Zmienne w kolejności zadeklarowanej: A, B, C");
            Console.WriteLine(@"Zmienne w kolejności odwrotnej: C, B, A");

            Console.WriteLine("Task nr 3");
            //3 do poprawy
            //Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej.
            //Aby obliczyć kwadrat liczby użyj metody Math.Pow().
            Console.WriteLine("Zadanie nr 3");
            Console.WriteLine("Podaj szerokość prostokąta w cm");
            double Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość prostokąta w cm");
            double Lenght = Convert.ToDouble(Console.ReadLine());
            double SquareWidth = Math.Pow(Width, 2);
            double SquareLength = Math.Pow(Lenght, 2);
            double Diagonal = Math.Sqrt(SquareWidth + SquareLength);
            Console.WriteLine("Długość przekątnej wynosi: w cm");
            Environment.ExitCode = 0;
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć");
            Console.ReadKey();

            Console.WriteLine("Task nr 4");
            //Napisz program, w którym stworzysz 2 zmienne liczbowe oraz jedną tekstową,
            //a nastepnie przypiszesz im następujące wartości: 
            //a. 10 b. Szkoła Dotneta c. 12,5. Pamiętaj o użyciu poprawnych typów danych.
            int a = 10;
            Console.WriteLine(a);
            string text = "Szkoła Dotneta";
            Console.WriteLine(text);
            double c = 12.5;
            Console.WriteLine(c);

            Console.WriteLine("Task nr 5");
            //Jaki sens ma zamiana stringów na parse?
            //Napisz program, w którym poprosisz użytkownika o jego dane personalne tj.
            //imię, nazwisko, numer tel, adres email, wzrost, waga, itp
            //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
            //typDanych.Parse(odpowiedźOdUżytkownika).
            Console.WriteLine("Task number 5");

            Console.WriteLine("Podaj imię");
            Console.ReadLine();
            Console.WriteLine("Podaj nazwisko");
            Console.ReadLine();
            Console.WriteLine("Podaj numer tel i adres email");
            Console.ReadLine();

            Console.WriteLine("Podaj wzrost w cm");
            string HeightCmInput = Console.ReadLine();
            string HeightCm = "165";
            double Height = double.Parse(HeightCmInput);
            Console.WriteLine("Wzrost w cm: ");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć");
            Console.ReadKey();

            Console.WriteLine("Podaj wagę w kg");
            string WeightKgInput = Console.ReadLine();
            string WeightKg = "45.5";
            double Weight = double.Parse(WeightKgInput);
            Console.WriteLine("Waga w kilogramach: ");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć");
            Console.ReadKey();
        }
    }
}