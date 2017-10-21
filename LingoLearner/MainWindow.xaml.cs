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
        
        public MainWindow()
        {

            List<Question> questions = makeQuestions();
            InitializeComponent();
            Question q = questions.ElementAt(0);
            setUI(q);
            

        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            qbox.Text = "A1";
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            qbox.Text = "A2";
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            qbox.Text = "A3";
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            qbox.Text = "A4";
        }

        public static List<Question> makeQuestions()
        {
            List<Question> qlist = new List<Question>();

            string s = "Hello, how are you today?";
            List<string> l1 = new List<string>();
            l1.Add("I am good");
            KeyValuePair<string, bool> kv1= new KeyValuePair<string, bool>("I am good", true);

            Question one = new Question(s, l1, kv1, new Dictionary<string, string>());
            qlist.Add(one);


            return qlist;
        }

        public void setUI(Question q)
        {
            qbox.Text = q.questionText;
            A1.Content = q.answerSet.ElementAt(0);
        }
    }
}
