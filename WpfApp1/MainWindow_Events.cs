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
    private void btnEnter_Click(object sender, RoutedEventArgs e)
    {
        EnterPressed();
    }

    private void EnterPressed()
    {
        var input = _UserInterface.ReadLine("> ", false);

        var args = input.Split(' ');
        var command_name = args[0];

        _UserInterface.ClearLeftTb();

        if (!_Logic.Commands.TryGetValue(command_name, out var command))
        {
            _UserInterface.WriteLine($"Неизвестная команда {command_name}.");
            _UserInterface.WriteLine("Для справки введите help, для выхода quit");
            //continue;
        }
        else
            try
            {
                command.Execute(args/*[1..]*/);
            }
            catch (Exception error)
            {
                _UserInterface.WriteLine($"При выполнении команды {command_name} произошла ошибка:");
                _UserInterface.WriteLine(error.Message);
            }
        _UserInterface.ClearCommandPrompt();
    }

    private void Help_Click(object sender, RoutedEventArgs e)
    {
        var input = "help";

        var args = input.Split(' ');
        var command_name = args[0];

        _UserInterface.ClearLeftTb();

        if (!_Logic.Commands.TryGetValue(command_name, out var command))
        {
            _UserInterface.WriteLine($"Неизвестная команда {command_name}.");
            _UserInterface.WriteLine("Для справки введите help, для выхода quit");
            //continue;
        }
        else
            try
            {
                command.Execute(args/*[1..]*/);
            }
            catch (Exception error)
            {
                _UserInterface.WriteLine($"При выполнении команды {command_name} произошла ошибка:");
                _UserInterface.WriteLine(error.Message);
            }
        Tbox1.Focus();
    }

    private void Attr_Click(object sender, RoutedEventArgs e)
    {
        _UserInterface.ClearLeftTb();
        _UserInterface.WriteLine("Для просмотра атрибутов команда: attr show [file_name] ");
        _UserInterface.WriteLine("Для установки атрибута команда: attr set [attr_name: Hidden/Compressed/ReadOnly/System] [value: true/false] file [file_name] ");
        Tbox1.Focus();
    }

    private void Statistics_Click(object sender, RoutedEventArgs e)
    {
        _UserInterface.ClearLeftTb();
        _UserInterface.WriteLine("Статистика по текстовому файлу: text_stat [file_name] ");
        Tbox1.Focus();
    }

    //private void tbox1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    var tb = (TextBox)sender;
    //    MessageBox.Show(tb.Text, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
    //}


    private void OnKeyDownHandler(object sender, KeyEventArgs e)
    {
        var sndr = (TextBox)sender;
        if (e.Key == Key.Return  && sndr.Name == "Tbox1" )
        {
            EnterPressed();            
        }
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}
