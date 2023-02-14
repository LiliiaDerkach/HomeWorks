using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace HW7Plus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int _a = 123;
        public MainWindow()
        {
            InitializeComponent();
        }
        public Brush DetermineBackground(int height)
        {
            if (height == 0)
                return Brushes.Blue;
            else if (height > 0 && height <= 20)
                return Brushes.Green;
            else if (height > 20 && height <= 50)
                return Brushes.Yellow;
            else if (height > 50 && height <= 100)
                return Brushes.DarkOrange;

            return Brushes.White;
        }

        private void ChangeMap(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int[,] heightLevel = new int[3, 3]
            {
                {rand.Next(0, 100),  rand.Next(0, 100),  rand.Next(0, 100)},
                {rand.Next(0, 100),  rand.Next(0, 100),  rand.Next(0, 100)},
                {rand.Next(0, 100),  rand.Next(0, 100),  rand.Next(0, 100)}
            };
            TextBlock[,] arrayTextBlocs = new TextBlock[3, 3]
            {
                { Picture1, Picture2, Picture3},
                { Picture4, Picture5, Picture6},
                { Picture7, Picture8, Picture9}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrayTextBlocs[i, j].Background = DetermineBackground(heightLevel[i, j]);
                    arrayTextBlocs[i, j].Text = Convert.ToString(heightLevel[i, j]);
                }
            }

        }
    }
}



