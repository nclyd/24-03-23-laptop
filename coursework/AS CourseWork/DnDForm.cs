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
    public partial class DnDForm : Form
    {

        private int currentQuestion;
        public DnDForm()
        {
            InitializeComponent();
            currentQuestion = 1;
            LoadQuestion();
            AllowDropping();
        }

        private void LoadQuestion()
        {
            List<DnD> questions = Quiz.GetDnDs();
            lblDnDQuestion.Text = questions[currentQuestion].QuestionText;
            lblTextDrop1.Text = questions[currentQuestion].Text[0];
            lblTextDrop2.Text = questions[currentQuestion].Text[1];
            lblTextDrop3.Text = questions[currentQuestion].Text[2];
            pictureBox1.Image = questions[currentQuestion].Image[0];
            pictureBox2.Image = questions[currentQuestion].Image[1];
            pictureBox3.Image = questions[currentQuestion].Image[2];




        }

        private void AllowDropping()
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
        }

        private void LabelGrabbed(object sender, MouseEventArgs e)
        {
            Label selectedLabel = new Label();
            selectedLabel = (Label)sender;
            selectedLabel.DoDragDrop(selectedLabel.Text, DragDropEffects.Copy);
        }

        private void AllowDragDropCopy(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LabelDropped(object sender, DragEventArgs e)
        {
            string result = (string)e.Data.GetData(DataFormats.Text);
            PictureBox picBox = (PictureBox)sender;
            
        }




    }
}
