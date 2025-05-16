using System.Windows;

namespace zad3;

public partial class DecryptionWindow : Window
{
    public DecryptionWindow()
    {
        InitializeComponent();
    }

    private void DecryptButton_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(ShiftTextBox.Text, out int shift))
        {
            ResultTextBox.Text = CaesarCipher.Decrypt(InputTextBox.Text, shift);
        }
        else
        {
            MessageBox.Show("Invalid shift value!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}