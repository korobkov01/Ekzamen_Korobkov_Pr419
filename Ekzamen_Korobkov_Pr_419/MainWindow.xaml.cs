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

namespace Ekzamen_Korobkov_Pr_419
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxName.Text.Length < 4 || textBoxName.Text.Length > 50)
            {
                textBoxName.Background = Brushes.Red;
                string text = "Название блюда должно быть от 4 до 50 символов";
                textBlock1.Text = text;
            }
            else
            {
                textBoxName.Background = Brushes.White;
                string text = "";
                textBlock1.Text = text;
            }
        }

        private void textBoxIngridient_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxIngridient.Text.Length < 10 || textBoxIngridient.Text.Length > 35)
            {
                textBoxIngridient.Background = Brushes.Red;
                string text = "Название ингридиента должно быть от 10 до 35 символов";
                textBlock2.Text = text;
            }
            else
            {
                textBoxIngridient.Background = Brushes.White;
                string text = "";
                textBlock2.Text = text;
            }
        }

        private void textBoxColichestvo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || textBoxColichestvo.Text.Length >= 4 || (textBoxColichestvo.Text == "0" && e.Text == "0") || (textBoxColichestvo.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }

    }
}

