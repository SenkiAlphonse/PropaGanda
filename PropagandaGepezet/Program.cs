using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PropagandaGepezet
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();
            Random r = new Random();
            //Verb v001 = new Verb("swim", "swims", "swam", "swum", "swimming", false);
            //Verb v002 = new Verb("make", "makes", "made", "made", "making", true);
            //Verb v003 = new Verb("trick", "tricks", "tricked", "tricked", "tricking", true);

            //Noun n001 = new Noun("kitten", "kitties", false);
            //Noun n002 = new Noun("cicada", "cicadae", false);
            //Noun n003 = new Noun("screwdriver", "screwdrivers", false);

            //List<Verb> verbs = new List<Verb>() { v001, v002, v003 };
            //List<Noun> nouns = new List<Noun>() { n001, n002, n003 };

            //string jverbs = JsonConvert.SerializeObject(verbs, Formatting.Indented);
            //string jnouns = JsonConvert.SerializeObject(nouns, Formatting.Indented);

            //Console.WriteLine(jverbs);
            //Console.WriteLine(jnouns);



            

            CreateSentence(dict);

            Console.ReadKey();
        }

        private static void CreateSentence(Dictionary d)
        {
            Noun subjectnoun = d.RandomNoun();
            string subject = (subjectnoun.StartsWithVowel ? "an" : "a") + " " + subjectnoun.BaseForm;
            string predicate = d.RandomVerb().ThirdPerson;

            string sentence = subject + " " + predicate;
            string initial = sentence[0].ToString();
            initial = initial.ToUpper();
            sentence = initial + sentence.Substring(1);

            Console.WriteLine(sentence);


        }
    }
}
