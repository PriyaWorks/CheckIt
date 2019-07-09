using CheckIt.Properties;
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

namespace CheckIt
{
    /// <summary>
    /// Interaction logic for Breadcrum.xaml
    /// </summary>
    public partial class Breadcrum : Window
    {
        public Breadcrum()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Btn_ViewResult_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

            var viewresult = new ViewResult();
            viewresult.Show();
            this.Close();
        }

       

        private void Btn_ManageQuestions_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

            var managequestions = new ManageQuestions();
            managequestions.Show();
            this.Close();
        }

        private void Btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

            var settings = new Settings();
            settings.Show();
            this.Close();
            
        }
    }
}
