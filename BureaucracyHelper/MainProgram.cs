namespace BureaucracyHelper
{
    class MainProgram
    {
        public static bool isWork = true;
        
        public static void Main()
        {
            UserDataInput.Input();
            while (isWork)
            {
                UserDataInput.Date();
                DocumentsMaker.DocumentsConstructor();

                //Console.WriteLine("Введите exit, чтобы выйти");
                //if (Console.ReadLine() == "exit")
                //{
                //    isWork = false;
                //}
                //else { }
            }
        }
    }
}