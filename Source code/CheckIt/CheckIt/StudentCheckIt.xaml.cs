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
using System.Windows.Threading;
using System.Xml;

namespace CheckIt
{
    /// <summary>
    /// Interaction logic for StudentCheckIt.xaml
    /// </summary>
    public partial class StudentCheckIt : Window
    {
        public int time;
        public string vale;
        public String questioncode;
        public int times;
        public string topicid;

        public StudentCheckIt(int time)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            InputBox.Visibility = System.Windows.Visibility.Visible;
            times = time * 60;
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            if (times != 0)
            {
                times--;
                timeValue.Content = times.ToString();
            }
            else
            {
                DispatcherTimer dt = new DispatcherTimer();
                dt.Stop();
            }
           
               
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            // Count down timer logic
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 1);
            dt.Tick += Dt_Tick;
            dt.Start();
           
            

            //Enter quiz code screen logic
            InputBox.Visibility = System.Windows.Visibility.Collapsed;
            questioncode = InputTextBox.Text;
            InputTextBox.Text = String.Empty;

            // question display logic
            var questiondata = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var Questiondetails = from s in questiondata where s.questionCode.Equals(questioncode) select s;
            stk_QuestionDetails.DataContext = Questiondetails;

            XmlDocument xdocum = new XmlDocument();
            xdocum.Load("Questions.xml");
            foreach (XmlNode x in xdocum.SelectNodes("ArrayOfQuestion/Question"))
                if (x.SelectSingleNode("questionCode").InnerText == questioncode)
                {
                    string topicids = x.SelectSingleNode("topicId").InnerText;
                    int topicidas = Convert.ToInt32(topicids) + 1;
                    topicid = Convert.ToString(topicidas);

                }

            var topicdata = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            var topic = from tn in topicdata where tn.topicId.Equals(topicid) select tn;
            {
                stk_topic.DataContext = topic;
            }

        }

        private void Btn_FinishQuiz_Click(object sender, RoutedEventArgs e)
        {

            var studentdata = DbUtility.ReadXml<ObservableCollection<Result>>("Results.xml");
            XmlDocument docum = new XmlDocument();
            docum.Load("Questions.xml");

            foreach (XmlNode x in docum.SelectNodes("ArrayOfQuestion/Question"))
                if (x.SelectSingleNode("questionCode").InnerText == questioncode)
                {
                    string optAStatus = x.SelectSingleNode("optionAStatus").InnerText;
                    string optBStatus = x.SelectSingleNode("optionBStatus").InnerText;
                    string optCStatus = x.SelectSingleNode("optionCStatus").InnerText;
                    string optDStatus = x.SelectSingleNode("optionDStatus").InnerText;
                    string OptionAstatus = Convert.ToString(Chbx_A.IsChecked);
                    string OptionBstatus = Convert.ToString(Chbx_B.IsChecked);
                    string OptionCstatus = Convert.ToString(Chbx_C.IsChecked);
                    string OptionDstatus = Convert.ToString(Chbx_D.IsChecked);

                    if (OptionAstatus == optAStatus && OptionBstatus == optBStatus && OptionCstatus == optCStatus && OptionDstatus == optDStatus)
                    {

                        Result rs = new Result();
                        rs.questionCode = questioncode;
                        rs.questionStatus = "Passed";
                        try
                        {
                            studentdata.Add(rs);
                            DbUtility.WriteXml<ObservableCollection<Result>>(studentdata, "Results.xml");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        Result rs = new Result();
                        rs.questionCode = questioncode;
                        rs.questionStatus = "Failed";
                        try
                        {
                            studentdata.Add(rs);
                            DbUtility.WriteXml<ObservableCollection<Result>>(studentdata, "Results.xml");
                        }


                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }

                    //MessageBox.Show("Your answer has been submitted successfully");
                    MessageBoxResult result = System.Windows.MessageBox.Show("Your answer has been submitted successfully. Do you want to close the application", "application close", MessageBoxButton.OKCancel);

                    switch (result)
                    {
                        case MessageBoxResult.OK:
                            var studentPage = new StudentCheckIt(time);
                            this.Close();
                            break;

                        case MessageBoxResult.Cancel:
                            var studentCheckit = new StudentCheckIt(time);
                            studentCheckit.Show();
                            break;

                    }
                }
        }

                   
                }
        }
    


       
    