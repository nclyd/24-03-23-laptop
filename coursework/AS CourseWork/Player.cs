using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_CourseWork
{
    [Serializable]
    public class Player
    {
        private string username, password, forename, surname, ReEnterPassword;
        private Image avatar;


        public Player()
        {
         
        }
        public string Username
        {
            get { return username; }
            set
            {
                int valid = 0;
                List<Player> Accounts = new List<Player>();
                Accounts = SaveAccounts.FetchPlayer();
                foreach(Player p in Accounts)
                {
                    if(p.Username == value)
                    {
                        valid += 1;
                    }
                }
                if(valid != 0)
                {
                    throw new Exception("Name already chosen");
                }
                else
                {
                    username = value;
                }
            }
        }


        public string Password
        {
            get { return password; }
            set
            {
                bool capital = false;
                bool special = false;
                if(value.Length >= 8)
                {
                    for(int i = 0; i< value.Length; i++)
                    {
                        if (Char.IsUpper(value[i]))
                        {
                            capital = true;
                        }
                        else if (!Char.IsLetterOrDigit(value[i]))
                        {
                            special = true;
                        }
                    }
                    if(capital && special)
                    {
                        if(value == ReEnterPassword)
                        {
                            password = value;
                        }
                        else
                        {
                            throw new PasswordException("Password Invalid. Passwords must contain atleast 8 characters, 1 of which being a capital and 1 being a special character.");
                        }
                    }
                    else
                    {
                        throw new PasswordException("Password Invalid. Passwords must contain atleast 8 characters, 1 of which being a capital and 1 being a special character.");
                    }
                }
                else
                {
                    throw new PasswordException("Password Invalid. Passwords must contain atleast 8 characters, 1 of which being a capital and 1 being a special character.");
                }
                
            }
        }


        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public string PassValidate
        {
            get { return ReEnterPassword; }
            set { ReEnterPassword = value; }
        }
    }
}
