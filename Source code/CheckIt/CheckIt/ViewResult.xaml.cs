using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
    /// Interaction logic for ViewResult.xaml
    /// </summary>
    public partial class ViewResult : Window
    {
        int time;
       // int comboselecteditemId = 0;
        string questionCode;
        string topicid;
        public ViewResult(string questioncode)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            questionCode = questioncode;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //((PieSeries)mcChart.Series[0]).ItemsSource = new KeyValuePair<string, int>[]{
            //new KeyValuePair<string, int>("Passed", 50),
            //new KeyValuePair<string, int>("Failed", 50) };

           
            int Failed = 0;
            int Passed = 0;
            int Count = 0;

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
            
            XmlDocument xydocum = new XmlDocument();
            xydocum.Load("Questions.xml");
            foreach (XmlNode xn in xdocum.SelectNodes("ArrayOfQuestion/Question"))
                if (xn.SelectSingleNode("questionCode").InnerText == questionCode)
                {
                    string answerA = xn.SelectSingleNode("optionAStatus").InnerText;
                    string answerB = xn.SelectSingleNode("optionBStatus").InnerText;
                    string answerC = xn.SelectSingleNode("optionCStatus").InnerText;
                    string answerD = xn.SelectSingleNode("optionDStatus").InnerText;

                    if (answerA == "True")
                    {
                        stk_CorrectAnswer.DataContext = xn.SelectSingleNode("optionA").InnerText;
                    }
                    else if (answerB == "True")
                    {
                        stk_CorrectAnswer.DataContext = xn.SelectSingleNode("optionB").InnerText;
                    }
                    else if (answerC == "True")
                    {
                        stk_CorrectAnswer.DataContext = xn.SelectSingleNode("optionC").InnerText;
                    }
                    else if (answerD == "True")
                    {
                        stk_CorrectAnswer.DataContext = xn.SelectSingleNode("optionD").InnerText;
                    }
                }
      
            var topicdata = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            var topic = from tn in topicdata where tn.topicId .Equals(topicid) select tn;
            {
                stk_topic.DataContext = topic;
            }

            //var question = new Question();
            //question = (Question)QuestionList.SelectedItem;
            //string questioncode = question.questionCode;

            XmlDocument docum = new XmlDocument();
            docum.Load("Results.xml");
            foreach (XmlNode x in docum.SelectNodes("ArrayOfResult/Result"))
                if (x.SelectSingleNode("questionCode").InnerText == questionCode)
                {
                    //StudentResult.Visibility = System.Windows.Visibility.Visible;
                    //stk_N0Result.Visibility = System.Windows.Visibility.Collapsed;
                    Count = Count + 1;
                    if (x.SelectSingleNode("questionStatus").InnerText == "Failed")
                    {
                        Failed = Failed + 1;
                    }
                    else
                    {
                        Passed = Passed + 1;
                    }



                    //   if (Passed ==0 && Failed == 0) { }
                    //((PieSeries)StudentResult.Series[0]).ItemsSource = new KeyValuePair<string, int>[]{
                    // new KeyValuePair<string, int>("Passed", Passed),
                    // new KeyValuePair<string, int>("Failed", Failed) };
                    //    }
                    //    //else
                    //    {
                    //        //StudentResult.Visibility = System.Windows.Visibility.Collapsed;
                    //        //stk_N0Result.Visibility = System.Windows.Visibility.Visible;
                    //    }

                    ////To fetch the Topiclist and display in the listbox
                    ///* List<string> data = new List<string>();
                    // XmlDocument docum = new XmlDocument();
                    // docum.Load("Topics.xml");
                    // foreach (XmlNode x in docum.SelectNodes("ArrayOfTopic/Topic"))
                    // {
                    //     data.Add(x.SelectSingleNode("topicName").InnerText);
                    // }
                    // cbx_TopicList.ItemsSource = data;
                    // cbx_TopicList.SelectedIndex = 0;*/'

                }
            TotalStudent.Text = Count.ToString();
            TotalFailed.Text = Failed.ToString();
            TotalPassed.Text = Passed.ToString();
        }

        

        /*private void Cbx_TopicList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //To fetch the Questions on selection of the Topic and display in the listbox
            comboselecteditemId = cbx_TopicList.SelectedIndex + 1;
            string val = comboselecteditemId.ToString();
            var data = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var Questions = from s in data where s.topicId.Equals(val) select s;
            {
                QuestionList.ItemsSource = Questions;
            }
        }*/

        private void QuestionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Btn_BackMainWindow_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void Btn_StartQuestion_Click(object sender, RoutedEventArgs e)
        {
          string  times = timer.Text;
            int time = Convert.ToInt32(times);

            string val = "";
               XmlDocument doc = new XmlDocument();
                doc.Load("Questions.xml");
                foreach (XmlNode x in doc.SelectNodes("ArrayOfQuestion/Question"))

                    if (x.SelectSingleNode("questionCode").InnerText == questionCode)
                    {
                        val = x.SelectSingleNode("questionCode").InnerText;
                    }

            DisplayCode.Text = questionCode;
            var studentPage = new StudentCheckIt(time);
            studentPage.Show();
           

            //MessageBoxResult result = System.Windows.MessageBox.Show("The Question code is " + val + ". Do you want to start the question? ", "Start Question", MessageBoxButton.YesNo);

            //switch (result)
            //{
            //    case MessageBoxResult.Yes:
            //   
            //        var studentPage = new StudentCheckIt();
            //        studentPage.Show();
            //        break;

            //    case MessageBoxResult.No:
            //        var mainwindow = new MainWindow();
            //        mainwindow.Show();
            //        break;

        }
    }
        }

