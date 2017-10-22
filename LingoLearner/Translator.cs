using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LingoLearner
{
    public class Translator
    {
        public string translate(int lang_score, Question q)
        {
            GermanDictionary germanDict = new GermanDictionary();
            string questionText = q.getQuestionText();
            char[] sep = { ' ', ',', ':', '.' };
            string[] questionWords = questionText.Split(sep);
            var rnd = new Random();
            Console.WriteLine(questionText);
            Console.ReadLine();
            string translatedText = "";
            //list is recompiled string with translations in it
            return translatedText;
        }
        public Translator() { }
    }
}