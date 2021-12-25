using snakeForm.logica;
namespace snakeForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            
            ApplicationConfiguration.Initialize();
            var game = await Game.Create();  
            Application.Run(new Form1(game));
        }
    }
}