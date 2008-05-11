  partial class UserForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
      this.UserTabControl = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.ShowBooksBt = new System.Windows.Forms.Button();
      this.BooksView = new System.Windows.Forms.DataGridView();
      this.UserTabControl.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksView)).BeginInit();
      this.SuspendLayout();
      // 
      // UserTabControl
      // 
      this.UserTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.UserTabControl.Controls.Add(this.tabPage1);
      this.UserTabControl.Location = new System.Drawing.Point(0, 0);
      this.UserTabControl.Name = "UserTabControl";
      this.UserTabControl.Padding = new System.Drawing.Point(0, 0);
      this.UserTabControl.SelectedIndex = 0;
      this.UserTabControl.Size = new System.Drawing.Size(633, 377);
      this.UserTabControl.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.ShowBooksBt);
      this.tabPage1.Controls.Add(this.BooksView);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(625, 351);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "BooksPage";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // ShowBooksBt
      // 
      this.ShowBooksBt.Location = new System.Drawing.Point(6, 281);
      this.ShowBooksBt.Name = "ShowBooksBt";
      this.ShowBooksBt.Size = new System.Drawing.Size(75, 23);
      this.ShowBooksBt.TabIndex = 1;
      this.ShowBooksBt.Text = "Show Books";
      this.ShowBooksBt.UseVisualStyleBackColor = true;
      this.ShowBooksBt.Click += new System.EventHandler(this.ShowBooksBt_Click);
      // 
      // BooksView
      // 
      this.BooksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.BooksView.Location = new System.Drawing.Point(0, 0);
      this.BooksView.Name = "BooksView";
      this.BooksView.Size = new System.Drawing.Size(625, 275);
      this.BooksView.TabIndex = 0;
      // 
      // UserForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 376);
      this.Controls.Add(this.UserTabControl);
      this.Name = "UserForm";
      this.Text = "UserForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
      this.Load += new System.EventHandler(this.UserForm_Load);
      this.UserTabControl.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl UserTabControl;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button ShowBooksBt;
    private System.Windows.Forms.DataGridView BooksView;
  }
