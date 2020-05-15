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
    public partial class AddResource : Form
    {
        Session1Entities db = new Session1Entities();
        public AddResource()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resourcemanagement resourcemanagement = new Resourcemanagement();
            resourcemanagement.Show();
        }

        private void AddResource_Load(object sender, EventArgs e)
        {
            var q1 = db.Resource_Type.ToList();
            foreach (var item in q1)
            {
                type.Items.Add(item.resTypeName);
            }
            type.SelectedIndex = 0;

            var q2 = db.Skills.ToList();
            foreach (var item in q2)
            {
                checkedListBox1.Items.Add(item.skillName);
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

        private void add_Click(object sender, EventArgs e)
        {
            Resource resource = new Resource();
            if (Rname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Name");
                return;
            }
            resource.resName = Rname.Text.Trim();
            resource.resTypeIdFK = type.SelectedIndex + 1;
            resource.remainingQuantity = (int)numericUpDown1.Value;


            db.Resources.Add(resource);
            
            try
            {
                db.SaveChanges();

                if (numericUpDown1.Value != 0)
                {
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        Resource_Allocation resource_Allocation = new Resource_Allocation();
                        resource_Allocation.resIdFK = resource.resId;
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

                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Sucess!");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }
    }
}
