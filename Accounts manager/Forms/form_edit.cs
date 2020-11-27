using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts_manager
{
    public partial class form_edit : Form
    {
        public form_edit()
        {
            InitializeComponent();
        }

        private string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\Accounts.mdf;Integrated Security=True";
        private string selectedAccID = "-1";

        private void form_edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accounts.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.accounts.Table);

            lbl_edit.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_edit_header.Height = Height / 15;
        }

        private void form_edit_Resize(object sender, EventArgs e)
        {
            lbl_edit.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_edit_header.Height = Height / 15;
        }

        private void cb_searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_edit.DataSource = tableBindingSource;
            lb_edit.DisplayMember = cb_searchBy.SelectedItem.ToString();
        }

        private void lb_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand cmd;

            string sql = "Select * from dbo.[Table] where" +
                " [" + cb_searchBy.SelectedItem.ToString() + "] = '" + lb_edit.GetItemText(lb_edit.SelectedItem) + "'";

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);

                int result = cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tb_answer.Text = reader["Answer"].ToString();
                    tb_email.Text = reader["Email"].ToString();
                    tb_otherInfo.Text = reader["Other information"].ToString();
                    tb_password.Text = reader["Password"].ToString();
                    tb_phone.Text = reader["Phone"].ToString();
                    tb_question.Text = reader["Question"].ToString();
                    tb_siteName.Text = reader["Site name"].ToString();
                    tb_timeCreated.Text = reader["Time created"].ToString();
                    tb_username.Text = reader["Username"].ToString();
                    selectedAccID = reader["Id"].ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            if (lb_edit.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Notice!.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    SqlConnection connection;
                    SqlCommand cmd;

                    string sql = string.Format("UPDATE dbo.[Table] set [Site name] = '{1}', Username = '{2}'," +
                        "Password = '{3}', Email = '{4}', Phone = '{5}', Question = '{6}', Answer = '{7}'," +
                        "[Other information] = '{8}' where Id = '{0}'", selectedAccID, tb_siteName.Text, tb_username.Text,
                        tb_password.Text, tb_email.Text, int.Parse(tb_phone.Text), tb_question.Text, tb_answer.Text, tb_otherInfo.Text);

                    connection = new SqlConnection(connetionString);
                    try
                    {
                        connection.Open();
                        cmd = new SqlCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                        Debug.WriteLine("row " + selectedAccID + " changed in the database");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                    this.tableTableAdapter.Fill(this.accounts.Table);
                }
            }
        }

        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            if (lb_edit.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Alarm!.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //Debug.WriteLine("start index :" + lb_edit_selectedIndex);
                    SqlConnection connection;
                    SqlCommand cmd;

                    string sql = string.Format("delete from dbo.[Table] where Id = '" + selectedAccID + "'");

                    connection = new SqlConnection(connetionString);
                    try
                    {
                        connection.Open();
                        cmd = new SqlCommand(sql, connection);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                        Debug.WriteLine("row " + selectedAccID + " deleted in the database");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }

                    //lb_edit.SelectedIndex = lb_edit_selectedIndex - 1;
                    int lastSelectedIndex = lb_edit.SelectedIndex;

                    this.tableTableAdapter.Fill(this.accounts.Table);

                    lb_edit.Refresh();
                    lb_edit.SelectedIndex = lastSelectedIndex - 1;

                    Debug.WriteLine("" + lb_edit.SelectedIndex);
                }

                if (lb_edit.Items.Count == 0)
                {
                    tb_siteName.Text = ""; tb_username.Text = "";
                    tb_password.Text = ""; tb_email.Text = ""; tb_phone.Text = "";
                    tb_question.Text = ""; tb_answer.Text = ""; tb_otherInfo.Text = "";
                    tb_timeCreated.Text = "";
                }
            }
        }
    }
}
