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
    public partial class UpdateResource : Form
    {
        Session1Entities db = new Session1Entities();
        int IDs;
        public UpdateResource(int ID)
        {
            InitializeComponent();
            IDs = ID;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resourcemanagement resourcemanagement = new Resourcemanagement();
            resourcemanagement.Show();
        }

        private void UpdateResource_Load(object sender, EventArgs e)
        {
            var q2 = db.Skills.ToList();
            foreach (var item in q2)
            {
                checkedListBox1.Items.Add(item.skillName);
            }

            var q1 = db.Resources.Where(x => x.resId == IDs).FirstOrDefault();
            if(q1 != null)
            {
                name.Text = q1.resName;
                type.Text = q1.Resource_Type.resTypeName;
                numericUpDown1.Value = q1.remainingQuantity;
                var q3 = db.Resource_Allocation.Where(x => x.resIdFK == IDs).ToList();
                foreach(var item in q3)
                {
                    checkedListBox1.SetItemChecked(item.skillIdFK - 1, true);
                }
                
            }

            if (numericUpDown1.Value == 0)
            {
                checkedListBox1.Visible = false;
            }
            else
            {
                checkedListBox1.Visible = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                checkedListBox1.Visible = false;
            }
            else
            {
                checkedListBox1.Visible = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            var get1 = db.Resources.Where(x => x.resId == IDs).FirstOrDefault();
            if(get1 != null)
            {
                get1.remainingQuantity = (int)numericUpDown1.Value;
            }

            if (numericUpDown1.Value != 0)
            {
                var q4 = db.Resource_Allocation.Where(x => x.resIdFK == IDs).ToList();
                foreach(var item in q4)
                {
                    db.Resource_Allocation.Remove(item);
                }
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    Resource_Allocation resource_Allocation = new Resource_Allocation();
                    resource_Allocation.resIdFK = IDs;
                    var q3 = db.Skills.Where(x => x.skillName == item.ToString()).FirstOrDefault();
                    if (q3 != null)
                    {
                        resource_Allocation.skillIdFK = q3.skillId;
                    }
                    db.Resource_Allocation.Add(resource_Allocation);
                }
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Sucess!");
                    this.Hide();
                    Resourcemanagement lol1 = new Resourcemanagement();
                    lol1.Show();
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.ToString());
                }
            }
            else
            {
                MessageBox.Show("Sucess!");
                this.Hide();
                Resourcemanagement lol1 = new Resourcemanagement();
                lol1.Show();
            }
        }
    }
}
