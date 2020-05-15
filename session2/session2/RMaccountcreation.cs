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
    public partial class RMaccountcreation : Form
    {
        Session1Entities db = new Session1Entities();
        public RMaccountcreation()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void RMaccountcreation_Load(object sender, EventArgs e)
        {
            var q1 = db.User_Type.ToList();
            foreach( var item in q1)
            {
                type.Items.Add(item.userTypeName);
            }
            type.SelectedIndex = 0;
        }

        private void create_Click(object sender, EventArgs e)
        {
            var q1 = db.Users.ToList();
            foreach(var item in q1)
            {
                var text = UID.Text.Trim();
                if (item.userId == text)
                {
                    MessageBox.Show("User ID Taken!");
                    return;
                }
            }
            if(UID.Text.Trim().Length < 8)
            {
                MessageBox.Show("Invalid User ID!");
                return;
            }
            if(Pass.Text != RPass.Text)
            {
                MessageBox.Show("Invalid Password");
                return;
            }
            User user = new User();
            user.userId = UID.Text.Trim();
            user.userName = Uname.Text.Trim();
            user.userPw = Pass.Text;
            user.userTypeIdFK = type.SelectedIndex + 1;

            db.Users.Add(user);
            try
            {
                db.SaveChanges();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }
    }
}
