
namespace Accounts_manager.UserControls
{
    partial class Main
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.lbl_date_created = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.tb_dateCreated = new System.Windows.Forms.TextBox();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_copy_control_txt = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_siteName = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_siteName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_other_info = new System.Windows.Forms.Label();
            this.tb_otherInfo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_main = new System.Windows.Forms.ListBox();
            this.lbl_viewBy = new System.Windows.Forms.Label();
            this.cb_searchBy = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.84802F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.15198F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.68805F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.31195F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 400);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_phone);
            this.panel3.Controls.Add(this.lbl_phone);
            this.panel3.Controls.Add(this.tb_question);
            this.panel3.Controls.Add(this.lbl_date_created);
            this.panel3.Controls.Add(this.lbl_question);
            this.panel3.Controls.Add(this.tb_dateCreated);
            this.panel3.Controls.Add(this.tb_answer);
            this.panel3.Controls.Add(this.lbl_answer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(226, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 188);
            this.panel3.TabIndex = 1;
            // 
            // tb_phone
            // 
            this.tb_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_phone.Location = new System.Drawing.Point(110, 47);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(96, 20);
            this.tb_phone.TabIndex = 11;
            this.tb_phone.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(12, 47);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 12;
            this.lbl_phone.Text = "Phone:";
            // 
            // tb_question
            // 
            this.tb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_question.Location = new System.Drawing.Point(110, 73);
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(96, 20);
            this.tb_question.TabIndex = 13;
            this.tb_question.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_date_created
            // 
            this.lbl_date_created.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date_created.AutoSize = true;
            this.lbl_date_created.Location = new System.Drawing.Point(12, 125);
            this.lbl_date_created.Name = "lbl_date_created";
            this.lbl_date_created.Size = new System.Drawing.Size(72, 13);
            this.lbl_date_created.TabIndex = 20;
            this.lbl_date_created.Text = "Date created:";
            // 
            // lbl_question
            // 
            this.lbl_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(12, 73);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(52, 13);
            this.lbl_question.TabIndex = 14;
            this.lbl_question.Text = "Question:";
            // 
            // tb_dateCreated
            // 
            this.tb_dateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_dateCreated.Location = new System.Drawing.Point(110, 125);
            this.tb_dateCreated.Name = "tb_dateCreated";
            this.tb_dateCreated.ReadOnly = true;
            this.tb_dateCreated.Size = new System.Drawing.Size(96, 20);
            this.tb_dateCreated.TabIndex = 19;
            this.tb_dateCreated.Click += new System.EventHandler(this.tbs_main);
            // 
            // tb_answer
            // 
            this.tb_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_answer.Location = new System.Drawing.Point(110, 99);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.ReadOnly = true;
            this.tb_answer.Size = new System.Drawing.Size(96, 20);
            this.tb_answer.TabIndex = 15;
            this.tb_answer.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_answer
            // 
            this.lbl_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(12, 99);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(45, 13);
            this.lbl_answer.TabIndex = 16;
            this.lbl_answer.Text = "Answer:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_copy_control_txt);
            this.panel4.Controls.Add(this.tb_password);
            this.panel4.Controls.Add(this.lbl_email);
            this.panel4.Controls.Add(this.tb_email);
            this.panel4.Controls.Add(this.lbl_password);
            this.panel4.Controls.Add(this.tb_siteName);
            this.panel4.Controls.Add(this.lbl_username);
            this.panel4.Controls.Add(this.tb_username);
            this.panel4.Controls.Add(this.lbl_siteName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 200);
            this.panel4.TabIndex = 2;
            // 
            // btn_copy_control_txt
            // 
            this.btn_copy_control_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_copy_control_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy_control_txt.FlatAppearance.BorderSize = 0;
            this.btn_copy_control_txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_copy_control_txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_copy_control_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy_control_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_copy_control_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_copy_control_txt.Image = ((System.Drawing.Image)(resources.GetObject("btn_copy_control_txt.Image")));
            this.btn_copy_control_txt.Location = new System.Drawing.Point(70, 131);
            this.btn_copy_control_txt.Name = "btn_copy_control_txt";
            this.btn_copy_control_txt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_copy_control_txt.Size = new System.Drawing.Size(150, 40);
            this.btn_copy_control_txt.TabIndex = 36;
            this.btn_copy_control_txt.Text = " Copy selected";
            this.btn_copy_control_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy_control_txt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_copy_control_txt.UseVisualStyleBackColor = false;
            this.btn_copy_control_txt.Click += new System.EventHandler(this.btn_copy_control_txt_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(104, 62);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.ReadOnly = true;
            this.tb_password.Size = new System.Drawing.Size(110, 20);
            this.tb_password.TabIndex = 7;
            this.tb_password.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(6, 91);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_email.Location = new System.Drawing.Point(104, 88);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(110, 20);
            this.tb_email.TabIndex = 9;
            this.tb_email.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(6, 65);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password:";
            // 
            // tb_siteName
            // 
            this.tb_siteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_siteName.Location = new System.Drawing.Point(104, 10);
            this.tb_siteName.Name = "tb_siteName";
            this.tb_siteName.ReadOnly = true;
            this.tb_siteName.Size = new System.Drawing.Size(110, 20);
            this.tb_siteName.TabIndex = 3;
            this.tb_siteName.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(6, 39);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Location = new System.Drawing.Point(104, 36);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(110, 20);
            this.tb_username.TabIndex = 5;
            this.tb_username.Click += new System.EventHandler(this.tbs_main);
            // 
            // lbl_siteName
            // 
            this.lbl_siteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_siteName.AutoSize = true;
            this.lbl_siteName.Location = new System.Drawing.Point(6, 13);
            this.lbl_siteName.Name = "lbl_siteName";
            this.lbl_siteName.Size = new System.Drawing.Size(57, 13);
            this.lbl_siteName.TabIndex = 4;
            this.lbl_siteName.Text = "Site name:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_other_info);
            this.panel5.Controls.Add(this.tb_otherInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(226, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 200);
            this.panel5.TabIndex = 3;
            // 
            // lbl_other_info
            // 
            this.lbl_other_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_other_info.AutoSize = true;
            this.lbl_other_info.Location = new System.Drawing.Point(12, 17);
            this.lbl_other_info.Name = "lbl_other_info";
            this.lbl_other_info.Size = new System.Drawing.Size(90, 13);
            this.lbl_other_info.TabIndex = 18;
            this.lbl_other_info.Text = "Other information:";
            // 
            // tb_otherInfo
            // 
            this.tb_otherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_otherInfo.Location = new System.Drawing.Point(110, 17);
            this.tb_otherInfo.Multiline = true;
            this.tb_otherInfo.Name = "tb_otherInfo";
            this.tb_otherInfo.ReadOnly = true;
            this.tb_otherInfo.Size = new System.Drawing.Size(96, 154);
            this.tb_otherInfo.TabIndex = 17;
            this.tb_otherInfo.Click += new System.EventHandler(this.tbs_main);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_main);
            this.panel1.Controls.Add(this.lbl_viewBy);
            this.panel1.Controls.Add(this.cb_searchBy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 188);
            this.panel1.TabIndex = 4;
            // 
            // lb_main
            // 
            this.lb_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_main.FormattingEnabled = true;
            this.lb_main.Location = new System.Drawing.Point(9, 50);
            this.lb_main.Name = "lb_main";
            this.lb_main.ScrollAlwaysVisible = true;
            this.lb_main.Size = new System.Drawing.Size(205, 95);
            this.lb_main.TabIndex = 0;
            this.lb_main.SelectedIndexChanged += new System.EventHandler(this.lb_main_SelectedIndexChanged);
            // 
            // lbl_viewBy
            // 
            this.lbl_viewBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_viewBy.AutoSize = true;
            this.lbl_viewBy.Location = new System.Drawing.Point(17, 14);
            this.lbl_viewBy.Name = "lbl_viewBy";
            this.lbl_viewBy.Size = new System.Drawing.Size(47, 13);
            this.lbl_viewBy.TabIndex = 2;
            this.lbl_viewBy.Text = "View by:";
            // 
            // cb_searchBy
            // 
            this.cb_searchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_searchBy.FormattingEnabled = true;
            this.cb_searchBy.Items.AddRange(new object[] {
            "Site Name",
            "Username",
            "Email",
            "Phone",
            "Question",
            "Answer",
            "Date created"});
            this.cb_searchBy.Location = new System.Drawing.Point(70, 11);
            this.cb_searchBy.Name = "cb_searchBy";
            this.cb_searchBy.Size = new System.Drawing.Size(144, 21);
            this.cb_searchBy.TabIndex = 1;
            this.cb_searchBy.SelectedIndexChanged += new System.EventHandler(this.cb_searchBy_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(448, 400);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(448, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label lbl_date_created;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox tb_dateCreated;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_siteName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_siteName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_other_info;
        private System.Windows.Forms.TextBox tb_otherInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lb_main;
        private System.Windows.Forms.Label lbl_viewBy;
        private System.Windows.Forms.ComboBox cb_searchBy;
        private System.Windows.Forms.Button btn_copy_control_txt;
    }
}
