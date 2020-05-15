using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session2
{
    public partial class RMlogin : Form
    {
        Session1Entities db = new Session1Entities();
        public RMlogin()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void RMlogin_Load(object sender, EventArgs e)
        {
           
        }

        private void login_Click(object sender, EventArgs e)
        {
            var q1 = db.Users.Where(x => x.userId == UID.Text && x.userPw == Pass.Text).FirstOrDefault();
            if (q1 != null)
            {
                this.Hide();
                Resourcemanagement resourcemanagement = new Resourcemanagement();
                resourcemanagement.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password!");
                return;
            }
        }
    }
}
