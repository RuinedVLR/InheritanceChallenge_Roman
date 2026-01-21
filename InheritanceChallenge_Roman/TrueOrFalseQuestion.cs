using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_Roman
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string question, bool answerAsBool) : base(question, answerAsBool.ToString())
        {
            
        }
    }
}
