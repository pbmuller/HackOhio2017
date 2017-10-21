using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoLearner
{
    public class GermanDictionary
    {
        Dictionary<string, string> words;

        public GermanDictionary()
        {
            
        }

        private void loadDictionaryd()
        {
            this.words = new Dictionary<string, string>();
            this.words.Add("hallo", "hello");
            this.words.Add("wie", "how");
            this.words.Add("bist", "are");
            this.words.Add("heute", "today");
            this.words.Add("du", "you");
            this.words.Add("Möchtest_du", "would_you_like");
            this.words.Add("lernen", "learn");
            this.words.Add("Deutsch", "german");
            this.words.Add("zu", "to");
            this.words.Add("spe")

        }

        private List<KeyValuePair<string, string>> german_english_wordlist()
        {
            List<KeyValuePair<string, string>> german_english_wordlist = new List<KeyValuePair<string, string>>();
            german_english_wordlist.Add(new KeyValuePair<string, string>("hallo", "hello"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("wie", "how"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("bist", "are"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("du", "you"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("heute", "today"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("Möchtest_du", "would_you_like"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("lernen", "learn"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("Deutsch", "german"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("zu", "to"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("sprechen", "speak"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("was", "what"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("was_machst_du", "What_do_you_do"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("wenn", "when"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("aufwachst", "wake_up"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("bist_du", "have_you"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("jemals", "ever"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("gereist", "travelled"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("nach_Deutschland", "to_Germany"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("Danke", "thank you"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("für", "for"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("mit", "with"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("mir", "me"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("sprechen", "talking"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("ich", "I"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("hoffe", "hope"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("etwas", "something"));
            german_english_wordlist.Add(new KeyValuePair<string, string>("gelernt", "learned"));
            return german_english_wordlist;
        }
    }
}
