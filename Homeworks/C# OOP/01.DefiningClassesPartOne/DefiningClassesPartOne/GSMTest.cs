namespace DefiningClassesPartOne
{
    using System;

    public class GSMTest
    {
        public static void Main()
        {
            var phones = new GSM[]
            {
                new GSM("Lumia550", "Microsoft", 120.80m, "Pesho Petrov", new Battery("KP1250", 500, 150, BatteryType.LiIon), new Display("1220x600", 65000)),
                new GSM("Phab", "Lenovo", 1200m, "Bacho Kiro", new Battery("AH-11", 480, 24), new Display("1280x720", 16000000)),
                new GSM("Galaxy S6", "Samsung")
            };
            foreach (var phone in phones)
            {
                Console.WriteLine(new string('-', 50));
                PrintPhoneInfo(phone);
            }

            Console.Write(new string('*', 17));
            Console.Write(" STATIC PROPERTY ");
            Console.WriteLine(new string('*', 17));
            PrintPhoneInfo(GSM.IPhone4S);
        }

        public static void PrintPhoneInfo(GSM gsm)
        {
            var currentGsmData = gsm.GetPhoneInfo(gsm.ToString());
            for (int i = 0; i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Manifacturer: ");
                        break;
                    case 1:
                        Console.Write("Model: ");
                        break;
                    case 2:
                        Console.Write("Price: ");
                        break;
                    case 3:
                        Console.Write("Owner: ");
                        break;
                    case 4:
                        Console.Write("Battery Model: ");
                        break;
                    case 5:
                        Console.Write("Battery Capacity (idle hours): ");
                        break;
                    case 6:
                        Console.Write("Battery Capacity (talk hours): ");
                        break;
                    case 7:
                        Console.Write("Battery Type: ");
                        break;
                    case 8:
                        Console.Write("Display Size: ");
                        break;
                    case 9:
                        Console.Write("Display Max. Colors: ");
                        break;
                    default:
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(currentGsmData[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();
        }
    }
}
