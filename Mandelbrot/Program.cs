﻿using System.Windows.Forms;

namespace Mandelbrot
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();
            Application.Run(ui);
        }
    }
}
