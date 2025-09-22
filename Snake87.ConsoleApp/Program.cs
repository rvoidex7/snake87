using SadConsole;
using SadConsole.Configuration;
using Snake87.ConsoleApp; // Kendi GameScreen sınıfımıza ulaşmak için

namespace Snake87.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        // SadConsole v10 için yeni başlangıç yapısı (Builder Pattern)
        Settings.WindowTitle = "Snake87"; // Pencere başlığını buradan ayarlayabiliriz

        // Yeni bir oyun konfigürasyonu oluşturuyoruz
        Builder sadConsoleConfig = new Builder()
            .SetScreenSize(80, 25) // Pencere boyutunu belirliyoruz
            .SetStartingScreen<GameScreen>() // Başlangıç ekranı olarak GameScreen'i göster diyoruz
            .IsStartingScreenFocused(true)
            .ConfigureFonts(); // Varsayılan yazı tipini kullan

        // Bu konfigürasyon ile oyunu oluştur ve çalıştır
        Game.Create(sadConsoleConfig);
        Game.Instance.Run();
        Game.Instance.Dispose();
    }
}