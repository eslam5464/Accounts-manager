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
        
        private Control selectedControl = null, prevSelectedControl = null;

        private void form_main_Load(object sender, EventArgs e)
        {
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
