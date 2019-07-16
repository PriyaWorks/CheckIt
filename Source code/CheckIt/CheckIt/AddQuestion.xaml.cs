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
        public string topicid = "";

        public AddQuestion(string val)
        {
            InitializeComponent( );
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            topicid = val;

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var data = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            var Topics = from s in data where s.topicId.Equals(topicid) select s;
            {
                stk_TopicName.DataContext = Topics;
            }
        }


        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Btn_SaveQuestion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
                var question = new ObservableCollection<Question>();
                Question qs = new Question();
                qs.topicId = topicid;
                XmlDocument doc = new XmlDocument();
                doc.Load("Questions.xml");
                int count = 1;
                foreach (XmlNode x in doc.SelectNodes("ArrayOfQuestion/Question"))
                {
                    count = count + 1;
                }
                string questionid = Convert.ToString(count);
                qs.questionId = questionid;
                qs.questionDesc = QuestionDesciption.Text;
                qs.optionA = OptionA.Text;
                qs.optionB = OptionB.Text;
                qs.optionC = OptionC.Text;
                qs.optionD = OptionD.Text;
                //qs.corectionAnswer = CorrectAnswer.Text;
                qs.optionAStatus = Convert.ToString(Chbx_A.IsChecked);
                qs.optionBStatus = Convert.ToString(Chbx_A.IsChecked);
                qs.optionCStatus = Convert.ToString(Chbx_A.IsChecked);
                qs.optionDStatus = Convert.ToString(Chbx_A.IsChecked);

                Random random = new Random();
                var code = Convert.ToString(random.Next(999, 10000));
                qs.questionCode = code;

                if (string.IsNullOrEmpty(QuestionDesciption.Text) || string.IsNullOrEmpty(OptionA.Text) || string.IsNullOrEmpty(OptionB.Text) || string.IsNullOrEmpty(OptionC.Text) || string.IsNullOrEmpty(OptionD.Text) )
                {
                    MessageBox.Show("Please enter the vlaues in all fields");
                }
                else
                
                {
                    data.Add(qs);
                    DbUtility.WriteXml<ObservableCollection<Question>>(data, "Questions.xml");
                    MessageBox.Show("Question successfully added");

                    var manageQuestion = new ManageQuestion();
                    manageQuestion.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Btn_BackToManageQues_Click(object sender, RoutedEventArgs e)
        {
            var manageQuestion = new ManageQuestion();
            manageQuestion.Show();
            this.Close();
        }
        /*string questioncode;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var data = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var Questions = from sn in data where sn.questionCode.Equals(questionCode) select sn;
            {
                stk_QuestionDetails.DataContext = Questions;
            }
            XmlDocument xdocum = new XmlDocument();
            xdocum.Load("Questions.xml");
            foreach (XmlNode x in xdocum.SelectNodes("ArrayOfQuestion/Question"))
                if (x.SelectSingleNode("questionCode").InnerText == questionCode)
                {
                    string topicids = x.SelectSingleNode("topicId").InnerText;
                    int topicidas = Convert.ToInt32(topicids) + 1;
                    topicid = Convert.ToString(topicidas);

                }

            var topicdata = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            var topic = from tn in topicdata where tn.topicId.Equals(topicid) select tn;
            {
                stk_TopicName.DataContext = topic;
            }
        }*/
    }
}
