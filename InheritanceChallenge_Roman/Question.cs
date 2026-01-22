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
            Console.Clear();
            Console.WriteLine($"Your current score is {Program._score}/{Program._quizQuestions.Count}.");
            Console.WriteLine();
            Console.WriteLine(_questionText);
            Console.WriteLine();
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

        public virtual string CorrectAnswer => _answerText;
    }
}
