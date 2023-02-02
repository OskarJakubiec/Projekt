using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Intel886
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> registers = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            registers.Add("AX");
            registers.Add("BX");
            registers.Add("CX");
            registers.Add("DX");
            Source.ItemsSource = registers;
            Destination.ItemsSource = registers;

        }

        private void MOV(object sender, RoutedEventArgs e)
        {
            TextBox SelectedSource = null;
            TextBox SelectedDestination = null;
            switch (Source.SelectedItem)
            {
                case "AX":
                    SelectedSource = AX;
                    break;
                case "BX":
                    SelectedSource = BX;
                    break;
                case "CX":
                    SelectedSource = CX;
                    break;
                case "DX":
                    SelectedSource = DX;
                    break;

            }
            switch (Destination.SelectedItem)
            {
                case "AX":
                    SelectedDestination = AX;
                    break;
                case "BX":
                    SelectedDestination = BX;
                    break;
                case "CX":
                    SelectedDestination = CX;
                    break;
                case "DX":
                    SelectedDestination = DX;
                    break;

            }
            if (SelectedSource != null && SelectedDestination != null && SelectedSource != SelectedDestination)
            {
                SelectedDestination.Text = SelectedSource.Text;
                Console.Text += "\n Przenoszenie zakończone.";
            }
            else
            {
                Console.Text += "\n Przenoszenie nieudane, wystąpił błąd.";
            }
        }
        private void POP(object sender, RoutedEventArgs e)
        {
            TextBox SelectedSource = null;
            switch (Source.SelectedItem)
            {
                case "AX":
                    SelectedSource = AX;
                    break;
                case "BX":
                    SelectedSource = BX;
                    break;
                case "CX":
                    SelectedSource = CX;
                    break;
                case "DX":
                    SelectedSource = DX;
                    break;
            }
            if (SelectedSource != null)
            {
                SelectedSource.Text = "";
                Console.Text += "\n Usuwanie zakończone.";
            }
            else
            {
                Console.Text += "\n Usuwanie nieudane, wystąpił błąd.";
            }

        }
        private void ADD(object sender, RoutedEventArgs e)
        {
            TextBox SelectedSource = null;
            TextBox SelectedDestination = null;
            switch (Source.SelectedItem)
            {
                case "AX":
                    SelectedSource = AX;
                    break;
                case "BX":
                    SelectedSource = BX;
                    break;
                case "CX":
                    SelectedSource = CX;
                    break;
                case "DX":
                    SelectedSource = DX;
                    break;

            }
            switch (Destination.SelectedItem)
            {
                case "AX":
                    SelectedDestination = AX;
                    break;
                case "BX":
                    SelectedDestination = BX;
                    break;
                case "CX":
                    SelectedDestination = CX;
                    break;
                case "DX":
                    SelectedDestination = DX;
                    break;

            }
            if (SelectedSource != null && SelectedDestination != null && SelectedSource != SelectedDestination)
            {
                int val = int.Parse(SelectedSource.Text);
                int val2 = int.Parse(SelectedDestination.Text);
                SelectedDestination.Text = (val + val2).ToString();
                Console.Text += "\n Dodawanie zakończone.";
            }
            else
            {
                Console.Text += "\n Dodawanie nieudane, wystąpił błąd.";
            }
        }
        private void SUB(object sender, RoutedEventArgs e)
        {
            TextBox SelectedSource = null;
            TextBox SelectedDestination = null;
            switch (Source.SelectedItem)
            {
                case "AX":
                    SelectedSource = AX;
                    break;
                case "BX":
                    SelectedSource = BX;
                    break;
                case "CX":
                    SelectedSource = CX;
                    break;
                case "DX":
                    SelectedSource = DX;
                    break;

            }
            switch (Destination.SelectedItem)
            {
                case "AX":
                    SelectedDestination = AX;
                    break;
                case "BX":
                    SelectedDestination = BX;
                    break;
                case "CX":
                    SelectedDestination = CX;
                    break;
                case "DX":
                    SelectedDestination = DX;
                    break;

            }
            if (SelectedSource != null && SelectedDestination != null && SelectedSource != SelectedDestination)
            {
                int val = int.Parse(SelectedSource.Text);
                int val2 = int.Parse(SelectedDestination.Text);
                SelectedDestination.Text = (val2 - val).ToString();
                Console.Text += "\n Odejmowanie zakończone.";
            }
            else
            {
                Console.Text += "\n Odjemowanie nieudane, wystąpił błąd.";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
