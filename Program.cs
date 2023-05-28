namespace ConsoleApp
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            FourthTask();
        }
        static void FirstTask()
        {
            //Конвертер температур

            double celsius, faringate, kelvin;
            int number;

            Console.Write("Введите температуру в шкале Цельсия: ");
            while (!double.TryParse(Console.ReadLine(), out celsius) || celsius <= -273.15)
                Error("Введите температуру в шкале Цельсия:");
            Console.Clear();

            Console.WriteLine("Выберите в какую шкалу конвертировать: \n 1 -- Фарингейта\n 2 -- Кельвина ");
            while (!int.TryParse(Console.ReadLine(), out number) || number > 2 || number == 0)
                Error("Выберите в какую шкалу конвертировать: \n 1 -- Фарингейта\n 2 -- Кельвина\n");
            Console.Clear();

            switch (number)
            {
                case 1:
                    faringate = 9f / 5f * celsius + 32;
                    Console.WriteLine("Результат: " + faringate + "°С");
                    break;
                case 2:
                    kelvin = 273.15 + celsius;
                    Console.WriteLine("Результат: " + kelvin + "°С");
                    break;
            }
        }
        static void SecondTask()
        {
            //Калькулятор

            char action;
            double firstNumber, secondNumber;

            Console.Write("Выберите арифметическую операцию: \n + Сложение\n - Вычитание\n * Умножение\n / Деление\n % Остаток от деления\n");
            while (!char.TryParse(Console.ReadLine(), out action))
                Error("Выберите арифметическую операцию: \n + Сложение\n - Вычитание\n * Умножение\n / Деление\n % Остаток от деления\n");
            Console.Clear();

            Console.Write("Введите первое число: ");
            while (!double.TryParse(Console.ReadLine(), out firstNumber))
                Error("Введите первое число: ");
            Console.Clear();

            Console.Write("Введите второе число: ");
            while (!double.TryParse(Console.ReadLine(), out secondNumber))
                Error("Введите второе число: ");
            Console.Clear();

            switch (action)
            {
                case '+':
                    Console.WriteLine($"Результат: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case '-':
                    Console.WriteLine($"Результат: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case '*':
                    Console.WriteLine($"Результат: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case '/':
                    Console.WriteLine($"Результат: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
                case '%':
                    Console.WriteLine($"Результат: Остаток от деления {firstNumber} на {secondNumber} = {firstNumber % secondNumber}");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такой команды нет");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        static void ThirdTask()
        {
            //Проверка на знание таблицы умножения

            int firstNumber, secondNumber, answerUser, answerSystem;

            Console.Write("Введите первое однозначное число: ");
            while (!int.TryParse(Console.ReadLine(), out firstNumber) || firstNumber > 9 || firstNumber == 0)
                Error("Введите первое однозначное число: ");
            Console.Clear();

            Console.Write("Введите второе однозначное число: ");
            while (!int.TryParse(Console.ReadLine(), out secondNumber) || secondNumber > 9 || secondNumber == 0)
                Error("Введите второе однозначное число: ");
            Console.Clear();

            Console.WriteLine($"\nСколько будет {firstNumber} умножить на {secondNumber}?");

            Console.Write("Ваш ответ: ");
            while (!int.TryParse(Console.ReadLine(), out answerUser))
                Error("Ваш ответ: ");

            answerSystem = firstNumber * secondNumber;

            if (answerUser != answerSystem)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nНеверно! Ответ: {answerSystem}");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Верно!");
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void FourthTask()
        {
            // ГОДА

            int n, numberEnd;
            Console.WriteLine("Сколько вам лет?");
            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 99)
                Error("Сколько вам лет?\n");
            Console.Clear();
            numberEnd = n % 10;
            
            switch (numberEnd)
            {
                case 1:
                    if (n == 11)
                    {
                        Console.WriteLine($"Мне {n} лет");
                    }
                    else
                    {
                        Console.WriteLine($"Мне {n} год");
                    }
                    break;
                case int i when (i >= 2 && i <= 4):
                        Console.WriteLine($"Мне {n} года");
                    break;
                default:
                    Console.WriteLine($"Мне {n} лет");
                    break;
            }
        }
        static void Error(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Неправильный ввод!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\n{message}");
        }
    }
}