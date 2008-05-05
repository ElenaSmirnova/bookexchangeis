using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public partial class LoginForm : Form {
  public LoginForm() {
    InitializeComponent();
  }

  private void OKBt_Click(object sender, EventArgs e) {
    LoginManager Login = LoginManager.Instance();
    GlobalVars.user = Login.MakeUser(LoginBox.Text, PassBox.Text);
    if (GlobalVars.user != null) {
      if (GlobalVars.user.Type == UserType.Admin)
        new AdminForm().Show();
      else if (GlobalVars.user.Type == UserType.SimpleUser)
        new UserForm().Show();
      Hide();
    } else MessageBox.Show("Incorrect Login or Password");
  }

  private void CancelBt_Click(object sender, EventArgs e) {
    Application.Exit();
  }
}
 
