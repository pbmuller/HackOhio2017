using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Google.Cloud.Translation.V2;


namespace LingoLearner
{
    public class Translator
    {
        private Char[] separators = { ' ', ',', '.', '!', '?', ';' };
                

        public Question translateQuestion(int langScore, string langCode, Question q)
        {
            string questionTextTranslation = translate(langScore, q.getQuestionText(), langCode);

            
            List<string> translatedAnswers = new List<string>();
           
            foreach (string answer in q.getAnswerSet().Keys.ToList())
            {
                translatedAnswers.Add(translate(langScore, answer, langCode));
            }

            return Question.makeQuestion(translatedAnswers[0], translatedAnswers[1],
                translatedAnswers[2], translatedAnswers[3], questionTextTranslation);
        }
        public string translate(int langScore, string sentence, string langCode)
        {
            //Need to split this string into words
            List<string> words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            int swapPercent = 0;
            //If the language score is between 0 and 25, swap out 1/4 of the words
            if (langScore >= 0 && langScore < 25)
            {
                swapPercent = 1;
            }
            //else if the language score is between 25 and 50, swap out 2/4 of the words
            else if (langScore >= 25 && langScore < 50)
            {
                swapPercent = 2;
            }
            //else if the language score is between 50 and 75, swap out 3/4 of the words
            else if (langScore >= 50 && langScore < 75)
            {
                swapPercent = 3;
            }
            //else if the language score is between 75 and 100, swap out all of the words
            else if (langScore >= 75 && langScore <= 100)
            {
                swapPercent = 4;
            }
            //else raise an exception
            else
            {
                throw new ArgumentOutOfRangeException("value must be between 0 and 100", "lang_score");
            }

            Random rnd = new Random();

            int wordsToSwap = (int)((swapPercent / 4.0) * words.Count());
            //always swap at least 1 word
            if (wordsToSwap == 0)
            {
                wordsToSwap++;
            }

            List<int> swapIndexes = new List<int>();
            while (swapIndexes.Count < wordsToSwap)
            {
                int swapIndex = rnd.Next(words.Count());
                if (!swapIndexes.Contains(swapIndex))
                {
                    swapIndexes.Add(swapIndex);
                }
            }

            //Perform the swap
            foreach (int index in swapIndexes)
            {
                string englishWord = words[index];
                try
                {
                    string transWord = GetTranslatedText(englishWord, langCode);
                    words[index] = transWord;
                }
                catch
                {
                   Console.WriteLine("Could find the English Word " + englishWord);
                }
            }

            string translation = String.Join(" ", words);

            //Return the sentence
            return translation;
        }


        public string GetTranslatedText(string text, string langCode)
        {            
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            TranslationClient client = TranslationClient.Create();              
            var response = client.TranslateText(text, langCode, "en");
            return response.TranslatedText;
   
        }
    }
}