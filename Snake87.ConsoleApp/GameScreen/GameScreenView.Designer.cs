using Terminal.Gui;

namespace GameScreen
{
    public partial class GameScreenView : Window
    {
        private Label labelGame;
        private Button buttonBack;

        private void InitializeComponent()
        {
            this.labelGame = new Label()
            {
                Text = "Game Screen",
                X = Pos.Center(),
                Y = Pos.Center(),
                Width = 12,
                Height = 1
            };
            this.buttonBack = new Button()
            {
                Text = "Back to Menu",
                X = Pos.Center(),
                Y = Pos.Center() + 2,
                Width = 16
            };
            this.Add(labelGame);
            this.Add(buttonBack);
        }
    }
}
