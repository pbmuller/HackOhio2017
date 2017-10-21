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
       
        public string ans;
        public MainWindow()
        {
            
            List<Question> questions = makeQuestions();
            InitializeComponent();
            Question q = questions.ElementAt(0);
            if (q.getAnswerPair().Key == ans) {
                qbox.Text = "win";
            }
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
