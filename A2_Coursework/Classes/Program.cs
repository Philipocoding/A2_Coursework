namespace A2_Coursework.Classes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SetupDataDirectoryPath();
            Application.Run(new MainMenu());
        }
        private static void SetupDataDirectoryPath()
        {
            string debugPath = Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
        }
    }
}