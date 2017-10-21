using System;
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
        public List<Question> questions = makeQuestions();
        public string ans;
        public MainWindow()
        {
            
            
            InitializeComponent();

          
            var rnd = new Random();
            questions = questions.OrderBy(x => rnd.Next()).ToList();

            Question q = questions.ElementAt(0);
            questions.Remove(q);
            ans = q.getAnswerPair().Key.ToString();

            setUI(q);


        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            
            if (ans == A1.Content.ToString())
            {
                updateUI(questions);
            }
            
            
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A2.Content.ToString())
            {
                updateUI(questions);
            }
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A3.Content.ToString())
            {
                updateUI(questions);
            }
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (ans == A4.Content.ToString())
            {
                updateUI(questions);
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

        public void updateUI(List<Question> questions)
        {
            var rnd = new Random();
            questions = questions.OrderBy(x => rnd.Next()).ToList();

            Question q = questions.ElementAt(0);
            questions.Remove(q);
            setUI(q);
        }

        public void setUI(Question q)
        {
            qbox.Text = q.getQuestionText();
            List<string> l = q.getAnswerSet();
            var rnd = new Random();
            l = l.OrderBy(x => rnd.Next()).ToList();
            A1.Content = l.ElementAt(0);
            A2.Content = l.ElementAt(1);
            A3.Content = l.ElementAt(2);
            A4.Content = l.ElementAt(3);

        }
    }

}
