using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }

        
        private void Btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            /* InputBox.Visibility = System.Windows.Visibility.Collapsed;

             String questioncode = InputTextBox.Text;
             InputTextBox.Text = String.Empty;


             var questiondata = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
             var Questiondetails = from s in questiondata where s.questionCode.Equals(questioncode) select s;

             stk_QuestionDetails.DataContext = Questiondetails;*/

            var quizpage = new StudentCheckIt();
            quizpage.Show();
            this.Close();
        }
    }
}
