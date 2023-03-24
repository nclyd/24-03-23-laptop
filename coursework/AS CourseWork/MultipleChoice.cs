using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_CourseWork
{
    class MultipleChoice : Question
    {
        private string[] PossibleAns;
        private string answer;

        public MultipleChoice() : base()
        {
            possibleAns = new string[4];

        }

        public string[] possibleAns { get => PossibleAns; set => PossibleAns = value; }
        public string Answer { get => answer; set => answer = value; }

        public bool CheckAns(string attemptedAns)
        {
            if (attemptedAns != answer)
            {
                return false;
            }
            else
                return true;
        }
    }
}
