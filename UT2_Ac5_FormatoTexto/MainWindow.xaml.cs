using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace UT2_Ac5_FormatoTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void inputTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            outputTextBlock.Text = inputTextBlock.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.FontStyle = FontStyles.Normal;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            outputTextBlock.Foreground = Brushes.Green;
        }
    }
}
