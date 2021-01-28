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

namespace Assignment_Week1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }


        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            if (txt.Text == "Facebook" || txt.Text == "Google" || txt.Text =="Line" || txt.Text =="OnlineHD" || txt.Text == "Thanachot")
            {
                showTxt.Text = "[ Google ] is found.";
            }
            else
            {
                showTxt.Text = "[ Google ] is not found.";
            }
        }
    }
}
