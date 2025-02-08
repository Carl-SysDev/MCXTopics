using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXTopics.Classes
{
    internal class Topics
    {
        public string Code { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string HowToUse { get; set; }
        public string WhenToUse { get; set; }
        public string Others { get; set; }

        public Topics(string code, string topic, string description, string howToUse, string whenToUse, string others)
        {
            Code = code;
            Topic = topic;
            Description = description;
            HowToUse = howToUse;
            WhenToUse = whenToUse;
            Others = others;
        }
    }
}