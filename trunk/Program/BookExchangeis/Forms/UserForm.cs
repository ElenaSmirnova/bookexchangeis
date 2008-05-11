using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public partial class UserForm : Form {
  UserManager UsrManager;
  public UserForm() {
    InitializeComponent();
    UsrManager = UserManager.Instance();
  }
  private void UserForm_Load(object sender, EventArgs e) {
  }
  private void ShowBooksBt_Click(object sender, EventArgs e) {
    object Result;
    int code = UsrManager.ExecuteAction(GlobalVars.user, new GetBooks(), out Result);
    if (code == 0)
      BooksView.DataSource = Result;
  }
  private void UserForm_FormClosed(object sender, FormClosedEventArgs e) {
    Application.Exit();
  }

  private void AddBook_Click(object sender, EventArgs e)
  {
      new AddBookForm().ShowDialog();
  }

  
}
