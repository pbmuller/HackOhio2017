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
        List<KeyValuePair<string, bool>> answerSet;

        public string getQuestionText()
        {
            return this.questionText;
        }

        public List<KeyValuePair<string, bool>> getAnswerSet()
        {
            return this.answerSet;
        }

        public static Question makeQ(string s1, string s2, string s3, string answer, string question)
        {
            List<KeyValuePair<string, bool>> list = new List<KeyValuePair<string, bool>>();
            list.Add(new KeyValuePair<string, bool>(s1, false));
            list.Add(new KeyValuePair<string, bool>(s2, false));
            list.Add(new KeyValuePair<string, bool>(s3, false));
            list.Add(new KeyValuePair<string, bool>(answer, true));
            Question q = new Question(question, list);

            return (q);
        }

        // Constructor that takes no arguments.
        public Question()
        {
            this.questionText = "";
            this.answerSet = new List<KeyValuePair<string, bool>>();
        }

        // Constructor that takes one argument.
        public Question(string questionText, List<KeyValuePair<string, bool>> answerSet)
        {
            this.questionText = questionText;
            this.answerSet = answerSet;
        }

    }
}
