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
    /// Interaction logic for StudentCheckIt.xaml
    /// </summary>
    public partial class StudentCheckIt : Window
    {
        public StudentCheckIt()
        {
            InitializeComponent();
        }

        private void Btn_FinishQuiz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your answer has been submitted successfully");
        }
    }
}
