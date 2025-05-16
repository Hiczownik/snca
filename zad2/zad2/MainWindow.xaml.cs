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

namespace zad2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(weightTextBox.Text, out double weight) || weight <= 0)
        {
            resultText.Text = "Please enter a valid positive weight in kilograms.";
            return;
        }

        if (!double.TryParse(heightTextBox.Text, out double height) || height <= 0)
        {
            resultText.Text = "Please enter a valid positive height in centimeters.";
            return;
        }

        double heightMeters = height / 100;
        double bmi = weight / (heightMeters * heightMeters);
        bmi = Math.Round(bmi, 1);

        (string category, string risk) = GetBmiCategory(bmi);

        resultText.Text = $"Your BMI: {bmi}\nCategory: {category}\nHealth Risks: {risk}";
    }

    private (string category, string risk) GetBmiCategory(double bmi)
    {
        switch (bmi)
        {
            case < 18.5:
                return ("Underweight", "Increased risk of nutritional deficiencies and osteoporosis");
            case < 25:
                return ("Normal weight", "Low risk of health issues");
            case < 30:
                return ("Overweight", "Increased risk of cardiovascular diseases");
            case < 35:
                return ("Obesity class I", "Moderate risk of diabetes, hypertension");
            case < 40:
                return ("Obesity class II", "Severe risk of health complications");
            default:
                return ("Obesity class III", "Very severe risk, urgent medical attention needed");
        }
    }
}