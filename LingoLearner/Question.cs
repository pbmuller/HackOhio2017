using System.Collections.Generic;

namespace LingoLearner
{
    public class Question
    {
        private string questionText;
        private Dictionary<string, bool> answerSet;

        public Question()
        {
            this.questionText = "Default Question Text";
            this.answerSet = new Dictionary<string, bool>();

            this.answerSet.Add("wrong", false);
            this.answerSet.Add("wrong", false);
            this.answerSet.Add("wrong", false);
            this.answerSet.Add("right", true);
        }

        public Question(string questionText, Dictionary<string, bool> answerSet)
        {
            this.questionText = questionText;
            this.answerSet = answerSet;
        }

        public string getQuestionText()
        {
            return this.questionText;
        }

        public Dictionary<string, bool> getAnswerSet()
        {
            return this.answerSet;
        }

        public static Question makeQuestion(string wrongAnswer1, string wrongAnswer2, string wrongAnswer3, string rightAnswer, string questionText)
        {
            Dictionary<string, bool> answerSet = new Dictionary<string, bool>();
            answerSet.Add(wrongAnswer1, false);
            answerSet.Add(wrongAnswer2, false);
            answerSet.Add(wrongAnswer3, false);
            answerSet.Add(rightAnswer, true);
            return new Question(questionText, answerSet);
        }
    }
}