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
    /// Interaction logic for AddTopic.xaml
    /// </summary>
    public partial class AddTopic : Window
    {
        public AddTopic()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

       

        private void Btn_AddTopic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = DbUtility.ReadXml<ObservableCollection<Topic>>("Topics.xml");
                var topic = new ObservableCollection<Topic>();
                Topic tn = new Topic();
                XmlDocument doc = new XmlDocument();
                doc.Load("Topics.xml");
                int count = 1;
                foreach (XmlNode xn in doc.SelectNodes("ArrayOfTopic/Topic"))
                {
                    count = count + 1;
                }
                string topicid = Convert.ToString(count);
                tn.topicId = topicid;
                tn.topicName = TopicName.Text;

                if (string.IsNullOrEmpty(TopicName.Text))
                {
                    MessageBox.Show("Please enter the topic name");
                }
                else
                {
                    data.Add(tn);
                    DbUtility.WriteXml<ObservableCollection<Topic>>(data, "Topics.xml");
                    MessageBox.Show("Topic name successfully added");

                    var gobacktomain = new Settings();
                    gobacktomain.Show();
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
