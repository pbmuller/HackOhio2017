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
        public int lscore;
        public List<Question> questions = makeQuestions();
        public string ans;
        public MainWindow()
        {
            try
            {
                StreamReader sr = new StreamReader("lscore.txt");
                lscore = Convert.ToInt32(sr.ReadLine());
            }
            catch(IOException e)
            {
                //You done fucked up
                System.Windows.Application.Current.Shutdown();
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
            qbox.Text = lscore.ToString();

        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            
            if (ans == A1.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                updateUI();
            }
            else
            {
                A1.IsEnabled = false;
            }
            
            
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A2.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                updateUI();
            }
            else
            {
                A2.IsEnabled = false;
            }
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A3.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                updateUI();
            }
            else
            {
                A3.IsEnabled = false;
            }
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A4.Content.ToString())
            {
                setEnabled(A1, A2, A3, A4);
                updateUI();
            }
            else
            {
                A4.IsEnabled = false;
            }
        }

        public static List<Question> makeQuestions()
        {
            List<Question> qlist = new List<Question>();

            qlist.Add(Question.makeQ("I am a cherry doughnut.","The trees are on fire.", 
                "The weather in winter is cold.", "Hello, I am doing well.",
                "Hello, how are you today?"));

            qlist.Add(Question.makeQ("Butterflies are beautiful.", "Yes, I would like to have dinner.",
                "Hello world is an overly used phrase.", "Yes, it would be nice to learn German",
                "Would you like to learn German?"));

            qlist.Add(Question.makeQ("Sleep in a tree.", "My dog snuggled my cat.", "No, we didn't start the fire.",
                "Check my phone and brush my teeth.", "What do you do when you wake up?"));

            qlist.Add(Question.makeQ("The earth is actually flat.", "I don't have any pouridge.", "I like to visit Canada.",
                "No, but I really want to visit Germany.", "Have you ever traveled to Germany before?"));

            qlist.Add(Question.makeQ("There was also a partridge in a pear tree.", "I can do backflips.", 
                "I hope to cross the road to get to the other side.","Eggs, toast, and juice please.", 
                "What would you like to eat?"));


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
