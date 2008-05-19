using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookExchangeis.Dialogs
{
    public partial class AddUserDialog : Form
    {
        UserManager UManager;

        public AddUserDialog()
        {
            InitializeComponent();
            UManager = UserManager.Instance();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int code = UManager.ExecuteAction(GlobalVars.user,
                             new AddUser(nameTb.Text, surnameTb.Text, middleTb.Text,
                            "roles", loginTb.Text, passTb.Text, "user_status_id"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           this.Close();
        }
    }
}