using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_Roman
{
    internal class Question
    {
        protected string _questionText;
        protected string _answerText;

        public Question(string question, string answer)
        {
            _questionText = question;
            _answerText = answer;
        }

        public void Ask()
        {
            Console.WriteLine(_questionText);
        }

        public virtual bool CheckAnswer()
        {
            Console.WriteLine("Your answer: ");
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
