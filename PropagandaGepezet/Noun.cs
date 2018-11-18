using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropagandaGepezet
{
    class Noun : Word
    {
        public string Plural;
        public bool StartsWithVowel;

        public Noun( string baseForm, string plural, bool startsWithVowel) : base(baseForm)
        {
            Plural = plural;
            StartsWithVowel = startsWithVowel;
        }
    }
}
