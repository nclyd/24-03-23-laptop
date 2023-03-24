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
    public partial class QuestionPick : Form
    {
        public QuestionPick()
        {
            InitializeComponent();
        }

        private void btnMCQPick_Click(object sender, EventArgs e)
        {
            Quiz.CurrentTopic = "Comp Sci";
            Form1 m = new Form1();
            this.Hide();
            m.Show();


        }
    }
}
