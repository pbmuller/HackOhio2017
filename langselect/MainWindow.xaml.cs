using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace langselect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            LanguageSel.ItemsSource = AddLanguages();
        }

        private void LanguageSel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public List<string> AddLanguages()
        {
            List<string> langs = new List<string>();
            langs.Add("	Afrikaans	");
            langs.Add("	Albanian	");
            langs.Add("	Amharic	");
            langs.Add("	Arabic	");
            langs.Add("	Armenian	");
            langs.Add("	Azeerbaijani	");
            langs.Add("	Basque	");
            langs.Add("	Belarusian	");
            langs.Add("	Bengali	");
            langs.Add("	Bosnian	");
            langs.Add("	Bulgarian	");
            langs.Add("	Catalan	");
            langs.Add("	Cebuano	");
            langs.Add("	Chinese (Simplified)	");
            langs.Add("	Chinese (Traditional)	");
            langs.Add("	Corsican	");
            langs.Add("	Croatian	");
            langs.Add("	Czech	");
            langs.Add("	Danish	");
            langs.Add("	Dutch	");
            langs.Add("	English	");
            langs.Add("	Esperanto	");
            langs.Add("	Estonian	");
            langs.Add("	Finnish	");
            langs.Add("	French	");
            langs.Add("	Frisian	");
            langs.Add("	Galician	");
            langs.Add("	Georgian	");
            langs.Add("	German	");
            langs.Add("	Greek	");
            langs.Add("	Gujarati	");
            langs.Add("	Haitian Creole	");
            langs.Add("	Hausa	");
            langs.Add("	Hawaiian	");
            langs.Add("	Hebrew	");
            langs.Add("	Hindi	");
            langs.Add("	Hmong	");
            langs.Add("	Hungarian	");
            langs.Add("	Icelandic	");
            langs.Add("	Igbo	");
            langs.Add("	Indonesian	");
            langs.Add("	Irish	");
            langs.Add("	Italian	");
            langs.Add("	Japanese	");
            langs.Add("	Javanese	");
            langs.Add("	Kannada	");
            langs.Add("	Kazakh	");
            langs.Add("	Khmer	");
            langs.Add("	Korean	");
            langs.Add("	Kurdish	");
            langs.Add("	Kyrgyz	");
            langs.Add("	Lao	");
            langs.Add("	Latin	");
            langs.Add("	Latvian	");
            langs.Add("	Lithuanian	");
            langs.Add("	Luxembourgish	");
            langs.Add("	Macedonian	");
            langs.Add("	Malagasy	");
            langs.Add("	Malay	");
            langs.Add("	Malayalam	");
            langs.Add("	Maltese	");
            langs.Add("	Maori	");
            langs.Add("	Marathi	");
            langs.Add("	Mongolian	");
            langs.Add("	Myanmar (Burmese)	");
            langs.Add("	Nepali	");
            langs.Add("	Norwegian	");
            langs.Add("	Nyanja (Chichewa)	");
            langs.Add("	Pashto	");
            langs.Add("	Persian	");
            langs.Add("	Polish	");
            langs.Add("	Portuguese	");
            langs.Add("	Punjabi	");
            langs.Add("	Romanian	");
            langs.Add("	Russian	");
            langs.Add("	Samoan	");
            langs.Add("	Scots Gaelic	");
            langs.Add("	Serbian	");
            langs.Add("	Sesotho	");
            langs.Add("	Shona	");
            langs.Add("	Sindhi	");
            langs.Add("	Sinhala (Sinhalese)	");
            langs.Add("	Slovak	");
            langs.Add("	Slovenian	");
            langs.Add("	Somali	");
            langs.Add("	Spanish	");
            langs.Add("	Sundanese	");
            langs.Add("	Swahili	");
            langs.Add("	Swedish	");
            langs.Add("	Tagalog (Filipino)	");
            langs.Add("	Tajik	");
            langs.Add("	Tamil	");
            langs.Add("	Telugu	");
            langs.Add("	Thai	");
            langs.Add("	Turkish	");
            langs.Add("	Ukrainian	");
            langs.Add("	Urdu	");
            langs.Add("	Uzbek	");
            langs.Add("	Vietnamese	");
            langs.Add("	Welsh	");
            langs.Add("	Xhosa	");
            langs.Add("	Yiddish	");
            langs.Add("	Yoruba	");
            langs.Add("	Zulu	");

            return langs;
        }
    }
}
