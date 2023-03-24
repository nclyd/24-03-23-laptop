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
    public partial class FirstScreen : Form
    {

        public static List<Player> players;
        public FirstScreen()
        {
            InitializeComponent();
            players = new List<Player>();
        }

        public static List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        private void btnTakeToCreate_Click(object sender, EventArgs e)
        {
            Create c = new Create();
            c.Show();
            this.Hide();
        }

        private void btnTakeToLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
