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

namespace MCXTopics
{
    public partial class OthersDetails : Window
    {
        public OthersDetails(string code, string topic, string description, string howtouse, string whentouse, string other)
        {
            InitializeComponent();
            CodeTextBlock.Text = code;
            TopicTextBlock.Text = topic;
            DescriptionTextBlock.Text = description;
            HowToUseTextBlock.Text = howtouse;
            WhenToUseTextBlock.Text = whentouse;
            OthersTextBlock.Text = other;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}