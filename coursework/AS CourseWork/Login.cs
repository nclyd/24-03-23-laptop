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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            fillCombobox();
        }
        private void fillCombobox()
        {
            foreach (Player p in SaveAccounts.FetchPlayer())
            {
                cBoxLoginUsername.Items.Add(p.Username);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = SaveAccounts.FetchPlayer()[cBoxLoginUsername.SelectedIndex].Username;
            string password = txtLoginPassword.Text;

            int Index = 0;
            List<Player> everyPlayer = new List<Player>();
            everyPlayer = SaveAccounts.FetchPlayer();



            for (int i = 0; i < everyPlayer.Count(); i++)
            {
                if (everyPlayer[i].Username == username && everyPlayer[i].Password == password)
                {
                    MessageBox.Show("Welcome " + everyPlayer[i].Forename);

                    Index = i;


                    QuestionPick x = new QuestionPick();

                    this.Hide();
                    x.Show();
                    break;





                }
            }





            void btnBackToMenu_Click(object sender, EventArgs e)
            {
                FirstScreen f = new FirstScreen();
                f.Show();
                this.Hide();
            }


        }
    }
}
