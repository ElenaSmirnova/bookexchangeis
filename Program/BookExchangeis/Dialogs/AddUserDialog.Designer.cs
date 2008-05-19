namespace BookExchangeis.Dialogs
{
    partial class AddUserDialog
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
            this.isAdminChb = new System.Windows.Forms.CheckBox();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.middleTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isAdminChb
            // 
            this.isAdminChb.AutoSize = true;
            this.isAdminChb.Location = new System.Drawing.Point(61, 12);
            this.isAdminChb.Name = "isAdminChb";
            this.isAdminChb.Size = new System.Drawing.Size(54, 17);
            this.isAdminChb.TabIndex = 0;
            this.isAdminChb.Text = "admin";
            this.isAdminChb.UseVisualStyleBackColor = true;
            // 
            // loginTb
            // 
            this.loginTb.Location = new System.Drawing.Point(79, 35);
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(102, 20);
            this.loginTb.TabIndex = 1;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(79, 61);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(102, 20);
            this.passTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(14, 209);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(57, 29);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(103, 210);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(56, 27);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(79, 87);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(101, 20);
            this.nameTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "name";
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(78, 115);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(102, 20);
            this.surnameTb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "surname";
            // 
            // middleTb
            // 
            this.middleTb.Location = new System.Drawing.Point(78, 145);
            this.middleTb.Name = "middleTb";
            this.middleTb.Size = new System.Drawing.Size(101, 20);
            this.middleTb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "middle name";
            // 
            // AddUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 249);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.middleTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.isAdminChb);
            this.Name = "AddUserDialog";
            this.Text = "AddUserDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isAdminChb;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox middleTb;
        private System.Windows.Forms.Label label5;
    }
}