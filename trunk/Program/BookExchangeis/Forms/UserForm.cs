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
      BooksView.DataSource = UsrManager.ExecuteAction(GlobalVars.user, new GetBooks());
      
    }

  private void UserForm_FormClosed(object sender, FormClosedEventArgs e) {
    Application.Exit();
  }
  }
