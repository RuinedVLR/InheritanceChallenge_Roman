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

        public override bool CheckAnswer()
        {
            Console.WriteLine("Your answer (true/false): ");
            string answ = Console.ReadLine().ToLower();
            if (answ == _answerText.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
