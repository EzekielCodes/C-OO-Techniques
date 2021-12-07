using snakeForm.logica;
namespace snakeForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            var game = new Game();
            Application.Run(new Form1(game));
        }
    }
}