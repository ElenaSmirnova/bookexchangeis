partial class AdminForm {
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.BooksPage = new System.Windows.Forms.TabPage();
      this.AddBookBt = new System.Windows.Forms.Button();
      this.BooksView = new System.Windows.Forms.DataGridView();
      this.UsersTab = new System.Windows.Forms.TabPage();
      this.SaveBt = new System.Windows.Forms.Button();
      this.UsersView = new System.Windows.Forms.DataGridView();
      this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MiddleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RoleColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.StatusColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.PersonsPage = new System.Windows.Forms.TabPage();
      this.SavePerson = new System.Windows.Forms.Button();
      this.PersonsView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1.SuspendLayout();
      this.BooksPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.BooksView)).BeginInit();
      this.UsersTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UsersView)).BeginInit();
      this.PersonsPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PersonsView)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.BooksPage);
      this.tabControl1.Controls.Add(this.UsersTab);
      this.tabControl1.Controls.Add(this.PersonsPage);
      this.tabControl1.Location = new System.Drawing.Point(0, -2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.Padding = new System.Drawing.Point(0, 0);
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(665, 435);
      this.tabControl1.TabIndex = 0;
      // 
      // BooksPage
      // 
      this.BooksPage.Controls.Add(this.AddBookBt);
      this.BooksPage.Controls.Add(this.BooksView);
      this.BooksPage.Location = new System.Drawing.Point(4, 22);
      this.BooksPage.Name = "BooksPage";
      this.BooksPage.Padding = new System.Windows.Forms.Padding(3);
      this.BooksPage.Size = new System.Drawing.Size(657, 409);
      this.BooksPage.TabIndex = 1;
      this.BooksPage.Text = "Books";
      this.BooksPage.UseVisualStyleBackColor = true;
      // 
      // AddBookBt
      // 
      this.AddBookBt.Location = new System.Drawing.Point(8, 284);
      this.AddBookBt.Name = "AddBookBt";
      this.AddBookBt.Size = new System.Drawing.Size(75, 23);
      this.AddBookBt.TabIndex = 1;
      this.AddBookBt.Text = "Add book";
      this.AddBookBt.UseVisualStyleBackColor = true;
      this.AddBookBt.Click += new System.EventHandler(this.AddBookBt_Click);
      // 
      // BooksView
      // 
      this.BooksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.BooksView.Location = new System.Drawing.Point(8, 6);
      this.BooksView.Name = "BooksView";
      this.BooksView.Size = new System.Drawing.Size(639, 272);
      this.BooksView.TabIndex = 0;
      // 
      // UsersTab
      // 
      this.UsersTab.Controls.Add(this.SaveBt);
      this.UsersTab.Controls.Add(this.UsersView);
      this.UsersTab.Location = new System.Drawing.Point(4, 22);
      this.UsersTab.Name = "UsersTab";
      this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
      this.UsersTab.Size = new System.Drawing.Size(657, 409);
      this.UsersTab.TabIndex = 0;
      this.UsersTab.Text = "Users";
      this.UsersTab.UseVisualStyleBackColor = true;
      // 
      // SaveBt
      // 
      this.SaveBt.Location = new System.Drawing.Point(8, 285);
      this.SaveBt.Name = "SaveBt";
      this.SaveBt.Size = new System.Drawing.Size(75, 23);
      this.SaveBt.TabIndex = 2;
      this.SaveBt.Text = "Save Changes";
      this.SaveBt.UseVisualStyleBackColor = true;
      this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
      // 
      // UsersView
      // 
      this.UsersView.AllowUserToDeleteRows = false;
      this.UsersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.UsersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.LoginColumn,
            this.PasswordColumn,
            this.NameColumn,
            this.SurnameColumn,
            this.MiddleNameColumn,
            this.RoleColumn,
            this.StatusColumn});
      this.UsersView.Location = new System.Drawing.Point(8, 6);
      this.UsersView.Name = "UsersView";
      this.UsersView.Size = new System.Drawing.Size(639, 273);
      this.UsersView.TabIndex = 0;
      // 
      // IdColumn
      // 
      this.IdColumn.DataPropertyName = "id_user";
      this.IdColumn.HeaderText = "Id";
      this.IdColumn.Name = "IdColumn";
      this.IdColumn.ReadOnly = true;
      // 
      // LoginColumn
      // 
      this.LoginColumn.DataPropertyName = "log";
      this.LoginColumn.HeaderText = "Login";
      this.LoginColumn.Name = "LoginColumn";
      // 
      // PasswordColumn
      // 
      this.PasswordColumn.DataPropertyName = "pass";
      this.PasswordColumn.HeaderText = "Password";
      this.PasswordColumn.Name = "PasswordColumn";
      // 
      // NameColumn
      // 
      this.NameColumn.DataPropertyName = "name";
      this.NameColumn.HeaderText = "Name";
      this.NameColumn.Name = "NameColumn";
      // 
      // SurnameColumn
      // 
      this.SurnameColumn.DataPropertyName = "Surname";
      this.SurnameColumn.HeaderText = "Surname";
      this.SurnameColumn.Name = "SurnameColumn";
      // 
      // MiddleNameColumn
      // 
      this.MiddleNameColumn.DataPropertyName = "Middle_Name";
      this.MiddleNameColumn.HeaderText = "Middle Name";
      this.MiddleNameColumn.Name = "MiddleNameColumn";
      // 
      // RoleColumn
      // 
      this.RoleColumn.DataPropertyName = "id_roles";
      this.RoleColumn.HeaderText = "Role";
      this.RoleColumn.Name = "RoleColumn";
      this.RoleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.RoleColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // StatusColumn
      // 
      this.StatusColumn.DataPropertyName = "user_status_id";
      this.StatusColumn.HeaderText = "Status";
      this.StatusColumn.Name = "StatusColumn";
      // 
      // PersonsPage
      // 
      this.PersonsPage.Controls.Add(this.SavePerson);
      this.PersonsPage.Controls.Add(this.PersonsView);
      this.PersonsPage.Location = new System.Drawing.Point(4, 22);
      this.PersonsPage.Name = "PersonsPage";
      this.PersonsPage.Padding = new System.Windows.Forms.Padding(3);
      this.PersonsPage.Size = new System.Drawing.Size(657, 409);
      this.PersonsPage.TabIndex = 2;
      this.PersonsPage.Text = "Persons";
      this.PersonsPage.UseVisualStyleBackColor = true;
      // 
      // SavePerson
      // 
      this.SavePerson.Location = new System.Drawing.Point(8, 282);
      this.SavePerson.Name = "SavePerson";
      this.SavePerson.Size = new System.Drawing.Size(75, 23);
      this.SavePerson.TabIndex = 2;
      this.SavePerson.Text = "Save";
      this.SavePerson.UseVisualStyleBackColor = true;
      this.SavePerson.Click += new System.EventHandler(this.SavePerson_Click);
      // 
      // PersonsView
      // 
      this.PersonsView.AllowUserToDeleteRows = false;
      this.PersonsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.PersonsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this.PersonsView.Location = new System.Drawing.Point(6, 3);
      this.PersonsView.Name = "PersonsView";
      this.PersonsView.Size = new System.Drawing.Size(639, 273);
      this.PersonsView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "id_persons";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
      this.dataGridViewTextBoxColumn4.HeaderText = "Name";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Surname";
      this.dataGridViewTextBoxColumn5.HeaderText = "Surname";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "Middle_Name";
      this.dataGridViewTextBoxColumn6.HeaderText = "Middle Name";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // AdminForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 430);
      this.Controls.Add(this.tabControl1);
      this.Name = "AdminForm";
      this.Text = "AdminForm";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
      this.tabControl1.ResumeLayout(false);
      this.BooksPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.BooksView)).EndInit();
      this.UsersTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.UsersView)).EndInit();
      this.PersonsPage.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PersonsView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
  private System.Windows.Forms.TabControl tabControl1;
  private System.Windows.Forms.TabPage UsersTab;
  private System.Windows.Forms.TabPage BooksPage;
  private System.Windows.Forms.DataGridView BooksView;
  private System.Windows.Forms.DataGridView UsersView;
  private System.Windows.Forms.Button SaveBt;
  private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
  private System.Windows.Forms.DataGridViewTextBoxColumn MiddleNameColumn;
  private System.Windows.Forms.DataGridViewComboBoxColumn RoleColumn;
  private System.Windows.Forms.DataGridViewComboBoxColumn StatusColumn;
  private System.Windows.Forms.Button AddBookBt;
  private System.Windows.Forms.TabPage PersonsPage;
  private System.Windows.Forms.DataGridView PersonsView;
  private System.Windows.Forms.Button SavePerson;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
}
