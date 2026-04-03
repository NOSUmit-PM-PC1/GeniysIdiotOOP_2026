using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot
{
    class Question
    {
        string text;
        int answer;

        public string Text { get; }

        public Question(string txt, int ans )
        {
            this.text = txt;
            this.answer = ans;
        }

        public string ShowQuestion()
        { 
            return text;
        }

        public bool CheckAnswer(int userAnswer)
        { 
            return answer == userAnswer;
        }

    }
}
