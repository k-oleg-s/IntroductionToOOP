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
using FileManager;
using Commands;

namespace WpfApp1;

public partial class MainWindow 
{
    private void btn1_Click(object sender, RoutedEventArgs e)
    {
        //var sometxt = o1.v1;
        MessageBox.Show("click", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

        Tbox1.Clear();
    }

    private void btnEnter_Click(object sender, RoutedEventArgs e)
    {
        Tbox1.Text="clicked";
    }



    //private void tbox1_TextInput(object sender, TextCompositionEventArgs e)
    //{
    //    MessageBox.Show("txt input", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
    //}

    //private void tbox1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    var tb = (TextBox)sender;
    //    MessageBox.Show(tb.Text, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
    //}


    private void OnKeyDownHandler(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Return)
        {
            var input = _UserInterface.ReadLine("> ", false);

            var args = input.Split(' ');
            var command_name = args[0];

            if (!_Logic.Commands.TryGetValue(command_name, out var command))
            {
                _UserInterface.WriteLine($"Неизвестная команда {command_name}.");
                _UserInterface.WriteLine("Для справки введите help, для выхода quit");
                //continue;
            }

            try
            {
                command.Execute(args/*[1..]*/);
            }
            catch (Exception error)
            {
                _UserInterface.WriteLine($"При выполнении команды {command_name} произошла ошибка:");
                _UserInterface.WriteLine(error.Message);
            }
        }
    }

    private void tbox1_TouchDown(object sender, TouchEventArgs e)
    {
        var tb = (TextBox)sender;
        MessageBox.Show("t dwn", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
    }
    //private void tbox1_OnKeyDownHandler(object sender, KeyEventArgs e)
    //{
    //    if (e.Key == Key.Return)
    //    {
    //        tbox1.Text = "You Entered: " + tbox1.Text;
    //    }
    //}
}
