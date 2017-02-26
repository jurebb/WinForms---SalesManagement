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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            a = User.Check(tBuser.Text, tBpass.Text);
           if ( a == 0 && (tBuser.Text!="" && tBpass.Text!=""))
           {
                User.CreateUser(tBuser.Text, tBpass.Text);
                ActiveForm.Hide();
                ActiveForm.Dispose();
                Form fLogin = new Login();
                fLogin.Show();
                fLogin.Location = this.Location;
                MessageBox.Show("Dodan novi user!");
            }
           else
           {
                MessageBox.Show("Korisnicko ime vec postoji ili pogresan unos!");
           }


        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
