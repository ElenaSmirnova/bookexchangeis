using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public partial class AdminForm : Form {
  UserManager UManager;
  private void LoadUsersView() {
    UsersView.DataSource = UManager.ExecuteAction(GlobalVars.user, new GetUsers());
    (UsersView.Columns["RoleColumn"] as DataGridViewComboBoxColumn).DataSource = Roles.Instance().Data;
    (UsersView.Columns["RoleColumn"] as DataGridViewComboBoxColumn).DisplayMember = "name";
    (UsersView.Columns["RoleColumn"] as DataGridViewComboBoxColumn).ValueMember = "id_roles";
    (UsersView.Columns["StatusColumn"] as DataGridViewComboBoxColumn).DataSource = Statuses.Instance().Data;
    (UsersView.Columns["StatusColumn"] as DataGridViewComboBoxColumn).DisplayMember = "name";
    (UsersView.Columns["StatusColumn"] as DataGridViewComboBoxColumn).ValueMember = "user_status_id";
  }
  private void LoadBooksView() {
    BooksView.DataSource = UManager.ExecuteAction(GlobalVars.user, new GetBooks());
  }
  public AdminForm() {
    InitializeComponent();
    UManager = UserManager.Instance();
    LoadBooksView();
    LoadUsersView();
  }
  
  private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }

  
  private void SaveBt_Click(object sender, EventArgs e) {
    DataTable temp = UsersView.DataSource as DataTable;
    foreach (DataRow r in temp.Rows) {
      if (r.RowState == DataRowState.Added) {
        UManager.ExecuteAction(GlobalVars.user, 
          new AddUser(r["name"], r["surname"], r["middle_name"], r["id_roles"], r["log"], r["pass"], r["user_status_id"]));
        r.AcceptChanges();
      }
    }
  }
}
