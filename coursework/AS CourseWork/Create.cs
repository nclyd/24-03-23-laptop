using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_CourseWork
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            fillAvatars();
        }

        private Image[] avatars = new Image[3];
        private int currentAvatar = 0;
        private void fillAvatars()
        {
            avatars = new Image[3];
            avatars[0] = Resources.Resources.Avatar1;
            avatars[1] = Resources.Resources.Avatar2;
            avatars[2] = Resources.Resources.Avatar3;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

            bool approved = false;
            bool usernameApproved = false;
            bool passwordApproved = false;
            Player p = new Player();
            try
            {
                
                p.Forename = txtCreateForename.Text;
                p.Surname = txtCreateSurname.Text;
                p.PassValidate = txtCreateReEnterPassword.Text;
                approved = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure all details are filled in.");
            }
            p.Avatar = picCreateAvatar.Image;

            try
            {
                p.Username = txtCreateUsername.Text;
                usernameApproved = true;
            }
            catch(Exception u)
            {
                MessageBox.Show(u.Message);
            }
            try
            {
                p.Password = txtCreatePassword.Text;
                passwordApproved = true;
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please ensure all details are filled in.");
            }

            if (approved && usernameApproved && passwordApproved)
            {
                SaveAccounts.AppendPlayer(p);
                MessageBox.Show("Account Created");
                

                FirstScreen f = new FirstScreen();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please try again");
            }
            
        }
        private void btnCreateAvatarChangeR_Click(object sender, EventArgs e)
        {
            if(currentAvatar == 2)
            {
                currentAvatar = 0;
            }
            else
            {
                currentAvatar++;
            }
            picCreateAvatar.Image = avatars[currentAvatar];
        }

        private void btnCreateAvatarChangeL_Click(object sender, EventArgs e)
        {
            if (currentAvatar == 0)
            {
                currentAvatar = 2;
            }
            else
            {
                currentAvatar--;
            }
            picCreateAvatar.Image = avatars[currentAvatar];
        }

        private void btnBackToMenuCreate_Click(object sender, EventArgs e)
        {
            FirstScreen f = new FirstScreen();
            f.Show();
            this.Hide();
        }
    }
}
