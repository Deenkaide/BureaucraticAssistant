using System.Reflection.Metadata;

namespace BureaucracyHelper
{
    class UserDataInput
    {
        public static string name;
        public static string post;
        public static string station;

        public static int day = DateTime.Now.Day;
        public static string dayString;
        public static int month = DateTime.Now.Month;
        public static string monthString;
        public static int year = DateTime.Now.Year + 1000;
        public static string yearString = year.ToString();

        public static void Date()
        {
            if (month < 10) { monthString = "0" + month.ToString(); }
            else { monthString = month.ToString(); }

            if (day < 10) { dayString = "0" + day.ToString(); }
            else { dayString = day.ToString(); }
        }

        public static void Input()
        {
            Console.WriteLine("Введите ФИО");
            name = Console.ReadLine();
            Console.WriteLine("Введите Должность");
            post = Console.ReadLine();
            Console.WriteLine("Введите название станции в формате Station XX-000");
            station = Console.ReadLine();
        }
    }
}
