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
        static List<Question> _quizQuestions;
        static int _score = 0;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Weclome to my ");


        }

        static void AddQuestions()
        {
            _quizQuestions.Add(new Question(
                question: "What programming language do we use?", 
                answer: "C#"
            ));

            _quizQuestions.Add(new MultipleChoiceQuestion(
                question: "How many years should Michael get in jail?", 
                answerOptions: new string[] { "0", "5", "50", "2" }, 
                correctAnswer: 0
            ));


            _quizQuestions.Add(new TrueOrFalseQuestion(
                question: "Is 67 funnier than 69?", 
                answerAsBool: false
            ));
        }
    }
}
