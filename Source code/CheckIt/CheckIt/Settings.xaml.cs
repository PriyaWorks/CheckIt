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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        int time = 0;
        public Settings()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        /*private void Btn_DeleteTopic_Click(object sender, RoutedEventArgs e)
        {
           *//* XmlDocument doc = new XmlDocument();
            doc.Load("Topic.xml");

            foreach (XmlNode x in doc.SelectNodes("ArrayOfTopic/Topic"))
                if (x.SelectSingleNode("TopicId").InnerText == gettopicid.text)
                {

                }*//*
        }*/

        private void Btn_AddTopic_Click(object sender, RoutedEventArgs e)
        {
            var topic = new AddTopic();
            topic.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var topicnames = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            TopicNames.ItemsSource = topicnames;

        }

        private void Btn_cancelWin_Click(object sender, RoutedEventArgs e)
        {
            var checkit = new MainWindow();
            checkit.Show();
            this.Close();
        }

        private void MenuItem_ManageQuestions_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

            var managequestions = new ManageQuestion();
            managequestions.Show();
            this.Close();
        }

        private void MenuItem_Setting_Click(object sender, RoutedEventArgs e)
        {
           /* var mainwindow = new MainWindow();
            mainwindow.Close();*/

            var settings = new Settings();
            settings.Show();
           
        }

        private void MenuItem_ViewResult_Click(object sender, RoutedEventArgs e)
        {
            var mainwindow = new MainWindow();
            mainwindow.Close();

           /* var viewresult = new ViewResult();
            viewresult.Show();
            this.Close();*/
        }

        private void TopicNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var topic = new Topic();
            topic = (Topic)TopicNames.SelectedItem;
            string id = topic.topicId;
            //MessageBox.Show(id);

            var topicDetail = new TopicDetail(id);
            topicDetail.Show();
            this.Close();
        }
    }
}
