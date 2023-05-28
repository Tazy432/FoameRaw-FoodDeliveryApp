namespace Good_Friends_Never_Starve
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  nothing interesting here , the app runs the fisr form , and from this form
        ///  the 'magic' begins
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //Application.Run(new FormRestaurante());
        }
    }
}