using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RunningButton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private double maxHeight;
        //private double maxWidth;
        public MainWindow()
        {
            InitializeComponent();
            //maxHeight = button.ActualHeight;
            //maxWidth = button.ActualWidth;
        }

        private void ButtonMouseMove(object sender, MouseEventArgs e)
        {
            //Random rand = new Random();
            if (button.HorizontalAlignment == HorizontalAlignment.Left)
            {
                button.HorizontalAlignment = HorizontalAlignment.Right;
                if (button.VerticalAlignment == VerticalAlignment.Top)
                {
                    button.VerticalAlignment = VerticalAlignment.Bottom;
                }
                else
                {
                    button.VerticalAlignment = VerticalAlignment.Top;
                }
            }
            else
            {
                button.HorizontalAlignment = HorizontalAlignment.Left;
                if (button.VerticalAlignment == VerticalAlignment.Top)
                {
                    button.VerticalAlignment = VerticalAlignment.Bottom;
                }
                else
                {
                    button.VerticalAlignment = VerticalAlignment.Top;
                }
            }
            //button.Height = rand.Next((int)maxHeight);
            //button.Width = rand.Next((int)maxWidth);
        }
    }
}
