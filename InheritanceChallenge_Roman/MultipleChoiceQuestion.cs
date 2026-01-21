using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_Roman
{
    internal class MultipleChoiceQuestion : Question
    {
        string[] _answerOptions;
        int _correctAnswer;

        public MultipleChoiceQuestion(string question, string[] answerOptions, int correctAnswer) : base(question, correctAnswer.ToString())
        {
            _answerOptions = answerOptions;
            _correctAnswer = correctAnswer;
        }

        public override bool CheckAnswer()
        {
            for (int i = 0; i <= _answerOptions.Length; i++)
            {
                Console.WriteLine($"{i}: {_answerOptions[i]}");
            }

            Console.WriteLine("Your answer 1-4: ");
            string answLine = Console.ReadLine();
            int answ = int.Parse(answLine);

            while (answLine == null || answ > 4 || answ < 1)
            {
                Console.WriteLine("Wrong input. Your answer 1-4: ");
                answLine = Console.ReadLine();
                answ = int.Parse(answLine);
            }

            if (answ == _correctAnswer)
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
