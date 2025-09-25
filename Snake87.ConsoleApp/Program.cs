using SadConsole;
using SadConsole.Configuration;
using Snake87.ConsoleApp;

namespace Snake87.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Settings.WindowTitle = "Snake87";

        Builder sadConsoleConfig = new Builder()
            .SetScreenSize(80, 25)
            .SetStartingScreen<GameScreen>()
            .IsStartingScreenFocused(true)
            .ConfigureFonts();

        GameScreen.Create(sadConsoleConfig);
        Game.Instance.Run();
        Game.Instance.Dispose();
    }
}