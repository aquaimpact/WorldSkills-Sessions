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
    public partial class Resourcemanagement : Form
    {
        Session1Entities db = new Session1Entities();
        public Resourcemanagement()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            RMlogin rMlogin = new RMlogin();
            rMlogin.Show();
        }

        private void Resourcemanagement_Load(object sender, EventArgs e)
        {
            var q1 = db.Skills.ToList();
            comboBox2.Items.Add("Select 1");
            foreach (var item in q1)
            {
                comboBox2.Items.Add(item.skillName);
            }
            comboBox2.SelectedIndex = 0;

            var q2 = db.Resource_Type.ToList();
            comboBox1.Items.Add("Select 1");
            foreach (var item in q2)
            {
                comboBox1.Items.Add(item.resTypeName);
            }
            comboBox1.SelectedIndex = 0;

            var q3 = db.Resources.ToList();
            dataGridView1.DataSource = cdt(q3);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells["Available Quantity"].Value.ToString() == "Not Available")
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private DataTable cdt(List<Resource> resources)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("No of Skills");
            dt.Columns.Add("Allocated Skill(s)");
            dt.Columns.Add("Available Quantity");

            foreach (var item in resources)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = item.resId;
                dr["Name"] = item.resName;
                dr["Type"] = item.Resource_Type.resTypeName;
                var q2 = db.Resource_Allocation.Where(x => x.resIdFK == item.resId).ToList();
                dr["No of Skills"] = q2.Count();

                var text = "";
                foreach (var items in q2)
                {
                    text += items.Skill.skillName + ",";
                }
                dr["Allocated Skill(s)"] = text;
                if (item.remainingQuantity > 5)
                {
                    dr["Available Quantity"] = "Sufficient";
                }
                else if (item.remainingQuantity <= 5 && item.remainingQuantity >= 1)
                {
                    dr["Available Quantity"] = "Low Stock";
                }
                else
                {
                    dr["Available Quantity"] = "Not Available";
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {
            var q1 = db.Resources.ToList();

            if (comboBox2.SelectedIndex != 0)
            {
                var lol2 = comboBox2.SelectedIndex;
                var q2 = db.Resource_Allocation.Where(x => x.skillIdFK == lol2).ToList();
                List<Resource> lols = new List<Resource>();
                foreach( var item in q2)
                {
                    lols.Add(item.Resource);
                }

                q1 = lols;
            }
            

            if (comboBox1.SelectedIndex != 0)
            {
                var lol1 = comboBox1.SelectedIndex;
                q1 = q1.Where(x => x.Resource_Type.resTypeId == lol1).ToList();
            }

            dataGridView1.DataSource = cdt(q1);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                if (dr.Cells["Available Quantity"].Value.ToString() == "Not Available")
                {
                    dr.DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void add_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddResource addResource = new AddResource();
            addResource.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells["ID"].Value.ToString());
                    this.Hide();
                    UpdateResource addResource = new UpdateResource(ID);
                    addResource.Show();
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    var ID = int.Parse(dr.Cells["ID"].Value.ToString());
                    var item = db.Resources.Where(x => x.resId == ID).FirstOrDefault();
                    if (item != null)
                    {

                        var lols = db.Resource_Allocation.Where(x => x.resIdFK == ID).ToList();
                        foreach(var items in lols)
                        {
                            db.Resource_Allocation.Remove(items);
                        }


                        db.Resources.Remove(item);
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Success!");

                            var q3 = db.Resources.ToList();
                            dataGridView1.DataSource = cdt(q3);
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                            foreach (DataGridViewRow drs in dataGridView1.Rows)
                            {
                                if (drs.Cells["Available Quantity"].Value.ToString() == "Not Available")
                                {
                                    drs.DefaultCellStyle.BackColor = Color.Red;
                                }
                            }
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show(es.ToString());
                            return;
                        }

                    }
                }
            }
        }
    }
}
