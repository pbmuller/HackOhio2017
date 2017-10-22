using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LingoLearner
{
    public class GermanDictionary
    {
        public Dictionary<string, string> words;
        public GermanDictionary()
        {
            loadDictionary();
        }
        private void loadDictionary()
        {
            this.words = new Dictionary<string, string>();
            this.words.Add("i", "ich");
            this.words.Add("am", "bin");
            this.words.Add("a", "ein");
            this.words.Add("cherry_doughnut", "Kirchkrapfen");
            this.words.Add("the_trees_are", "die_Bäume_sind");
            this.words.Add("are", "bist");
            this.words.Add("on", "auf");
            this.words.Add("fire", "Brand");
            this.words.Add("the_weather", "das_Wetter");
            this.words.Add("in", "im");
            this.words.Add("winter", "Winter");
            this.words.Add("is", "ist");
            this.words.Add("cold", "kalt");
            this.words.Add("hello", "hallo");
            this.words.Add("doing_well", "machst_gut");
            this.words.Add("butterflies", "Schmetterling");
            this.words.Add("beautiful", "schön");
            this.words.Add("yes", "ja");
            this.words.Add("would_you_like", "möchtest_du");
            this.words.Add("would_like", "möchte");
            this.words.Add("to have", "haben");
            this.words.Add("dinner", "Abendessen");
            this.words.Add("an", "ein");
            this.words.Add("overly_used", "überlastet");
            this.words.Add("phrase", "Phrase");
            this.words.Add("it", "es");
            this.words.Add("would_be_nice", "wäre_nett");
            this.words.Add("to_learn", "lernen");
            this.words.Add("german", "Deutsch");
            this.words.Add("sleep", "schlaf");
            this.words.Add("tree", "Baum");
            this.words.Add("my_dog", "mein_Hund");
            this.words.Add("snuggled", "gekuschelt");
            this.words.Add("my_cat", "meine_Katze");
            this.words.Add("no", "nein");
            this.words.Add("we", "wir");
            this.words.Add("did", "tat");
            this.words.Add("not", "nicht");
            this.words.Add("start", "anfangen");
            this.words.Add("the_fire", "das_Feuer");
            this.words.Add("check", "überprüfen");
            this.words.Add("my_phone", "mein_telefon");
            this.words.Add("and", "und");
            this.words.Add("brush", "putzen");
            this.words.Add("my_teeth", "meine_Zähne");
            this.words.Add("what", "was");
            this.words.Add("do", "machen");
            this.words.Add("when", "wann");
            this.words.Add("wake_up", "aufwachen");
            this.words.Add("the_earth", "die_Erde");
            this.words.Add("actually", "tatsächlich");
            this.words.Add("flat", "flach");
            this.words.Add("do_not_have", "habe_nicht");
            this.words.Add("porridge", "Haferbrei");
            this.words.Add("like_to_visit", "gerne_besuchen");
            this.words.Add("canada", "Kanada");
            this.words.Add("but", "aber");
            this.words.Add("really", "wirklich");
            this.words.Add("want", "wollen");
            this.words.Add("to_visit", "besuchen");
            this.words.Add("germany", "Deutschland");
            this.words.Add("ever", "jemals");
            this.words.Add("traveled_to", "gereist_nach");
            this.words.Add("before", "vor");
            this.words.Add("there", "da");
            this.words.Add("was", "war");
            this.words.Add("also", "auch");
            this.words.Add("partridge", "Rebhuhn");
            this.words.Add("pear_tree", "Birnebaum");
            this.words.Add("can", "kann");
            this.words.Add("backflips", "Rückwärtssalto");
            this.words.Add("hope", "hoffe");
            this.words.Add("to_cross", "kreuzen");
            this.words.Add("the_road", "die_Straße");
            this.words.Add("to_get", "bekommen");
            this.words.Add("the", "die");
            this.words.Add("other", "andere");
            this.words.Add("side", "Seite");
            this.words.Add("eggs", "Eier");
            this.words.Add("toast", "Toast");
            this.words.Add("juice", "Saft");
            this.words.Add("please", "bitte");
            this.words.Add("like", "mogen");
            this.words.Add("to_eat", "essen");
            this.words.Add("you", "du");
            this.words.Add("how", "wie");
            this.words.Add("today", "heute");
            this.words.Add("do_you_do", "machst_du");
            this.words.Add("have", "bist");
            this.words.Add("world", "Welt");
            this.words.Add("to", "zu");
            this.words.Add("with", "mit");
            this.words.Add("any", "irgendein");
            this.words.Add("would", "würde");
        }
    }
}