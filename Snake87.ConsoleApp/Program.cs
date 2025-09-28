using System;
using Terminal.Gui;
using MainMenu;
using GameScreen;

namespace Snake87.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            var menu = new MyView();
            Application.Top.Add(menu);
            Application.Run();
        }
    }
}
