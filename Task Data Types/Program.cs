using System.Security.Cryptography.X509Certificates;

namespace Task_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Approved Task Data Types");

            Console.WriteLine("Task nr 1");
            //Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane to:
            //Imię, Nazwisko, Wiek, płeć (m lub k), Pesel, numer pracownika.
            //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje.

            string name = "Jan";
            Console.WriteLine(name);
            string surname = "Kowalski";
            Console.WriteLine(surname);
            int age = 30;
            Console.WriteLine(age);
            string pesel = "73049580955";
            Console.WriteLine(pesel);
            string workerNumber = "435";
            Console.WriteLine(workerNumber);
            char sex = 'm';
            Console.WriteLine(sex);

            Console.WriteLine("Task nr 2");
            //Napisz program, w którym stworzysz 3 zmienne z jedną literą,
            //a nastepnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.

            char letterA = 'A';
            char letterB = 'B';
            char letterC = 'C';
            Console.WriteLine($"{letterC}; {letterB}; {letterA}");

            Console.WriteLine("Task nr 3");
            //Napisz program, który na podstawie podanej szerokości
            //i długości prostokąta wyliczy długość przekątnej.
            //Aby obliczyć kwadrat liczby użyj metody Math.Pow().

            Console.WriteLine("Podaj szerokość prostokąta w cm");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długość prostokąta w cm");
            double lenght = Convert.ToDouble(Console.ReadLine());
            double squareWidth = Math.Pow(width, 2);
            double squareLength = Math.Pow(lenght, 2);
            double diagonal = Math.Sqrt(squareWidth + squareLength);
            Console.WriteLine($"Długość przekątnej wynosi: w {diagonal} cm");

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
            //Napisz program, w którym poprosisz użytkownika o jego dane personalne tj.
            //imię, nazwisko, numer tel, adres email, wzrost, waga, itp
            //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
            //typDanych.Parse(odpowiedźOdUżytkownika).

            Console.WriteLine("Podaj imię");
            string nameUser = Console.ReadLine();
            Console.WriteLine($"Twoje imię to: {nameUser}");

            Console.WriteLine("Podaj nazwisko");
            string surnameUser = Console.ReadLine();
            Console.WriteLine($"Twoje nazwisko to: {surnameUser}");

            Console.WriteLine("Podaj numer tel i adres email");
            string telefonNumberAndEmail = Console.ReadLine();
            Console.WriteLine($"Twój nr telefonu i email to: {telefonNumberAndEmail}");

            Console.WriteLine("Podaj wzrost w cm");
            string heightCmInput = Console.ReadLine();
            double height;
            double.TryParse(heightCmInput, out height);
            string heightCm = $"Wzrost w cm: {heightCmInput}";
            Console.WriteLine($"Twój wzrost w cm: {heightCm}");

            Console.WriteLine("Podaj wagę w kg");
            string weightKgInput = Console.ReadLine();
            double weight;
            double.TryParse(weightKgInput, out weight);
            string weightKg = $"Waga w kg: {weightKgInput}";
            Console.WriteLine($"Twoja Waga w kilogramach: {weightKg}");

            Console.WriteLine("Podaj dzisiejszy średni kurs walut dla eur - pln z 4 miejscami po przecinku");
            string exchangeRate = Console.ReadLine();
            decimal rate;
            decimal.TryParse(exchangeRate, out rate);
            string exchangeRateToday = $"Kurs eur-pln {exchangeRate}";
            Console.WriteLine($"Kurs dzisiejszy średni eur - pln: {exchangeRateToday}");
            return;
        }
    }
}