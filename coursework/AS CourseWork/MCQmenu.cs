using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_CourseWork
{
    public partial class Form1 : Form
    {
        private int currentQuestion;
        List<MultipleChoice> questions;
        public Form1()
        {
            InitializeComponent();
            currentQuestion = 0;
            questions = Quiz.GetMCQs();
            loadQuestion();
        }
        private void loadQuestion()
        {
           
            lblQuestionText.Text = questions[currentQuestion].QuestionText;
            btnAns1.Text = questions[currentQuestion].possibleAns[0];
            btnAns2.Text = questions[currentQuestion].possibleAns[1];
            btnAns3.Text = questions[currentQuestion].possibleAns[2];
            btnAns4.Text = questions[currentQuestion].possibleAns[3];

            
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            Button b = new Button();
            b = (Button)sender;

            if (b.Text == questions[currentQuestion].Answer)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
            currentQuestion++;
            if (currentQuestion == 5)
            {
                DnDForm n = new DnDForm();
                this.Hide();
                n.Show();
            }
            else
                loadQuestion();
        }
    }
}
