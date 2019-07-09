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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace CheckIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // to fetch the Topic name and display in the topic list baox
            List<string> topic = new List<string>();
            XmlDocument doc = new XmlDocument();
            doc.Load("Topic.xml");
            foreach (XmlNode x in doc.SelectNodes("ArrayOfTopic/Topic"))
            {
                topic.Add(x.SelectSingleNode("TopicName").InnerText);
            }
            Cbx_TopicName.ItemsSource = topic;
        }

        private void Btn_Result_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cbx_TopicList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Cbx_TopicName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btn_StartCheckIt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Breadcrum_Click(object sender, RoutedEventArgs e)
        {
            var breadcrum = new Breadcrum();
            breadcrum.Show();
        }
    }
}
