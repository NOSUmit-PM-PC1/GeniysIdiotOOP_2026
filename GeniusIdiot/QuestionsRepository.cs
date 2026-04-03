using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot
{
    internal class QuestionsRepository
    {
        List<Question> listTestQuestions = new List<Question>();
        int[] orderQuestions = { 2, 4, 0, 1, 3 };
        int numberQuestion;
        Random rnd = new Random();

        public QuestionsRepository()
        {
            string[] questions = { "2 + 2 * 2", "2 руках 10 пальцев, сколько пальцев на 5 руках", "бревно разделили на 10 частей, сколько сделали распилов", "укол делают каждые полчаса, сколько минут надо 3 укола", "горело 5 свечей 2 погасло, сколько осталось" };
            int[] rightAnswer = { 6, 25, 9, 60, 2 };
            for (int i = 0; i < questions.Length; i++)
            {
                Question q = new Question(questions[i], rightAnswer[i]);
                listTestQuestions.Add(q);
            }
            shuffleOrderQuestion();
            numberQuestion = -1;
        }

        public string ShowNextQuestion()
        {
            numberQuestion++;
            string textQuestion = listTestQuestions[orderQuestions[numberQuestion]].ShowQuestion(); 
            return textQuestion;
        }

        public bool EndOfQuestions()
        {
            return numberQuestion >= listTestQuestions.Count - 1;
        }

        public bool CheckAnswer(int userAnswer)
        {
            return listTestQuestions[orderQuestions[numberQuestion]].CheckAnswer(userAnswer);
        }

        void shuffleOrderQuestion()
        {
            for (int i = 0; i < 10; i++)
            {
                int pos1 = rnd.Next(orderQuestions.Length);
                int pos2 = rnd.Next(orderQuestions.Length);
                int temp = orderQuestions[pos1];
                orderQuestions[pos1] = orderQuestions[pos2];
                orderQuestions[pos2] = temp;
            }
        }

    }
}
