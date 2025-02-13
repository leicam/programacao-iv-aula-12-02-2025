using Fundamentos.ProgramacaoIV.Enums;
using Fundamentos.ProgramacaoIV.Extensions;
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
        MessageBox.Show($"{byte.MinValue} : {byte.MaxValue}");
    }

    private void ButtonShort_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{short.MinValue} : {short.MaxValue}");
    }

    private void ButtonUshort_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{ushort.MinValue} : {ushort.MaxValue}");
    }

    private void ButtonInt_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{int.MinValue} : {int.MaxValue}");
    }

    private void ButtonUint_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{uint.MinValue} : {uint.MaxValue}");
    }

    private void ButtonLong_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{long.MinValue} : {ulong.MaxValue}");
    }

    private void ButtonUlong_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{ulong.MinValue} : {ulong.MaxValue}");
    }

    private void ButtonFloat_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{float.MinValue} : {float.MaxValue}");
    }

    private void ButtonDouble_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{double.MinValue} : {double.MaxValue}");
    }

    private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{decimal.MinValue} : {decimal.MaxValue}");
    }

    private void ButtonValidacao_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"10.10f + 20.20f == 30.30f | resultado = {10.10f + 20.20f == 30.30f}");
        MessageBox.Show($"10.10m + 20.20m == 30.30m | resultado = {10.10m + 20.20m == 30.30m}");
    }

    private void ButtonDataUm_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"DateTime.Now = {DateTime.Now}");
        MessageBox.Show($"DateTime.Now.ToString(\"dd/MM/yyyy\") = {DateTime.Now.ToString("dd/MM/yyyy")}");
        MessageBox.Show($"DateTime.Now.ToString(\"dd/MM/yyyy hh:mm:ss\") = {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");
        MessageBox.Show($"DateTime.Now.ToString(\"dd/MM/yyyy HH:mm:ss\") = {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
    }

    private void ButtonDataDois_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy/MM/dd\") = {DateTime.Now.ToString("yyyy/MM/dd")}");
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy/MM/dd hh:mm:ss\") = {DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")}");
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy/MM/dd HH:mm:ss\") = {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
    }

    private void ButtonDataTres_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy/dd/MM\") = {DateTime.Now.ToString("yyyy/dd/MM")}");
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy/dd/MM hh:mm:ss\") = {DateTime.Now.ToString("yyyy/dd/MM hh:mm:ss")}");
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy/dd/MM HH:mm:ss\") = {DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss")}");
    }

    private void ButtonDataQuatro_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy-MM-dd\") = {DateTime.Now.ToString("yyyy-MM-dd")}");
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy-MM-dd hh:mm:ss\") = {DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}");
        MessageBox.Show($"DateTime.Now.ToString(\"yyyy-MM-dd HH:mm:ss\") = {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
    }

    private void ButtonDataExtenso_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"DateTime.Now.ToShortTimeString() = {DateTime.Now.ToShortTimeString()}");
        MessageBox.Show($"DateTime.Now.ToShortDateString() = {DateTime.Now.ToShortDateString()}");
        MessageBox.Show($"DateTime.Now.ToLongTimeString() = {DateTime.Now.ToLongTimeString()}");
        MessageBox.Show($"DateTime.Now.ToLongDateString() = {DateTime.Now.ToLongDateString()}");
        MessageBox.Show($"DateTime.Now.ToLocalTime() = {DateTime.Now.ToLocalTime()}");
    }

    private void ButtonBoolean_Click(object sender, RoutedEventArgs e)
    {        
        MessageBox.Show($"Verdadeiro = {true}");
        MessageBox.Show($"Falso = {false}");
    }

    private void ButtonEnum_Click(object sender, RoutedEventArgs e)
    {
        var diasUteis = TipoDiasDaSemana.Segunda
            | TipoDiasDaSemana.Terca
            | TipoDiasDaSemana.Quarta
            | TipoDiasDaSemana.Quinta
            | TipoDiasDaSemana.Sexta;

        var finalDeSemana = TipoDiasDaSemana.Sabado
            | TipoDiasDaSemana.Domingo;

        MessageBox.Show($"diasUteis = {diasUteis}");
        MessageBox.Show($"finalDeSemana = {finalDeSemana}");
        MessageBox.Show($"GetDescription = {TipoDiasDaSemana.Sexta.GetDescription()}");
    }
}