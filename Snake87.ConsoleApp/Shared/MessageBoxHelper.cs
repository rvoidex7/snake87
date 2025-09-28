// Ortak terminal bileþenleri için örnek dosya
using Terminal.Gui;

namespace Shared
{
    public class MessageBoxHelper
    {
        public static void ShowInfo(string message)
        {
            MessageBox.Query("Bilgi", message, "Tamam");
        }
    }
}
