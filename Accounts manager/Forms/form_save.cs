using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts_manager
{
    public partial class form_save : Form
    {
        private string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\Accounts.mdf;Integrated Security=True";

        public form_save()
        {
            InitializeComponent();
            lbl_save.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_save_header.Height = Height / 15;
        }

        private void form_save_Resize(object sender, EventArgs e)
        {
            lbl_save.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_save_header.Height = Height / 15;
        }

        private void form_save_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_addData_Click(object sender, EventArgs e)
        {
            if (tb_save_siteName.Text != "")
            {
                SqlConnection connection;
                SqlCommand cmd;
                string sql = string.Format("insert into dbo.[Table]([Site name], Username, Password, Email, Phone, Question, Answer, [Other information], [Time created])" +
                    " VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', GETDATE())", tb_save_siteName.Text, tb_save_username.Text,
                    tb_save_password.Text, tb_save_email.Text, tb_save_phone.Text, tb_save_question.Text, tb_save_answer.Text, tb_save_otherInfo.Text);

                connection = new SqlConnection(connetionString);
                try
                {
                    connection.Open();
                    cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    Debug.WriteLine("ExecuteNonQuery in SqlCommand executed!!" + string.Format("\nsite:{0}\nun:{1}\npw:{2}\nemail:{3}\np:{4}\nq:{5}\nans:{6}\ninfo:{7}\n----",
                        tb_save_siteName.Text, tb_save_username.Text, tb_save_password.Text, tb_save_email.Text, tb_save_phone.Text,
                        tb_save_question.Text, tb_save_answer.Text, tb_save_otherInfo.Text));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                tb_save_siteName.BackColor = Color.Red;
                MessageBox.Show("Site name text box shouldn't be empty", "Error!!...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_clearTB_Click(object sender, EventArgs e)
        {
            tb_save_answer.Text = "";
            tb_save_email.Text = "";
            tb_save_otherInfo.Text = "";
            tb_save_password.Text = "";
            tb_save_phone.Text = "";
            tb_save_question.Text = "";
            tb_save_siteName.Text = "";
            tb_save_username.Text = "";
        }

        private void tb_save_siteName_Enter(object sender, EventArgs e)
        {
            tb_save_siteName.BackColor = DefaultBackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            SqlConnection connection;
            SqlCommand cmd;
            connection = new SqlConnection(connetionString);
            string sql = "insert into dbo.[Table]([Site name], Username, Password, Email, Phone, Question, Answer, [Other information], [Time created])" +
                " VALUES( 'site " + r.Next() + "', 'user " + r.Next() + "', 'pw " + r.Next() + "', 'email " + r.Next() + "', " + r.Next() +
                ", 'question " + r.Next() + "', 'test " + r.Next() + "', 'test " + r.Next() + "', getdate())";

            try
            {
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                int x = cmd.ExecuteNonQuery();
                cmd.Dispose();

                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void tb_save_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
