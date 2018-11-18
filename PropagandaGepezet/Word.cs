using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropagandaGepezet
{
    abstract class Word
    {
        public string BaseForm { get; }

        public Word(string baseForm)
        {
            BaseForm = baseForm;
        }
    }
}
