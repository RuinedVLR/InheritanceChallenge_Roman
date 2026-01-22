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

            if (correctAnswer > 0 && correctAnswer <= _answerOptions.Length)
            {
                _correctAnswer = correctAnswer - 1;
            }
            else if (correctAnswer >= 0 && correctAnswer < _answerOptions.Length)
            {
                _correctAnswer = correctAnswer;
            }
            else
            {
                _correctAnswer = -1;
            }
        }

        public override bool CheckAnswer()
        {
            for (int i = 0; i <= _answerOptions.Length - 1; i++)
            {
                Console.WriteLine($"{i + 1}: {_answerOptions[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("Your answer 1-4: ");
            string answLine = Console.ReadLine();
            int answ;

            while (!int.TryParse(answLine, out answ) || answ > 4 || answ < 1)
            {
                Console.WriteLine("Wrong input. Your answer 1-4: ");
                answLine = Console.ReadLine();
            }

            return (_correctAnswer >= 0) && ((answ - 1) == _correctAnswer);
        }

        public override string CorrectAnswer
        {
            get
            {
                if (_correctAnswer >= 0 && _correctAnswer < _answerOptions.Length)
                {
                    return _answerOptions[_correctAnswer];
                }

                return base.CorrectAnswer;
            }
        }
    }
}
