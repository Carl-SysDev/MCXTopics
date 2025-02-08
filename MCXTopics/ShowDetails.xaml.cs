using System;
using System.Collections.Generic;
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
using MCXTopics.Classes;

namespace MCXTopics
{
    /// <summary>
    /// Interaction logic for ShowDetails.xaml
    /// </summary>
    public partial class ShowDetails : Window
    {
        public TextBox TopicTextBlock
        { get { return Topic; } }

        public TextBox DescriptionTextBlock
        { get { return Description; } }

        public ShowDetails()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //OTHER INFORMATIONS
        private void Others_Click(object sender, RoutedEventArgs e)
        {
            // Get the selectedTopic object from the Tag property
            Topics selectedTopic = (Topics)this.Tag;

            string code = selectedTopic.Code;
            string topic = selectedTopic.Topic;
            string description = selectedTopic.Description;
            string howtouse = selectedTopic.HowToUse;
            string whentouse = selectedTopic.WhenToUse;
            string other = selectedTopic.Others;

            // Create an instance of OthersDetails and pass the data
            OthersDetails othersDetails = new OthersDetails(code, topic, description, howtouse, whentouse, other);

            // Show the OthersDetails window using ShowDialog()
            othersDetails.ShowDialog();
        }
    }
}