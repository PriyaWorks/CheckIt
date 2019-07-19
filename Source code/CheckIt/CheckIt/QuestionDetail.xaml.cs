
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
    /// Interaction logic for QuestionDetail.xaml
    /// </summary>
    public partial class QuestionDetail : Window
    {
        string questioncode;
        string topicid;
        public string questionid;

        public QuestionDetail(string id)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            //fetch the project details from Projects.xml and display it on Projectdetail page.
            questionid = id;
            var questiondata = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var Questiondetails = from s in questiondata where s.questionId.Equals(questionid) select s;

            stk_QuestionDetails.DataContext = Questiondetails;
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var data = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var Questions = from sn in data where sn.questionId.Equals(questionid) select sn;
            {
                stk_QuestionDetails.DataContext = Questions;
            }
            XmlDocument xdocum = new XmlDocument();
            xdocum.Load("Questions.xml");
            foreach (XmlNode x in xdocum.SelectNodes("ArrayOfQuestion/Question"))
                if (x.SelectSingleNode("questionId").InnerText == questionid)
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
        }

        private void Btn_SaveQuestion_Click(object sender, RoutedEventArgs e)
        {
            var pro = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var question = new ObservableCollection<Question>();
            var qs = pro.First(f => f.questionId == QuestionId.Text);
            qs.questionDesc = Question.Text;
            qs.optionA = OptionA.Text;
            qs.optionB = OptionB.Text;
            qs.optionC = OptionC.Text;
            qs.optionD = OptionD.Text;
            qs.optionAStatus = Convert.ToString(Chbx_A.IsChecked);
            qs.optionBStatus = Convert.ToString(Chbx_B.IsChecked);
            qs.optionCStatus = Convert.ToString(Chbx_C.IsChecked);
            qs.optionDStatus = Convert.ToString(Chbx_D.IsChecked);
            DbUtility.WriteXml<ObservableCollection<Question>>(pro, "Questions.xml");
            MessageBox.Show("Question Successfully Updated");
            var manageQuestion = new ManageQuestion();
            manageQuestion.Show();
            this.Close();
        }

        private void Btn_BackToManageQues_Click(object sender, RoutedEventArgs e)
        {
            var manageQues = new ManageQuestion();
            manageQues.Show();
            
        }

        private void Btn_DeleteQuestion_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Are you sure you want to delete the Question", "Delete Question", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    XmlDocument docu = new XmlDocument();
                    docu.Load("Questions.xml");
                    foreach (XmlNode x in docu.SelectNodes("ArrayOfQuestion/Question"))
                        if (x.SelectSingleNode("questionId").InnerText == QuestionId.Text)
                        {
                            x.ParentNode.RemoveChild(x);
                            docu.Save("Questions.xml");
                        }
                    var manageQuestion = new ManageQuestion();
                    manageQuestion.Show();
                    this.Close();
                    break;

                case MessageBoxResult.No:

                    break;
            }

        }
    }
    }

        
    
