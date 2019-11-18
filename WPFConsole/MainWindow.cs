using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFConsole
{
    class MainWindow : Window
    {
        public MainWindow(string windowTitle, int heigth, int width)
        {
            this.Title = windowTitle;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Height = heigth;
            this.Width = width;
        }
    }
}
