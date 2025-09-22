using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = SadConsole.Console;
using SadConsole;
using SadConsole.Configuration;
using SadRogue.Primitives;

namespace Snake87.ConsoleApp
{
    internal class GameScreen : Console
    {
        public GameScreen() : base(80, 25) // base(80, 25) komutu, bu ekranın boyutlarını belirler.
        {
            // Ekrana başlangıç mesajlarımızı yazalım.
            // Print(x, y, "mesaj") komutu, belirtilen koordinata metin yazar.
            this.Print(1, 1, "SadConsole basariyla baslatildi!");
            this.Print(1, 3, "Artik oyununu gelistirmeye hazirsin.");
        }

        // Bu Update metodu, oyunun her bir karesinde (saniyede yaklaşık 60 kez) otomatik olarak çalışır.
        // Klavye dinleme ve oyun mantığını güncelleme gibi işlemler burada yapılacak.
        public override void Update(TimeSpan delta)
        {
            // Şimdilik burası boş kalabilir.

            // base.Update(delta) satırı, SadConsole'in kendi iç güncellemelerini yapması için önemlidir.
            base.Update(delta);
        }

    }
}
