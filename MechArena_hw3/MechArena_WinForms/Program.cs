using GameMode;

namespace MechArena_WinForms
{
    internal static class Program
    {

        static public Game? game1;
        [STAThread]
        static void Main()
        {
            game1 = new Game(GameType.PvP);
            game1.startGame(); 

           // ApplicationConfiguration.Initialize();
           // Application.Run(new Form1());
        }

}
}