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
using System.Threading;

namespace Accounts_manager
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\Accounts.mdf;Integrated Security=True";
        private Control selectedControl = null, prevSelectedControl = null;


        private void form_main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accounts.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.accounts.Table);
            lbl_main.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_main_header.Height = Height / 15;
        }

        private void cb_searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_main.DataSource = tableBindingSource;
            lb_main.DisplayMember = cb_searchBy.SelectedItem.ToString();
        }

        private void lb_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand cmd;

            string sql = "Select * from dbo.[Table] where" +
                " [" + cb_searchBy.SelectedItem.ToString() + "] = '" + lb_main.GetItemText(lb_main.SelectedItem) + "'";

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
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btn_copy_control_txt_Click(object sender, EventArgs e)
        {
            if (selectedControl != null)
                Clipboard.SetText(selectedControl.Text);
        }

        private void form_main_Resize(object sender, EventArgs e)
        {
            lbl_main.Font = new Font("Microsoft Sans Serif", Height / 30, FontStyle.Regular);
            panel_main_header.Height = Height / 15;
        }

        private void tb_selected_controls_Click(object sender, EventArgs e)
        {
            prevSelectedControl = selectedControl;
            selectedControl = (Control)sender;

            if (prevSelectedControl != null)
                prevSelectedControl.BackColor = Color.Empty;

            if (selectedControl != null)
                selectedControl.BackColor = Color.SkyBlue;
        }
    }
}
