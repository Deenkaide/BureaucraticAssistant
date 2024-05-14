namespace BureaucracyHelper
{
    class DocumentsMaker
    {
        public static string document;

        public static string name = UserDataInput.name;
        public static string post = UserDataInput.post;
        public static string station = UserDataInput.station;

        public static string day = UserDataInput.dayString;
        public static string month = UserDataInput.monthString;
        public static string year = UserDataInput.yearString;

        public static string iaa1 = "[color=lime]███░███░░░░██░░░░[/color]\r\n[color=lime]░██░████░░░██░░░░[/color] [head=3]Бланк документа[/head]\r\n[color=lime]░░█░██░██░░██░█░░[/color] [head=3]NanoTrasen[/head]\r\n[color=lime]░░░░██░░██░██░██░[/color] [bold]station ПД-ЮР[/bold]\r\n[color=lime]░░░░██░░░████░███[/color]\r\n╔════════════════════════════════════════╗\r\n           ЖАЛОБА НА НАРУШЕНИЕ ТРУДОВОГО ПОРЯДКА\r\n╚════════════════════════════════════════╝\r\nВремя от начала смены и дата: __:__, day.month.year\r\nСоставитель документа: name\r\nДолжность составителя: post\r\n\r\nЯ, name, в должности post, считаю, что в ходе работы (наименование отдела/имя и полное наименование должности) были допущены следующие нарушения:\r\n\r\nПрошу провести внутреннюю проверку по данным фактам нарушений.\r\n══════════════════════════════════════════\r\n                                      [italic]Место для печатей[/italic]\r\n\r\n";
        public static string iaa2 = "[color=lime]███░███░░░░██░░░░[/color]\r\n[color=lime]░██░████░░░██░░░░[/color] [head=3]Бланк документа[/head]\r\n[color=lime]░░█░██░██░░██░█░░[/color] [head=3]NanoTrasen[/head]\r\n[color=lime]░░░░██░░██░██░██░[/color] [bold]station ЮР-КОМ[/bold]\r\n[color=lime]░░░░██░░░████░███[/color]\r\n╔════════════════════════════════════════╗\r\n           ЖАЛОБА НА НАРУШЕНИЕ ТРУДОВОГО ПОРЯДКА\r\n╚════════════════════════════════════════╝\r\nВремя от начала смены и дата: __:__, day.month.year\r\nСоставитель документа: name\r\nДолжность составителя: post\r\n\r\nЯ, name, в должности post, зафиксировал, что в ходе работы ___ были допущены следующие нарушения:\r\n► ___\r\n\r\nПрошу провести разбирательств по данным фактам нарушений. Игнорирование Жалобы является нарушением СРП Главы Отдела, Обязанностей, Пункта 7.\r\n══════════════════════════════════════════\r\n                                      [italic]Место для печатей[/italic]\r\n\r\n";

        public static void DocumentsConstructor()
        {
            Console.WriteLine("Введите код документа или restart чтобы сменить персонажа");
            DocumentsMaker.document = Console.ReadLine();
            switch (document)
            {
                case "restart":
                    UserDataInput.Input();
                    break;
                case "iaa1":
                    iaa1 = iaa1.Replace("name", name).Replace("post", post).Replace("station", station).Replace("day", day).Replace("month", month).Replace("year", year);
                    Console.WriteLine(iaa1);
                    break;
                case "iaa2":
                    iaa2 = iaa2.Replace("name", name).Replace("post", post).Replace("station", station).Replace("day", day).Replace("month", month).Replace("year", year);
                    Console.WriteLine(iaa2);
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
        }
    }
}
