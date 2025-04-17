using System.Text;

namespace ppzo_console_app_cs
{
    internal class Program
    {
        // Czeka na naciśnięcie Enter przez użytkownika, a następnie czyści ekran konsoli
        static void WaitForEnterAndClear()
        {
            Console.Write("Naciśnij Enter. aby kontynuować...");
            Console.ReadLine();
            Console.Clear();
        }

        // Pobiera od użytkownika liczbę typu int
        static int GetIntFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(
                    $"{prompt}\n" +
                    "> "
                    );

                string inputString = Console.ReadLine() ?? "";
                int inputNum;

                try
                {
                    inputNum = int.Parse(inputString);
                }
                catch
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
                    continue;
                }

                // Sprawdź, czy wartość zrzutowana jest równa wartość podanej
                if (inputNum.ToString() != inputString)
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
                    continue;
                }

                return inputNum;
            }
        }

        // Pobiera od użytkownika liczbę typu double
        static double GetDoubleFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(
                    $"{prompt}\n" +
                    "> "
                    );

                string inputString = Console.ReadLine() ?? "";
                double inputNum;

                try
                {
                    inputNum = double.Parse(inputString);
                }
                catch
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
                    continue;
                }

                // Sprawdź, czy wartość zrzutowana jest równa wartość podanej
                if (inputNum.ToString() != inputString)
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj ponownie.");
                    continue;
                }

                return inputNum;
            }
        }

        // Realizuje działanie prostego kalkulatora
        static void Kalkulator()
        {
            Console.Clear();

            Console.WriteLine(
                    "KALKULATOR\n" +
                    "----------"
                    );

            double num1 = GetDoubleFromUser("Podaj pierwszą liczbę.");
            double num2 = GetDoubleFromUser("Podaj drugą liczbę.");

            Console.Clear();
            Console.WriteLine(
                $"Podane liczby to:\n" +
                $"{num1}\n" +
                $"{num2}\n" +
                "Wpisz znak operacji, którą chcesz wykonać:\n" +
                "[+] - Dodawanie\n" +
                "[-] - Odejmowanie\n" +
                "[*] - Mnożenie\n" +
                "[/] - Dzielenie"
                );

            double result;

            while (true)
            {
                Console.Write("> ");
                string option = Console.ReadLine() ?? "";

                if (option == "+")
                {
                    result = num1 + num2;
                }
                else if (option == "-")
                {
                    result = num1 - num2;
                }
                else if (option == "*")
                {
                    result = num1 * num2;
                }
                else if (option == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Nie moźna dzielić przez 0! Spróbuj ponownie.");
                        continue;
                    }

                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Podana operacja nie istnieje! Spróbuj ponownie.");
                    continue;
                }

                break;
            }

            Console.WriteLine($"Wynik: {result}");
        }

        // Konwertuje temperatury między stopniami Celsjusza a Fahrenheita
        static void KonwerterTemperatur()
        {
            Console.Clear();

            Console.WriteLine(
                    "KONWERTER TEMPERATUR\n" +
                    "----------\n" +
                    "Wybierz operację.\n" +
                    "[C] - Celsjusz -> Fahrenheit\n" +
                    "[F] - Fahrenheit -> Celsjusz"
                    );

            string temperatureType;

            while (true)
            {
                Console.Write("> ");
                temperatureType = Console.ReadLine() ?? "";

                if (temperatureType != "C" && temperatureType != "F")
                {
                    Console.WriteLine("Podany typ temperatury nie istnieje! Spróbuj ponownie.\n");
                    continue;
                }

                break;
            }

            double temperature = GetDoubleFromUser("Podaj wartość temperatury.");

            if (temperatureType == "C") Console.WriteLine($"{temperature}°C = {temperature * 1.8 + 32}°F");
            if (temperatureType == "F") Console.WriteLine($"{temperature}°F = {(temperature - 32) / 1.8}°C");
        }

        // Oblicza średnią ocen ucznia
        static void SredniaOcenUcznia()
        {
            Console.Clear();

            Console.WriteLine(
                    "ŚREDNIA OCEN UCZNIA\n" +
                    "----------"
                    );

            int numOfGrades;

            while (true)
            {
                numOfGrades = GetIntFromUser("Podaj liczbę ocen ucznia.");

                if (numOfGrades <= 0)
                {
                    Console.WriteLine("Liczba ocen ucznia musi być większa od 0! Spróbuj ponownie.");
                    continue;
                }

                break;
            }

            int[] grades = new int[numOfGrades];

            for (int i = 0; numOfGrades > i; i++)
            {
                int grade;

                while (true)
                {
                    grade = GetIntFromUser($"Podaj ocenę nr.{i + 1}.");

                    if (!(1 <= grade && grade <= 6))
                    {
                        Console.WriteLine("Podana ocena nie mieści się w zakresie 1-6!. Spróbuj ponownie.");
                        continue;
                    }

                    break;
                }

                grades[i] = grade;
            }

            double sumOfGrades = 0;

            for (int i = 0; i < grades.Length; i++) sumOfGrades += grades[i];

            double average = sumOfGrades / numOfGrades;

            Console.WriteLine(
                $"Średnia: {average}\n" +
                (average >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.")
                );
        }

        // Wyświetla menu i obsługuje wybór użytkownika
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // Ustawienie kodowania wyjścia konsoli

            while (true)
            {
                Console.WriteLine(
                    "MENU\n" +
                    "----------\n" +
                    "[1] Kalkulator\n" +
                    "[2] Konwerter temperatur\n" +
                    "[3] Średnia ocen ucznia\n" +
                    "[9] Wyjście"
                    );

                Console.Write("> ");
                string option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Kalkulator();
                        break;

                    case "2":
                        KonwerterTemperatur();
                        break;

                    case "3":
                        SredniaOcenUcznia();
                        break;

                    case "9":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Podana opcja nie istnieje!");
                        break;
                }

                WaitForEnterAndClear();
            }
        }
    }
}