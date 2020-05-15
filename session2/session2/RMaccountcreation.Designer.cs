namespace session2
{
    partial class RMaccountcreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.RPass = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.create = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(481, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASEAN Skills 2020";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(32, 29);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 47);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Account Creation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-Enter Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "User ID (For login):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "User Name:";
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(382, 156);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(224, 22);
            this.Uname.TabIndex = 8;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(382, 202);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(224, 22);
            this.UID.TabIndex = 9;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(382, 248);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = 'X';
            this.Pass.Size = new System.Drawing.Size(224, 22);
            this.Pass.TabIndex = 10;
            // 
            // RPass
            // 
            this.RPass.Location = new System.Drawing.Point(382, 291);
            this.RPass.Name = "RPass";
            this.RPass.PasswordChar = 'X';
            this.RPass.Size = new System.Drawing.Size(224, 22);
            this.RPass.TabIndex = 11;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(382, 344);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(224, 24);
            this.type.TabIndex = 12;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(331, 396);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(156, 42);
            this.create.TabIndex = 13;
            this.create.Text = "Create Account";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(-2, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 56);
            this.panel2.TabIndex = 14;
            // 
            // RMaccountcreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.create);
            this.Controls.Add(this.type);
            this.Controls.Add(this.RPass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "RMaccountcreation";
            this.Text = "RMaccountcreation";
            this.Load += new System.EventHandler(this.RMaccountcreation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox RPass;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Panel panel2;
    }
}