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

namespace FirstWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                textBlockHello.Text = "Witaj " + textBoxName.Text + " w tym programie.";
            }
            else
                textBlockHello.Text = "Podano nieprawidłowe dane";
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
                return false;
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
                return false;
            if (!textBoxEmail.Text.Contains("@"))
                return false;
            return true;
        }
    }
}
