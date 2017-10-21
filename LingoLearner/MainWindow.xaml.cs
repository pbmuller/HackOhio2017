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
       
        string ans;
        public MainWindow()
        {
            
            List<Question> questions = makeQuestions();
            InitializeComponent();
            Question q = questions.ElementAt(0);
            if (q.getAnswerPair().Key == ans) { }
            setUI(q);
            

        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            ans = A1.Content.ToString();
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            ans = A2.Content.ToString();
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            ans = A3.Content.ToString();
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            ans = A4.Content.ToString();
        }

        public static List<Question> makeQuestions()
        {
            List<Question> qlist = new List<Question>();

            qlist.Add(Question.makeQ("Hello, I am doing well.", "I am a cherry doughnut.",
                "The trees are on fire.", "The weather in winter is cold.", 
                "Hello, how are you today?"));

            qlist.Add(Question.makeQ("Butterflies are beautiful.", "Yes, I would like to have dinner.",
                "Hello world is an overly used phrase.", "Yes, it would be nice to learn German",
                "Would you like to learn German?"));


            return qlist;
        }

<<<<<<< HEAD
        public static Question makeQ (string s1, string s2, string s3, string answer, string question)
        {
            List <string> l =new  List<string>();
            l.Add(s1);
            l.Add(s2);
            l.Add(s3);
            l.Add(answer);
            KeyValuePair<string, bool> kv = new KeyValuePair<string, bool>(answer, true);
            Question q = new Question(question, l, kv, "german-english");

            return(q);
        }
=======
>>>>>>> 8b2c0ccdf5f75a89807803a6024bd88e6c805157

        public void setUI(Question q)
        {
            qbox.Text = q.getQuestionText();
            A1.Content = q.getAnswerSet().ElementAt(0);
            A2.Content = q.getAnswerSet().ElementAt(1);
            A3.Content = q.getAnswerSet().ElementAt(2);
            A4.Content = q.getAnswerSet().ElementAt(3);

        }
    }
}
