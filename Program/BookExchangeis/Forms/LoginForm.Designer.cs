partial class LoginForm {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }
  #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.LoginBox = new System.Windows.Forms.TextBox();
      this.PassBox = new System.Windows.Forms.TextBox();
      this.OKBt = new System.Windows.Forms.Button();
      this.CancelBt = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LoginBox
      // 
      this.LoginBox.Location = new System.Drawing.Point(86, 12);
      this.LoginBox.Name = "LoginBox";
      this.LoginBox.Size = new System.Drawing.Size(100, 20);
      this.LoginBox.TabIndex = 0;
      this.LoginBox.Text = "admin";
      // 
      // PassBox
      // 
      this.PassBox.Location = new System.Drawing.Point(86, 38);
      this.PassBox.Name = "PassBox";
      this.PassBox.Size = new System.Drawing.Size(100, 20);
      this.PassBox.TabIndex = 1;
      this.PassBox.Text = "admin";
      // 
      // OKBt
      // 
      this.OKBt.Location = new System.Drawing.Point(12, 64);
      this.OKBt.Name = "OKBt";
      this.OKBt.Size = new System.Drawing.Size(75, 23);
      this.OKBt.TabIndex = 2;
      this.OKBt.Text = "OK";
      this.OKBt.UseVisualStyleBackColor = true;
      this.OKBt.Click += new System.EventHandler(this.OKBt_Click);
      // 
      // CancelBt
      // 
      this.CancelBt.Location = new System.Drawing.Point(111, 64);
      this.CancelBt.Name = "CancelBt";
      this.CancelBt.Size = new System.Drawing.Size(75, 23);
      this.CancelBt.TabIndex = 3;
      this.CancelBt.Text = "Cancel";
      this.CancelBt.UseVisualStyleBackColor = true;
      this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Login:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Password:";
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(197, 97);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CancelBt);
      this.Controls.Add(this.OKBt);
      this.Controls.Add(this.PassBox);
      this.Controls.Add(this.LoginBox);
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

  private System.Windows.Forms.TextBox LoginBox;
  private System.Windows.Forms.TextBox PassBox;
  private System.Windows.Forms.Button OKBt;
  private System.Windows.Forms.Button CancelBt;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label label2;
  }
