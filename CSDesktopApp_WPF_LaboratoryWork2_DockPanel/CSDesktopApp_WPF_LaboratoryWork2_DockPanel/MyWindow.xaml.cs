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
using System.Windows.Shapes;


namespace CSDesktopApp_WPF_LaboratoryWork1_1_WpfHello
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {


        public MyWindow()
        {
            InitializeComponent();
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Внесено {0}: {1} ", textBox.Text, DateTime.Now.ToShortDateString() + ", время: " + DateTime.Now.ToLongTimeString());
                writer.Flush();
            }
        }
 
        private bool _close;
        MainWindow wnd1 = null;


public new void Close()
        {
            _close = true;
            base.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            {
                wnd1.myWin = null;
                if (_close) return;
                e.Cancel = true;
                Hide();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wnd1 = Owner as MainWindow;


            if (wnd1 != null)
            {
                wnd1.txtBlock.Text = textBox.Text;
            }
            wnd1.txtBlock.Text = textBox.Text;
            //         PrintLogFile();
            Close();

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
