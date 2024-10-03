using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNumberToDisplay(object sender, RoutedEventArgs e)
        {
            displayField.Text += ((Button)sender).Content;
        }
        private void ClearDisplay(object sender, RoutedEventArgs e)
        {
            displayField.Clear();
        }
        private void AddActionToDisplay(object sender, RoutedEventArgs e)
        {
            displayField.Text += ((Button)sender).Content;
        }
        private void DeleteOneActionFromDisplay(object sender, RoutedEventArgs e)
        {
            displayField.Text = displayField.Text.Remove(displayField.Text.Length - 1);
        }

        private void CalcResult(object sender, RoutedEventArgs e)
        {
            if (displayField.Text.Contains('+'))
            {
                string[] numbers = displayField.Text.Split('+');

                if (numbers.Length == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (numbers[i] == string.Empty)
                        {
                            numbers[i] = "0";
                        }
                    }

                    displayField.Text = (Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1])).ToString();
                }
                else
                {
                    displayField.Text = "Ошибка!";
                }
            }
            else if (displayField.Text.Contains('-'))
            {
                string[] numbers = displayField.Text.Split('-');

                if (numbers.Length == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (numbers[i] == string.Empty)
                        {
                            numbers[i] = "0";
                        }
                    }

                    displayField.Text = (Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1])).ToString();
                }
                else
                {
                    displayField.Text = "Ошибка!";
                }
            }
            else if (displayField.Text.Contains('*'))
            {
                string[] numbers = displayField.Text.Split('*');

                if (numbers.Length == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (numbers[i] == string.Empty)
                        {
                            numbers[i] = "0";
                        }
                    }

                    displayField.Text = (Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1])).ToString();
                }
                else
                {
                    displayField.Text = "Ошибка!";
                }
            }
            else if (displayField.Text.Contains('/'))
            {
                string[] numbers = displayField.Text.Split('/');

                if (numbers.Length == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (numbers[i] == string.Empty)
                        {
                            numbers[i] = "0";
                        }
                    }

                    displayField.Text = (Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1])).ToString();
                }
                else
                {
                    displayField.Text = "Ошибка!";
                }
            }
        }
    }
}