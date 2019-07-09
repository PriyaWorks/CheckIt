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
using System.Xml;

namespace CheckIt
{
    /// <summary>
    /// Interaction logic for AddQuestion.xaml
    /// </summary>
    public partial class AddQuestion : Window
    {
        public AddQuestion()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_SaveQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = DbUtility.ReadXml<ObservableCollection<Question>>("Question.xml");
                var question = new ObservableCollection<Question>();
                Question qs = new Question();
                qs.TopicId = "text";
                XmlDocument doc = new XmlDocument();
                doc.Load("Question.xml");
                int count = 1;
                foreach (XmlNode x in doc.SelectNodes("ArrayOfQuestion/Question"))
                {
                    count = count + 1;
                }
                string questionid = Convert.ToString(count);
                qs.QuestionId = questionid;
                qs.QuestionDesc = Question.Text;
                qs.Option1 = OptionA.Text;
                qs.Option2 = OptionB.Text;
                qs.Option3 = OptionC.Text;
                qs.Option4 = OptionD.Text;
                qs.CorrectAnswer = CorrectAnswer.Text;
                {
                    data.Add(qs);
                    DbUtility.WriteXml<ObservableCollection<Question>>(data, "Question.xml");
                    MessageBox.Show("Question successfully added");

                    var gotomain = new MainWindow();
                    gotomain.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
