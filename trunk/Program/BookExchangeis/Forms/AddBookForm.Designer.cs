partial class AddBookForm {
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
        private void InitializeComponent()
        {
            this.Authors = new System.Windows.Forms.ComboBox();
            this.BookNameBox = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Authors
            // 
            this.Authors.FormattingEnabled = true;
            this.Authors.Location = new System.Drawing.Point(12, 47);
            this.Authors.Name = "Authors";
            this.Authors.Size = new System.Drawing.Size(249, 21);
            this.Authors.TabIndex = 0;
            // 
            // BookNameBox
            // 
            this.BookNameBox.AcceptsReturn = true;
            this.BookNameBox.Location = new System.Drawing.Point(303, 47);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(177, 20);
            this.BookNameBox.TabIndex = 1;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(111, 19);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(38, 13);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(364, 19);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(61, 13);
            this.BookName.TabIndex = 3;
            this.BookName.Text = "Book name";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(81, 74);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(399, 29);
            this.add.TabIndex = 4;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 75);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(63, 28);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 115);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookNameBox);
            this.Controls.Add(this.Authors);
            this.Name = "AddBookForm";
            this.Text = "Add book";
            this.Shown += new System.EventHandler(this.AddBookForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.AddBookForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Authors;
        private System.Windows.Forms.TextBox BookNameBox;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
