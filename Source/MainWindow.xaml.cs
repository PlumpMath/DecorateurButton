using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DecorateurButton
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IButton button = new Button(30, 80, Color.FromRgb(128,128,128), 100);
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contient une fonction de couleur aléatoire qui change la couleur du boutton
        /// </summary>
        public void RandomColor()
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)(random.Next(0, 255)), (byte)(random.Next(0, 255)), (byte)(random.Next(0, 255)));
            Button.Background = new SolidColorBrush(button.GetColor(color));
        }


        /// <summary>
        /// Lors d'un évènement click boutton sur "Hidden", l'opacité devient égale à 0
        /// </summary>
        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            button = new HideEffect(button);
            Button.Opacity = button.GetOpacite();          
        }

        /// <summary>
        /// Lors d'un évènement click boutton sur "Soupe", la taille est doublée
        /// </summary>
        private void ButtonBigger_Click(object sender, RoutedEventArgs e)
        {
            button = new BiggerEffect(button);
            Button.Height = button.GetHauteur();
            Button.Width = button.GetLargeur();
        }

        /// <summary>
        /// Lors d'un évènement click boutton sur "Color", la couleur est changée
        /// </summary>
        private void ButtonColor_Click(object sender, RoutedEventArgs e)
        {
            button = new ColorEffect(button);
            RandomColor();
        }
    }
}
