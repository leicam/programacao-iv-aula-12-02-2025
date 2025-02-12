using System.Windows;

namespace Fundamentos.ProgramacaoIV;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonByte_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{byte.MinValue} - {byte.MaxValue}");
    }

    private void ButtonShort_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{short.MinValue} - {short.MaxValue}");
    }

    private void ButtonUshort_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{ushort.MinValue} - {ushort.MaxValue}");
    }

    private void ButtonInt_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{int.MinValue} - {int.MaxValue}");
    }

    private void ButtonUint_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{uint.MinValue} - {uint.MaxValue}");
    }

    private void ButtonLong_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{long.MinValue} - {ulong.MaxValue}");
    }

    private void ButtonUlong_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{ulong.MinValue} - {ulong.MaxValue}");
    }

    private void ButtonFloat_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{float.MinValue} - {float.MaxValue}");
    }

    private void ButtonDouble_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{double.MinValue} - {double.MaxValue}");
    }

    private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{decimal.MinValue} - {decimal.MaxValue}");
    }

    private void ButtonValidacao_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"10.10f + 20.20f == 30.30f | resultado = {10.10f + 20.20f == 30.30f}");
        MessageBox.Show($"10.10m + 20.20m == 30.30m | resultado = {10.10m + 20.20m == 30.30m}");
    }
}