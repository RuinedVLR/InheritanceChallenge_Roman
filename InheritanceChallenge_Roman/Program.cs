using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge_Roman
{
    internal class Program
    {
        static public List<Question> _quizQuestions = new List<Question>();
        static public int _score = 0;

        static Random _rng = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Weclome to my amazing (not)League of Legends quiz!");
            Console.ReadKey(true);
            Console.WriteLine("Just kidding, it's a real League of Legends facts quiz :)");
            Console.ReadKey(true);
            AddQuestions();

            Shuffle(_quizQuestions);

            foreach (Question question in _quizQuestions)
            {
                question.Ask();
                bool isCorrect = question.CheckAnswer();
                if (isCorrect)
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong answer! It was {question.CorrectAnswer}");
                }
                Console.ReadKey(true);
            }

            Console.Clear();
            Console.WriteLine($"Quiz finished! Your final score is {_score} out of {_quizQuestions.Count}.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void AddQuestions()
        {
            _quizQuestions.Add(new Question(
                question: "What character would be shown if you typed \"Jimmy Neutron\" in the shop?", 
                answer: "Sheen"
            ));

            _quizQuestions.Add(new MultipleChoiceQuestion(
                question: "How many finger and toes does Neeko have?", 
                answerOptions: new string[] { "5 & 5", "6 & 3", "4 & 4", "5 & 4" }, 
                correctAnswer: 4
            ));

            _quizQuestions.Add(new TrueOrFalseQuestion(
                question: "Vi's R has the code copied from Nautilus R, but she is the charge that follows the target.", 
                answerAsBool: true
            ));

            _quizQuestions.Add(new Question(
                question: "What character's name will create a shape of 4 on a keyboard if connect all the letters in order? (4 letters)",
                answer: "Jhin"
            ));

            _quizQuestions.Add(new MultipleChoiceQuestion(
                question: "If using a skin that gave a character sunglasses, how much damage taken is reduced from Leona's passive? (got removed :c)",
                answerOptions: new string[] { "1", "5", "2", "Not reduced" },
                correctAnswer: 1
            ));

            _quizQuestions.Add(new TrueOrFalseQuestion(
                question: "Even if Teemo is invisible, Aatrox's first meet voice line will trigger.",
                answerAsBool: true
            ));

            _quizQuestions.Add(new Question(
                question: "What character had 1% chance of saying his taunt as: “Well, my Mom works for Riot, and she’s going to ban you!” instead of his usual line?",
                answer: "Smolder"
            ));

            _quizQuestions.Add(new MultipleChoiceQuestion(
                question: "What weapon Jax does NOT use, just because Riot Games thought he was too damn good for any other ones?",
                answerOptions: new string[] { "Lamppost", "Chicken's Foot", "Fan", "Spatula" },
                correctAnswer: 3
            ));

            _quizQuestions.Add(new TrueOrFalseQuestion(
                question: "Dr. Mundo is lactose tolerant.",
                answerAsBool: false
            ));
        }

        // Fisher–Yates shuffle
        static void Shuffle<T>(List<T> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = _rng.Next(i + 1);
                T tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }
        }
    }
}
