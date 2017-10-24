using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LingoLearner
{
   
    public partial class MainWindow : Window
    {
        public static int lscore;
        public Dictionary<string, string> langDictionary = MakeLanguageDictionary();
        public static string langCode;
        public List<Question> questions;
        public string ans;
        public MainWindow()
        {
            try
            {               
                StreamReader sr = new StreamReader("C:\\hack\\lscore.txt");
                lscore = Convert.ToInt32(sr.ReadLine());
                langCode = Convert.ToString(sr.ReadLine());
                sr.Close();
            }
            catch(IOException)
            {
                DirectoryInfo di = Directory.CreateDirectory("C:\\hack");
                using (var tw = new StreamWriter("C:\\hack\\lscore.txt", true))
                {
                    tw.WriteLine("0");
                    tw.WriteLine("en");
                    tw.Close();
                }
            }
            questions = makeQuestions();
            InitializeComponent();

            
            var rnd = new Random();
            questions = questions.OrderBy(x => rnd.Next()).ToList();


            Translator t = new Translator();
            questions.Add(t.translateQuestion(lscore, langCode, questions.ElementAt(0)));

            Question q = questions.Last();

            questions.Remove(q);
            questions.Remove(questions.ElementAt(0));

            Dictionary<string, bool> l = q.getAnswerSet();
            foreach (KeyValuePair<string,bool>x in l){
                if (x.Value)
                {
                    
                    ans = x.Key;
                    ans = replaceUnderscore(ans);
                    Console.WriteLine(x.Key);
                    Console.ReadLine();
                }
            }
           
            LanguageSel.ItemsSource = AddLanguages();
            setUI(q);
           
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            
            if (ans == A1t.Text.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                if (lscore > 100)
                {
                    lscore = 100;
                }
                updateUI();
            }
            else
            {
               A1.IsEnabled = false;
                lscore -= 3;
                if (lscore < 0)
                {
                    lscore = 0;
                }
            }
            
            
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A2t.Text.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                if (lscore > 100)
                {
                    lscore = 100;
                }
                updateUI();
            }
            else
            {
                A2.IsEnabled = false;
                lscore -= 3;
                if (lscore < 0)
                {
                    lscore = 0;
                }
            }
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            
            if (ans == A3t.Text.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                if (lscore > 100)
                {
                    lscore = 100;
                }
                updateUI();
                                
            }
            else
            {
                A3.IsEnabled = false;
                lscore -= 3;
                if (lscore < 0)
                {
                    lscore = 0;
                }
            }
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A4t.Text.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                if (lscore > 100)
                {
                    lscore = 100;
                }
                updateUI();
            }
            else
            {
                A4.IsEnabled = false;
                lscore -= 3;
                if (lscore < 0)
                {
                    lscore = 0;
                }
            }
        }

        private void LangSelectButton_Click(object sender, RoutedEventArgs e)
        {
            string s = LanguageSel.Text.ToString();
            
                langCode = langDictionary[s.Replace(" ","")];
            
            Console.WriteLine(langCode);
            Console.ReadLine();
        }

        public static Dictionary<string, string> MakeLanguageDictionary()
        {
            Dictionary<string, string> langDict = new Dictionary<string, string>();
            langDict.Add("Afrikaans", "af");
            langDict.Add("Albanian", "sq");
            langDict.Add("Amharic", "am");
            langDict.Add("Arabic", "ar");
            langDict.Add("Armenian", "hy");
            langDict.Add("Azeerbaijani", "az");
            langDict.Add("Basque", "eu");
            langDict.Add("Belarusian", "be");
            langDict.Add("Bengali", "bn");
            langDict.Add("Bosnian", "bs");
            langDict.Add("Bulgarian", "bg");
            langDict.Add("Catalan", "ca");
            langDict.Add("Cebuano", "ceb");
            langDict.Add("Chinese(Simplified)", "zh-CN");
            langDict.Add("Chinese(Traditional)", "zh-TW");
            langDict.Add("Corsican", "co");
            langDict.Add("Croatian", "hr");
            langDict.Add("Czech", "cs");
            langDict.Add("Danish", "da");
            langDict.Add("Dutch", "nl");
            langDict.Add("English", "en");
            langDict.Add("Esperanto", "eo");
            langDict.Add("Estonian", "et");
            langDict.Add("Finnish", "fi");
            langDict.Add("French", "fr");
            langDict.Add("Frisian", "fy");
            langDict.Add("Galician", "gl");
            langDict.Add("Georgian", "ka");
            langDict.Add("German", "de");
            langDict.Add("Greek", "el");
            langDict.Add("Gujarati", "gu");
            langDict.Add("HaitianCreole", "ht");
            langDict.Add("Hausa", "ha");
            langDict.Add("Hawaiian", "haw");
            langDict.Add("Hebrew", "iw");
            langDict.Add("Hindi", "hi");
            langDict.Add("Hmong", "hmn");
            langDict.Add("Hungarian", "hu");
            langDict.Add("Icelandic", "is");
            langDict.Add("Igbo", "ig");
            langDict.Add("Indonesian", "id");
            langDict.Add("Irish", "ga");
            langDict.Add("Italian", "it");
            langDict.Add("Japanese", "ja");
            langDict.Add("Javanese", "jw");
            langDict.Add("Kannada", "kn");
            langDict.Add("Kazakh", "kk");
            langDict.Add("Khmer", "km");
            langDict.Add("Korean", "ko");
            langDict.Add("Kurdish", "ku");
            langDict.Add("Kyrgyz", "ky");
            langDict.Add("Lao", "lo");
            langDict.Add("Latin", "la");
            langDict.Add("Latvian", "lv");
            langDict.Add("Lithuanian", "lt");
            langDict.Add("Luxembourgish", "lb");
            langDict.Add("Macedonian", "mk");
            langDict.Add("Malagasy", "mg");
            langDict.Add("Malay", "ms");
            langDict.Add("Malayalam", "ml");
            langDict.Add("Maltese", "mt");
            langDict.Add("Maori", "mi");
            langDict.Add("Marathi", "mr");
            langDict.Add("Mongolian", "mn");
            langDict.Add("Myanmar(Burmese)", "my");
            langDict.Add("Nepali", "ne");
            langDict.Add("Norwegian", "no");
            langDict.Add("Nyanja(Chichewa)", "ny");
            langDict.Add("Pashto", "ps");
            langDict.Add("Persian", "fa");
            langDict.Add("Polish", "pl");
            langDict.Add("Portuguese", "pt");
            langDict.Add("Punjabi", "pa");
            langDict.Add("Romanian", "ro");
            langDict.Add("Russian", "ru");
            langDict.Add("Samoan", "sm");
            langDict.Add("ScotsGaelic", "gd");
            langDict.Add("Serbian", "sr");
            langDict.Add("Sesotho", "st");
            langDict.Add("Shona", "sn");
            langDict.Add("Sindhi", "sd");
            langDict.Add("Sinhala(Sinhalese)", "si");
            langDict.Add("Slovak", "sk");
            langDict.Add("Slovenian", "sl");
            langDict.Add("Somali", "so");
            langDict.Add("Spanish", "es");
            langDict.Add("Sundanese", "su");
            langDict.Add("Swahili", "sw");
            langDict.Add("Swedish", "sv");
            langDict.Add("Tagalog(Filipino)", "tl");
            langDict.Add("Tajik", "tg");
            langDict.Add("Tamil", "ta");
            langDict.Add("Telugu", "te");
            langDict.Add("Thai", "th");
            langDict.Add("Turkish", "tr");
            langDict.Add("Ukrainian", "uk");
            langDict.Add("Urdu", "ur");
            langDict.Add("Uzbek", "uz");
            langDict.Add("Vietnamese", "vi");
            langDict.Add("Welsh", "cy");
            langDict.Add("Xhosa", "xh");
            langDict.Add("Yiddish", "yi");
            langDict.Add("Yoruba", "yo");
            langDict.Add("Zulu", "zu");
            return langDict;
        }

        public List<string> AddLanguages()
        {
            List<string> langs = new List<string>();
            langs.Add("Afrikaans");
            langs.Add("Albanian");
            langs.Add("Amharic");
            langs.Add("Arabic");
            langs.Add("Armenian");
            langs.Add("Azeerbaijani");
            langs.Add("Basque");
            langs.Add("Belarusian");
            langs.Add("Bengali");
            langs.Add("Bosnian");
            langs.Add("Bulgarian");
            langs.Add("Catalan");
            langs.Add("Cebuano");
            langs.Add("Chinese (Simplified)");
            langs.Add("Chinese (Traditional)");
            langs.Add("Corsican");
            langs.Add("Croatian");
            langs.Add("Czech");
            langs.Add("Danish");
            langs.Add("Dutch");
            langs.Add("English");
            langs.Add("Esperanto");
            langs.Add("Estonian");
            langs.Add("Finnish");
            langs.Add("French");
            langs.Add("Frisian");
            langs.Add("Galician");
            langs.Add("Georgian");
            langs.Add("German");
            langs.Add("Greek");
            langs.Add("Gujarati");
            langs.Add("Haitian Creole");
            langs.Add("Hausa");
            langs.Add("Hawaiian");
            langs.Add("Hebrew");
            langs.Add("Hindi");
            langs.Add("Hmong");
            langs.Add("Hungarian");
            langs.Add("Icelandic");
            langs.Add("Igbo");
            langs.Add("Indonesian");
            langs.Add("Irish");
            langs.Add("Italian");
            langs.Add("Japanese");
            langs.Add("Javanese");
            langs.Add("Kannada");
            langs.Add("Kazakh");
            langs.Add("Khmer");
            langs.Add("Korean");
            langs.Add("Kurdish");
            langs.Add("Kyrgyz");
            langs.Add("Lao");
            langs.Add("Latin");
            langs.Add("Latvian");
            langs.Add("Lithuanian");
            langs.Add("Luxembourgish");
            langs.Add("Macedonian");
            langs.Add("Malagasy");
            langs.Add("Malay");
            langs.Add("Malayalam");
            langs.Add("Maltese");
            langs.Add("Maori");
            langs.Add("Marathi");
            langs.Add("Mongolian");
            langs.Add("Myanmar (Burmese)");
            langs.Add("Nepali");
            langs.Add("Norwegian");
            langs.Add("Nyanja (Chichewa)");
            langs.Add("Pashto");
            langs.Add("Persian");
            langs.Add("Polish");
            langs.Add("Portuguese");
            langs.Add("Punjabi");
            langs.Add("Romanian");
            langs.Add("Russian");
            langs.Add("Samoan");
            langs.Add("Scots Gaelic");
            langs.Add("Serbian");
            langs.Add("Sesotho");
            langs.Add("Shona");
            langs.Add("Sindhi");
            langs.Add("Sinhala (Sinhalese)");
            langs.Add("Slovak");
            langs.Add("Slovenian");
            langs.Add("Somali");
            langs.Add("Spanish");
            langs.Add("Sundanese");
            langs.Add("Swahili");
            langs.Add("Swedish");
            langs.Add("Tagalog (Filipino)");
            langs.Add("Tajik");
            langs.Add("Tamil");
            langs.Add("Telugu");
            langs.Add("Thai");
            langs.Add("Turkish");
            langs.Add("Ukrainian");
            langs.Add("Urdu");
            langs.Add("Uzbek");
            langs.Add("Vietnamese");
            langs.Add("Welsh");
            langs.Add("Xhosa");
            langs.Add("Yiddish");
            langs.Add("Yoruba");
            langs.Add("Zulu");
             return langs;
        }

        public static List<Question> makeQuestions()
        {
            Translator t = new Translator();
            List<Question> qlist = new List<Question>();
            qlist.Add(Question.makeQuestion("I am a cherry_doughnut.", "The_trees_are on fire.",
                "The_weather in winter is cold.", "Hello, I am doing_well.",
                "Hello, how are you today?"));
            qlist.Add(Question.makeQuestion("Butterflies are beautiful.", "Yes, I would_like to_eat dinner.",
                "Hello world is an overly_used phrase.", "Yes, it would_be_nice to_learn German",
                "Would_you_like to_learn German?"));
            qlist.Add(Question.makeQuestion("Sleep in a tree.", "My_dog snuggled my_cat.", "No, we did not start the_fire.",
                "Check my_phone and brush my_teeth.", "What do_you_do when you wake_up?"));
            qlist.Add(Question.makeQuestion("The_earth is actually flat.", "I do_not_have any porridge.", "I like_to_visit Canada.",
                "No, but I would like_to_visit Germany.", "Have you ever traveled_to Germany before?"));
            qlist.Add(Question.makeQuestion("There was also a partridge in a pear_tree.", "I can do backflips.",
                "I hope to_cross the_road to get to the other side.", "Eggs with toast and juice please.",
                "What would_you_like to_eat?"));

            return qlist;
        }

        public void setEnabled(Button A1, Button A2, Button A3, Button A4)
        {
            A1.IsEnabled = true;
            A2.IsEnabled = true;
            A3.IsEnabled = true;
            A4.IsEnabled = true;
        }

        public void updateUI()
        {
            var rnd = new Random();
            questions = questions.OrderBy(x => rnd.Next()).ToList();

            
            if (questions.Count< 1)
            {
                try
                {
                    
                    using (var tw = new StreamWriter("C:\\hack\\lscore.txt"))
                    {
                        tw.WriteLine(lscore.ToString());
                        tw.Close();
                    }
                    Console.WriteLine(lscore+"\n\n");
                    Console.ReadLine();
                    questions = makeQuestions();
                }
                catch (IOException e)
                {
                    Console.WriteLine("You done fucked up " + e);
                    Console.ReadLine();
                    System.Windows.Application.Current.Shutdown();
                }
            }
            else
            {
                Translator t = new Translator();
                questions.Add(t.translateQuestion(lscore, langCode, questions.ElementAt(0)));
                
                Question q = questions.Last();
               
                questions.Remove(q);
                questions.Remove(questions.ElementAt(0));
                
                Dictionary<string, bool> l = q.getAnswerSet();
                
                foreach (KeyValuePair<string, bool> x in l)
                {
                    if (x.Value)
                    {
                        ans = x.Key;
                        ans = replaceUnderscore(ans);
                    }
                }
                
                setUI(q);
            }
        }

        public static string replaceUnderscore(string s)
        {
            string sNoUnders = s.Replace('_', ' ');
            return sNoUnders;
        }

        public void setUI(Question q)
        {
            
            Dictionary<string, bool> dict = q.getAnswerSet();
            var rnd = new Random();
            List<KeyValuePair<string, bool>>l = dict.OrderBy(x => rnd.Next()).ToList();
            A1t.Text = replaceUnderscore(l.ElementAt(0).Key);
            A2t.Text = replaceUnderscore(l.ElementAt(1).Key);
            A3t.Text = replaceUnderscore(l.ElementAt(2).Key);
            A4t.Text = replaceUnderscore(l.ElementAt(3).Key);
            qbox.Text = replaceUnderscore(q.getQuestionText()+"?");
            using (var tw = new StreamWriter("C:\\hack\\lscore.txt"))
            {
                tw.WriteLine(lscore.ToString());
                tw.WriteLine(langCode);
                tw.Close();
            }

        }
    }

}
