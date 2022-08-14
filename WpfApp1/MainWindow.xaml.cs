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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  Class1 o1;
        public MainWindow()
        {
            InitializeComponent();
            InitFileManager();
        }

        private void InitFileManager()
        {
            //var ui = new WPFUserInterface();
            //var manager = new FileManagerLogic(ui);
            //manager.Start(); ;

            o1 = new Class1();
            o1.v1 = "s1";
            o1.v2 = "t1";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var sometxt = o1.v1;
            MessageBox.Show(sometxt, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            tbox1.Clear();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
           o1.v1=tbox1.Text;
        }

        private void tbox1_TextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("txt input", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //private void tbox1_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var tb = (TextBox)sender;
        //    MessageBox.Show(tb.Text, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        //}


        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                tbox1.Text = "You Entered: " + tbox1.Text;
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
}
