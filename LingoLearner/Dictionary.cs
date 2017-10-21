using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoLearner
{
    public class Dictionary
    {
        Dictionary<string, Dictionary<string, string>> dictionaries;

        public Dictionary()
        {

        }

        public List<string> getDictionaries()
        {
            return this.dictionaries.Keys.ToList();
        }

        private void loadDictionaries()
        {
            this.dictionaries = new Dictionary<string, Dictionary<string, string>>();
            this.dictionaries.Add("german-english", null);
        }
    }
}
