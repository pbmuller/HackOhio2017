using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingoLearner
{
    public class Question
    {
        // Field
        string questionText;
        List<string> answerSet;
        KeyValuePair<string, bool> answerPair;
        string dictionary;

        public string getQuestionText()
        {
            return this.questionText;
        }

        public List<string> getAnswerSet()
        {
            return this.answerSet;
        }

        public KeyValuePair<string, bool> getAnswerPair()
        {
            return this.answerPair;
        }

        public string getDictionary()
        {
            return this.dictionary;
        }

        public static Question makeQ(string s1, string s2, string s3, string answer, string question)
        {
            List<string> l = new List<string>();
            l.Add(s1);
            l.Add(s2);
            l.Add(s3);
            l.Add(answer);
            KeyValuePair<string, bool> kv = new KeyValuePair<string, bool>(answer, true);
            Question q = new Question(question, l, kv);

            return (q);
        }

        // Constructor that takes no arguments.
        public Question()
        {
            questionText = "";
            answerSet = new List<string>();
            answerPair = new KeyValuePair<string, bool>();
            dictionary = "None";
        }

        // Constructor that takes one argument.
        public Question(string quesitonText, List<string> answerSet, KeyValuePair<string, bool> answerPair, string dictionary)
        {
            this.questionText = quesitonText;
            this.answerSet = answerSet;
            this.answerPair = answerPair;
            this.dictionary = dictionary;
        }

        // Method
        public KeyValuePair<string, bool> SetRightWrong(KeyValuePair<String, bool> d, bool answer)
        {
            return new KeyValuePair<string, bool>(d.Key, answer);
        }
    }
}
