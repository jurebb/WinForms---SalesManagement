using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buLogin_Click(object sender, EventArgs e)
        {
            if(User.Check(tBuser.Text, tBpass.Text)==1)
            {
                MessageBox.Show("Dobrodosli!");

                ActiveForm.Hide();
                //ActiveForm.Dispose();
                Form fMain = new Main(tBuser.Text);
                fMain.Show();
                fMain.Location = this.Location;
                //initiate

            }
            else if (User.Check(tBuser.Text, tBpass.Text) == 2)
            {
                MessageBox.Show("Pogresna lozinka!");
            }
            else
            {
                MessageBox.Show("Neispravno korisnicko ime!");
            }
        }

        /**private void lnLabCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveForm.Hide();
            Form fNewUser = new NewUser();
            fNewUser.Location = this.Location;
            fNewUser.Show();
            
        }**/
    }
}
