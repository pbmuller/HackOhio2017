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
            List<KeyValuePair<string, bool>> l = q.getAnswerSet();
            foreach (KeyValuePair<string,bool>x in l){
                if (x.Value)
                {
                    ans = x.Key;
                }
            }

            setUI(q);
           
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            
            if (ans == A1.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                updateUI();
            }
            else
            {
                A1.IsEnabled = false;
                lscore -= 2;
            }
            
            
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A2.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                updateUI();
            }
            else
            {
                A2.IsEnabled = false;
                lscore -= 2;
            }
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A3.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                updateUI();
                
            }
            else
            {
                A3.IsEnabled = false;
                lscore -= 2;
            }
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A4.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                lscore += 5;
                updateUI();
            }
            else
            {
                A4.IsEnabled = false;
                lscore -= 2;
            }
        }



        public static List<Question> makeQuestions()
        {
            Translator t = new Translator();
            List<Question> qlist = new List<Question>();
            qlist.Add(Question.makeQ("I am a cherry_doughnut.", "The_trees are on fire.",
                "The_weather in winter is cold.", "Hello, I am doing_well.",
                "Hello, how are you today?"));
            t.translate(lscore, qlist[0],"german-english");
            qlist.Add(Question.makeQ("Butterflies are beautiful.", "Yes, I would_like to have dinner.",
                "Hello world is an overly_used phrase.", "Yes, it would_be_nice to_learn German",
                "Would_you_like to learn German?"));
            qlist.Add(Question.makeQ("Sleep in a tree.", "My_dog snuggled my_cat.", "No, we didn't start the_fire.",
                "Check my_phone and brush my_teeth.", "What do you do when you wake up?"));
            qlist.Add(Question.makeQ("The_earth is actually flat.", "I don't have any pouridge.", "I like_to_visit Canada.",
                "No, but I really want to visit Germany.", "Have you ever traveled to Germany before?"));
            qlist.Add(Question.makeQ("There was also a partridge in a pear_tree.", "I can do backflips.",
                "I hope to cross the road to get to the other side.", "Eggs, toast, and juice please.",
                "What would_you_like to eat?"));

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
                    using (var tw = new StreamWriter("C:\\Users\\Jacob\\hackohio\\HackOhio2017\\lscore.txt", true))
                    {
                        tw.WriteLine(lscore.ToString());
                        tw.Close();
                    }
                    Console.WriteLine(lscore+"\n\n");
                    Console.ReadLine();
                    System.Windows.Application.Current.Shutdown();
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
                List<KeyValuePair<string, bool>> l = q.getAnswerSet();
                foreach (KeyValuePair<string, bool> x in l)
                {
                    if (x.Value)
                    {
                        ans = x.Key;
                    }
                }
                setUI(q);
            }
        }

        public void setUI(Question q)
        {
            qbox.Text = q.getQuestionText();
            List<KeyValuePair<string, bool>> l = q.getAnswerSet();
            var rnd = new Random();
            l = l.OrderBy(x => rnd.Next()).ToList();
            A1.Content = l.ElementAt(0).Key;
            A2.Content = l.ElementAt(1).Key;
            A3.Content = l.ElementAt(2).Key;
            A4.Content = l.ElementAt(3).Key;

        }
    }

}
