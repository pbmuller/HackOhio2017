using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LingoLearner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int lscore;
        public List<Question> questions = makeQuestions();
        public string ans;
        public MainWindow()
        {
            try
            {               
                StreamReader sr = new StreamReader("C:\\Users\\Jacob\\hackohio\\HackOhio2017\\lscore.txt");
                lscore = Convert.ToInt32(sr.ReadLine());
            }
            catch(IOException e)
            {
                
                using (var tw = new StreamWriter("C:\\Users\\Jacob\\hackohio\\HackOhio2017\\lscore.txt", true))
                {
                    tw.WriteLine("0");
                    tw.Close();
                }

                // System.Windows.Application.Current.Shutdown();
            }
            
            InitializeComponent();

          
            var rnd = new Random();
            questions = questions.OrderBy(x => rnd.Next()).ToList();


            Question q = questions.ElementAt(0);
            questions.Remove(q);

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



        public static List<Question> makeQuestions()
        {
            Translator t = new Translator();
            List<Question> qlist = new List<Question>();
            qlist.Add(t.translateQuestion(lscore, Question.makeQuestion("I am a cherry_doughnut.", "The_trees_are on fire.",
                "The_weather in winter is cold.", "Hello, I am doing_well.",
                "Hello, how are you today?")));
            qlist.Add(t.translateQuestion(lscore, Question.makeQuestion("Butterflies are beautiful.", "Yes, I would_like to_eat dinner.",
                "Hello world is an overly_used phrase.", "Yes, it would_be_nice to_learn German",
                "Would_you_like to_learn German?")));
            qlist.Add(t.translateQuestion(lscore, Question.makeQuestion("Sleep in a tree.", "My_dog snuggled my_cat.", "No, we did not start the_fire.",
                "Check my_phone and brush my_teeth.", "What do_you_do when you wake_up?")));
            qlist.Add(t.translateQuestion(lscore, Question.makeQuestion("The_earth is actually flat.", "I do_not_have any porridge.", "I like_to_visit Canada.",
                "No, but I would like_to_visit Germany.", "Have you ever traveled_to Germany before?")));
            qlist.Add(t.translateQuestion(lscore, Question.makeQuestion("There was also a partridge in a pear_tree.", "I can do backflips.",
                "I hope to_cross the_road to get to the other side.", "Eggs with toast and juice please.",
                "What would_you_like to_eat?")));

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
                    
                    using (var tw = new StreamWriter("C:\\Users\\Jacob\\hackohio\\HackOhio2017\\lscore.txt"))
                    {
                        tw.WriteLine(lscore.ToString());
                        tw.Close();
                    }
                    Console.WriteLine(lscore+"\n\n");
                    Console.ReadLine();
                    //System.Windows.Application.Current.Shutdown();
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
                Question q = questions.ElementAt(0);
                questions.Remove(q);
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
            qbox.Text = replaceUnderscore(q.getQuestionText());
            Dictionary<string, bool> dict = q.getAnswerSet();
            var rnd = new Random();
            List<KeyValuePair<string, bool>>l = dict.OrderBy(x => rnd.Next()).ToList();
            A1t.Text = replaceUnderscore(l.ElementAt(0).Key);
            A2t.Text = replaceUnderscore(l.ElementAt(1).Key);
            A3t.Text = replaceUnderscore(l.ElementAt(2).Key);
            A4t.Text = replaceUnderscore(l.ElementAt(3).Key);

        }
    }

}
