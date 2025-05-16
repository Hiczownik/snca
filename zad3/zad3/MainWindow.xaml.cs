using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zad3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void EncryptButton_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(ShiftTextBox.Text, out int shift))
        {
            ResultTextBox.Text = CaesarCipher.Encrypt(InputTextBox.Text, shift);
        }
        else
        {
            MessageBox.Show("Invalid shift value!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void OpenDecryptionWindowButton_Click(object sender, RoutedEventArgs e)
    {
        new DecryptionWindow().Show();
    }
}