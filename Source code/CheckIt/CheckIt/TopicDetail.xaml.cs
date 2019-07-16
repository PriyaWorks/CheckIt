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
    /// Interaction logic for TopicDetail.xaml
    /// </summary>
    public partial class TopicDetail : Window
    {
        public string topicid;
        
        public TopicDetail(string id)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            topicid = id;
            var topicdata = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            var topicdetails = from s in topicdata where s.topicId.Equals(topicid) select s;
            stk_TopicDetails.DataContext = topicdetails;
        }

        public TopicDetail()
        {
        }

        private void Btn_UpdateTopic_Click(object sender, RoutedEventArgs e)
        {
            var pro = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
            var topic = new ObservableCollection<Topic>();
            var tp = pro.First(f => f.topicId == Topicid.Text);
            tp.topicName = TopicName.Text;
            DbUtility.WriteXml<ObservableCollection<Topic>>(pro, "Topics.xml");
            /*if (string.IsNullOrEmpty(TopicName.Text))
            {
                MessageBox.Show("Please update the topic name");
            }*/
            /*else
            {*/
                MessageBox.Show("Topic Successfully Updated");
                var settings = new Settings();
                settings.Show();
                
            //}
        }

        private void Btn_DeleteTopic_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("Are you sure you want to delete the Topic", "Delete Topic", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    XmlDocument docu = new XmlDocument();
                    docu.Load("Topics.xml");
                    foreach (XmlNode x in docu.SelectNodes("ArrayOfTopic/Topic"))
                        if (x.SelectSingleNode("topicId").InnerText == Topicid.Text)
                        {
                            x.ParentNode.RemoveChild(x);
                            docu.Save("Topics.xml");
                        }
                    var settings = new Settings();
                    settings.Show();
                   
                    break;

                case MessageBoxResult.No:
                    var setting = new Settings();
                    setting.Show();
                    
                    break;

            }
        }
    }
}
