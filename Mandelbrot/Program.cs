﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
