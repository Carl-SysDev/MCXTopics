using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCXTopics.Classes
{
    internal class Search
    {
        public string SearchText { get; set; }

        public Search(string searchText)
        {
            SearchText = searchText;
        }

        public List<Topics> SearchTopics(List<Topics> topics)
        {
            List<Topics> searchResults = new List<Topics>();

            searchResults = topics.Where(c => c.Topic.ToLower().Contains(SearchText.ToLower())).ToList();
            return searchResults;
        }
    }
}