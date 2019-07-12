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
    /// Interaction logic for ManageQuestion.xaml
    /// </summary>
    public partial class ManageQuestion : Window
    {
        int comboSelectedItemId = 0;

        public ManageQuestion()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // to fetch the Topic name and display in the topic list baox
            List<string> topic = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Topics.xml");
            foreach (XmlNode x in doc.SelectNodes("ArrayOfTopic/Topic"))
            {
                topic.Add(x.SelectSingleNode("topicName").InnerText);
            }
            Cbx_TopicName.ItemsSource = topic;
            Cbx_TopicName.SelectedIndex = 0;
        }

        private void Cbx_TopicName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //To fetch the Questions on selection of the Topic and display in the listbox
            comboSelectedItemId = Cbx_TopicName.SelectedIndex + 1;
            string val = comboSelectedItemId.ToString();
            var data = DbUtility.ReadXml<ObservableCollection<Question>>("Questions.xml");
            var Questions = from s in data where s.topicId.Equals(val) select s;
            {
                Lbx_Questionlist.ItemsSource = Questions;
            }
        }

        private void Btn_AddQuestion_Click(object sender, RoutedEventArgs e)
        {
            comboSelectedItemId = Cbx_TopicName.SelectedIndex + 1;
            string val = comboSelectedItemId.ToString();
            var addQuestion = new AddQuestion(val);
            addQuestion.Show();
            this.Close();
        }



        private void MenuItem_ManageQuestions_Click(object sender, RoutedEventArgs e)
        {
            /*var mainwindow = new MainWindow();
            mainwindow.Close();

            var managequestions = new ManageQuestion();
            managequestions.Show();
            this.Close();*/
        }

        private void MenuItem_Settings_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

            var settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void MenuItem_ViewResult_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

           /* var viewresult = new ViewResult();
            viewresult.Show();
            this.Close();*/
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void Lbx_Questionlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var ques = new Question();
            ques = (Question)Lbx_Questionlist.SelectedItem;
            string id = ques.questionId;
            //MessageBox.Show(id);

            var questionDetail = new QuestionDetail(id);
            questionDetail.Show();
            this.Close();
        }
    }
}
