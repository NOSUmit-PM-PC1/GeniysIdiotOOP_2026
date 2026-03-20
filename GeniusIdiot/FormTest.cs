using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniusIdiot
{
    public partial class FormTest : Form
    {
        string[] questions = {"2 + 2 * 2", "2 руках 10 пальцев, сколько пальцев на 5 руках", "бревно разделили на 10 частей, сколько сделали распилов", "укол делают каждые полчаса, сколько минут надо 3 укола", "горело 5 свечей 2 погасло, сколько осталось" };
        int[] rightAnswer = { 6, 25, 9, 60, 2};
        int[] orderQuestions = { 2, 4, 0, 1, 3 };

        string[] diagnoze = { "Идиот", "Дебил", "Дурак", "Норма", "Талант", "Гений" };

        int countRightAnswer = 0;
        int numberQuestion = 0;

        bool endTest = false;

        void shuffleOrderQuestion()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            { 
                int pos1 = rnd.Next(orderQuestions.Length);
                int pos2 = rnd.Next(orderQuestions.Length);
                int temp = orderQuestions[pos1];
                orderQuestions[pos1] = orderQuestions[pos2];
                orderQuestions[pos2] = temp;
            }
        }
        public FormTest()
        {
            InitializeComponent();
        }

        void checkAnswer()
        {
            if (!endTest)
            {
                int userAnswer = Convert.ToInt32(textBoxUserAnswer.Text);
                if (userAnswer == rightAnswer[orderQuestions[numberQuestion]])
                {
                    countRightAnswer++;
                }
            }
        }
        private void buttonCheckUserAnswer_Click(object sender, EventArgs e)
        {
           
            if (numberQuestion < questions.Length - 1)
            {
                checkAnswer();
                numberQuestion++;
                labelQuestion.Text = questions[orderQuestions[numberQuestion]];
            }
            else
            {
                checkAnswer();
                endTest = true;
                MessageBox.Show(diagnoze[countRightAnswer]);
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            shuffleOrderQuestion();
            labelQuestion.Text = questions[orderQuestions[numberQuestion]];
        }
    }
}
