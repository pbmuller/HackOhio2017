using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoLearner
{
    public class Translator
    {
        public List<String> translate(int lang_score, Question q, string dict_name)
        {
            List<String> ans = new List<String>();
            //split question text and
            string qstring = q.getQuestionText();
            char[] sep = { ' ', ',', ':', '.' };
            string[] qwords = qstring.Split(sep);

            var rnd = new Random();
            //qwords[rnd];
            //depending on answer, split answer to change if they're over some translate score
            List<KeyValuePair<string, bool>> a = q.getAnswerSet();

            //list is recompiled string with translations in it
            return ans;
        }
    }
}