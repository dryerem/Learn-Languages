using System;

namespace Currency_Converter
{
    class Program
    {
        const double RUB_USD = 0.0138;
        const double RUB_EUR = 0.0116;
        const double USD_EUR = 0.8457;
        const double USD_RUB = 72.7171;
        const double EUR_USD = 1.1825;
        const double EUR_RUB = 85.988;
        static void Main(string[] args)
        {
            Console.WriteLine("Simple currency convert [RUB, EUR, USD]");
            
            Console.Write("Input currency code from: ");
            string currencyCodeA = Console.ReadLine().ToLower();
            if (!((currencyCodeA == "rub") | (currencyCodeA == "eur") | (currencyCodeA == "usd")))
            {
                currencyUncorrect();
            }

            double currency;
            Console.Write("Input currency: ");
            if (!double.TryParse(Console.ReadLine(), out currency))
            {
                valueUncorrect();
            }

            Console.Write("Input currency code to: ");
            string currencyCodeB = Console.ReadLine().ToLower();
            if (!((currencyCodeB == "rub" ) | (currencyCodeB == "eur") | (currencyCodeB == "usd")))
            {
                currencyUncorrect();
            }   

            if (currencyCodeA == "rub" && currencyCodeB == "usd")
            {
                printResult(currency * RUB_USD);
            } else if (currencyCodeA == "rub" && currencyCodeB == "eur")
            {
                printResult(currency * RUB_EUR);
            } else if (currencyCodeA == "rub" && currencyCodeB == "rub")
            {
                printResult(currency);
            } else if (currencyCodeA == "usd" && currencyCodeB == "eur")
            {
                printResult(currency * USD_EUR);
            } else if (currencyCodeA == "usd" && currencyCodeB == "rub")
            {
                printResult(currency * USD_RUB);
            } else if (currencyCodeA == "usd" && currencyCodeB == "usd")
            {
                printResult(currency);
            } else if (currencyCodeA == "eur" && currencyCodeB == "rub")
            {
                printResult(currency * EUR_RUB);
            } else if (currencyCodeA == "eur" && currencyCodeB == "usd")
            {
                printResult(currency * EUR_USD);
            } else if (currencyCodeA == "eur" && currencyCodeB == "eur")
            {
                printResult(currency);
            }
        }
        static void printResult(double value)
        {
            Console.WriteLine("Result: " + value);
            Environment.Exit(0);
        }

        static void currencyUncorrect()
        {
            Console.WriteLine("Error! Uncorrect currency code!");
            Environment.Exit(1);
        }

        static void valueUncorrect()
        {
            Console.WriteLine("Error! Uncorrect value, please, try again");
            Environment.Exit(1);        
        }
    }
}
