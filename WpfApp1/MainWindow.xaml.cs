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
        //public Class1 o1;

        private WPFUserInterface _UserInterface;
        private FileManagerLogic _Logic;
        public MainWindow()
        {
            InitializeComponent();
            InitFileManager();
        }

        private void InitFileManager()
        {
            MainWin.Title = "Файловый менеджер v2.0";
            _UserInterface = new WPFUserInterface(this);
            _Logic = new FileManagerLogic(_UserInterface);
            //manager.Start(); 

            //o1 = new Class1();
            //o1.v1 = "s1";
            //o1.v2 = "t1";
        }


    }
}
