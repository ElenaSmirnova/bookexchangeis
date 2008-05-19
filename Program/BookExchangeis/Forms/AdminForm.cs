using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BookExchangeis.Dialogs;

public partial class AdminForm : Form {
  UserManager UManager;
  private void ApplyUsersChanges() {
    DataTable temp = UsersView.DataSource as DataTable;
    foreach (DataRow r in temp.Rows) {
      try {
        int code;
        switch (r.RowState) {
          case DataRowState.Added:
            code = UManager.ExecuteAction(GlobalVars.user,
                 new AddUser(r["name"].ToString(), r["surname"].ToString(), r["middle_name"].ToString(),
                        r["id_roles"].ToString(), r["log"].ToString(), r["pass"].ToString(),
                        r["user_status_id"].ToString()));
            break;
          case DataRowState.Modified:
            code = UManager.ExecuteAction(GlobalVars.user,
                   new UpdateUser(r["id_user"].ToString(), r["name"].ToString(), r["surname"].ToString(), r["middle_name"].ToString(),
                        r["id_roles"].ToString(), r["log"].ToString(), r["pass"].ToString(),
                        r["user_status_id"].ToString()));
            break;
        }
        r.AcceptChanges();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message);
      }
    }
  }
  private void LoadUsersView() {
    object Result;
    int code = UManager.ExecuteAction(GlobalVars.user, new GetUsers(), out Result);
    if (code == 0) {
      UsersView.DataSource = Result;
      (UsersView.Columns["RoleColumn"] as DataGridViewComboBoxColumn).DataSource = Roles.Instance().Data;
      (UsersView.Columns["RoleColumn"] as DataGridViewComboBoxColumn).DisplayMember = "name";
      (UsersView.Columns["RoleColumn"] as DataGridViewComboBoxColumn).ValueMember = "id_roles";
      (UsersView.Columns["StatusColumn"] as DataGridViewComboBoxColumn).DataSource = Statuses.Instance().Data;
      (UsersView.Columns["StatusColumn"] as DataGridViewComboBoxColumn).DisplayMember = "name";
      (UsersView.Columns["StatusColumn"] as DataGridViewComboBoxColumn).ValueMember = "user_status_id";
    }
  }
  private void LoadBooksView() {
    object Result;
    int code = UManager.ExecuteAction(GlobalVars.user, new GetBooks(), out Result);
    if (code == 0)
      BooksView.DataSource = Result;
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
    ApplyUsersChanges();
  }

    private void AddUserBt_Click(object sender, EventArgs e)
    {
        new AddUserDialog().Show();
    }
}
