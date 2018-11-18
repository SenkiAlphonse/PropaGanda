using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropagandaGepezet
{
    class Verb : Word 
    {
        public string ThirdPerson;
        public string SecondForm;
        public string ThirdForm;
        public string PresentContinuous;
        public bool Transitive;

        public Verb(string baseForm, string thirdPerson, string secondForm, string thirdForm, string presentContinuous, bool transitive) : base(baseForm)
        {
            ThirdPerson = thirdPerson;
            SecondForm = secondForm;
            ThirdForm = thirdForm;
            PresentContinuous = presentContinuous;
            Transitive = transitive;
        }
    }
}
