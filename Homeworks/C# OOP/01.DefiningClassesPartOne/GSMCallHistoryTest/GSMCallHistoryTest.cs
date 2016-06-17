namespace DefiningClassesPartOne
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void Main()
        {
            var phone = new GSM("Asha", "Nokia", 330.50m, "Mara Petrova", new Battery("KK-21", 300, 100, BatteryType.NiMH), new Display("800x600", 10000));
            var calls = new Call[]
            {
                new Call { DateAndTime = new DateTime(2014, 12, 18, 21, 05, 00), DialedNumber = "12345678", Duration = 166 },
                new Call { DateAndTime = new DateTime(2015, 1, 01, 06, 15, 05), DialedNumber = "87654321", Duration = 66 },
                new Call { DateAndTime = new DateTime(2015, 3, 06, 10, 37, 12), DialedNumber = "12345678", Duration = 1024 },
                new Call { DateAndTime = new DateTime(2016, 2, 11, 11, 26, 17), DialedNumber = "55555555", Duration = 20 },
                new Call { DateAndTime = new DateTime(2016, 5, 22, 23, 11, 33), DialedNumber = "12345678", Duration = 800 },
            };
            foreach (var call in calls)
            {
                phone.AddCall(call);
            }

            Console.WriteLine("============== CALLS ==============");
            foreach (var call in phone.CallHistory)
            {
                DisplayCallInfo(call);
            }

            Console.WriteLine("=====================================================");
            Console.WriteLine();
            Console.WriteLine("TOTAL CALLS COST: {0:F2} lv.", phone.CalculateTotalCallsCost());
            Console.WriteLine();
            phone.RemoveLongestCall();
            Console.WriteLine("=====================================================");
            Console.WriteLine();
            Console.WriteLine("TOTAL CALLS COST AFTER REMOVAL: {0:F2} lv.", phone.CalculateTotalCallsCost());
            Console.WriteLine();
            phone.ClearCallHistory();
            Console.WriteLine("=====================================================");
            Console.WriteLine();
            Console.WriteLine("TOTAL CALLS COST AFTER CLEARING ALL CALLS: {0:F2} lv.", phone.CalculateTotalCallsCost());
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine();
        }

        public static void DisplayCallInfo(Call call)
        {
            Console.WriteLine(new string('-', 30));
            Console.Write("Date and time: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(call.DateAndTime);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Dialed number: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(call.DialedNumber);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Call Duration: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(call.Duration);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
