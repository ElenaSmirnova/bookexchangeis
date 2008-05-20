using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
    public partial class AddBookForm : Form
    {
        UserManager UManager;
        public AddBookForm()
        {
            InitializeComponent();
            UManager = UserManager.Instance();
        }

        private void AddBookForm_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void AddBookForm_Shown(object sender, EventArgs e)
        {
            object Result;
            int code = UManager.ExecuteAction(GlobalVars.user, new GetPersons(), out Result);
            if (code == 0)
            {
                DataTable temp = Result as DataTable;
                foreach (DataRow r in temp.Rows)
                {
                    Authors.Items.Add(r["id_persons"] + " " +r["name"].ToString() + " " + r["surname"].ToString() + " " + r["middle_name"].ToString());
                }

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if ((Authors.SelectedItem != null) && (BookNameBox.Text != ""))
            {
                string t = Authors.SelectedItem as String;

                t = t.Substring(0, t.IndexOf(" "));
                int id = Convert.ToInt32(t);
                int code = UManager.ExecuteAction(GlobalVars.user,
                           new AddBook(id, BookNameBox.Text));
                if (code == 0)
                {
                    this.Close();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        
    }

