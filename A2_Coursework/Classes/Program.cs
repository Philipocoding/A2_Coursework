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
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SetupDataDirectoryPath();
            StockDAL.AddStock();
            Application.Run(new MainMenu());
        }
        private static void SetupDataDirectoryPath()
        {
            string debugPath = Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
            Booking.PopulateDictionary();
            OrderStock.populateDictionary();
            Booking.Populate_Dictionary();
            Stock.PopulateList();
        }
    }
}