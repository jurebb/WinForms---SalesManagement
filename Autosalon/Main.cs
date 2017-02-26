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
    public partial class Main : Form
    {
        public static string _user;
        public Main()
        {
            InitializeComponent();
        }
        public Main(string user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            Form fNar1 = new Nar1();
            ActiveForm.Hide();
            fNar1.Show();
            fNar1.Location = this.Location;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLag_Click(object sender, EventArgs e)
        {
            Form fLager = new Lager();
            ActiveForm.Hide();
            fLager.Show();
            fLager.Location = this.Location;
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            Form fServis = new Servis(_user);
            ActiveForm.Hide();
            fServis.Show();
            fServis.Location = this.Location;
        }
    }
}
