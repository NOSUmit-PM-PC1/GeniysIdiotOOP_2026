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
        string[] diagnoze = { "Идиот", "Дебил", "Дурак", "Норма", "Талант", "Гений" };

        int countRightAnswer = 0;
        bool endTest = false;
        QuestionsRepository questions = new QuestionsRepository();
        public FormTest()
        {
            InitializeComponent();
        }

        void checkAnswer()
        {
            if (!endTest)
            {
                int userAnswer = Convert.ToInt32(textBoxUserAnswer.Text);
                if (questions.CheckAnswer(userAnswer))
                {
                    countRightAnswer++;
                }
            }
        }
        private void buttonCheckUserAnswer_Click(object sender, EventArgs e)
        {

            if (!questions.EndOfQuestions())
            {
                checkAnswer();
                labelQuestion.Text = questions.ShowNextQuestion();
            }
            else
            {
                checkAnswer();
                endTest = true;
                FormSaveScore formSaveScore = new FormSaveScore(questions.GetScore(countRightAnswer));
                formSaveScore.ShowDialog();
                MessageBox.Show(diagnoze[countRightAnswer]);
                FormScore formScore = new FormScore();
                formScore.ShowDialog();
            }
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            labelQuestion.Text = questions.ShowNextQuestion();
        }
    }
}
