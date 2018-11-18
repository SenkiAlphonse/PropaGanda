using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropagandaGepezet
{
    class Dictionary
    {
        Random r = new Random();
        List<Verb> verbs = new List<Verb>();
        List<Noun> nouns = new List<Noun>();

        public Dictionary()
        {
            verbs.Add(new Verb("swim", "swims", "swam", "swum", "swimming", false));
            verbs.Add(new Verb("make", "makes", "made", "made", "making", true));
            verbs.Add(new Verb("trick", "tricks", "tricked", "tricked", "tricking", true));

            nouns.Add(new Noun("kitten", "kitties", false));
            nouns.Add(new Noun("cicada", "cicadae", false));
            nouns.Add(new Noun("screwdriver", "screwdrivers", false));
        }

        public Verb RandomVerb()
        {
            int ind = r.Next(0, verbs.Count);
            return verbs[ind];            
        }

        public Noun RandomNoun()
        {
            int ind = r.Next(0, nouns.Count);
            return nouns[ind];
        }

        //string jverbs = JsonConvert.SerializeObject(verbs, Formatting.Indented);
        //string jnouns = JsonConvert.SerializeObject(nouns, Formatting.Indented);
    }
}
