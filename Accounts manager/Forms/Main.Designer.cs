namespace Accounts_manager
{
    partial class form_main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.lb_main = new System.Windows.Forms.ListBox();
            this.cb_searchBy = new System.Windows.Forms.ComboBox();
            this.lbl_viewBy = new System.Windows.Forms.Label();
            this.tb_siteName = new System.Windows.Forms.TextBox();
            this.lbl_siteName = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_other_info = new System.Windows.Forms.Label();
            this.tb_otherInfo = new System.Windows.Forms.TextBox();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.lbl_question = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lbl_date_created = new System.Windows.Forms.Label();
            this.tb_dateCreated = new System.Windows.Forms.TextBox();
            this.btn_copy_control_txt = new System.Windows.Forms.Button();
            this.panel_main_header = new System.Windows.Forms.Panel();
            this.lbl_main = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_main_header.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_main
            // 
            this.lb_main.FormattingEnabled = true;
            this.lb_main.Location = new System.Drawing.Point(15, 56);
            this.lb_main.Name = "lb_main";
            this.lb_main.ScrollAlwaysVisible = true;
            this.lb_main.Size = new System.Drawing.Size(295, 108);
            this.lb_main.TabIndex = 0;
            this.lb_main.SelectedIndexChanged += new System.EventHandler(this.lb_main_SelectedIndexChanged);
            // 
            // cb_searchBy
            // 
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
            this.cb_searchBy.Location = new System.Drawing.Point(88, 9);
            this.cb_searchBy.Name = "cb_searchBy";
            this.cb_searchBy.Size = new System.Drawing.Size(150, 21);
            this.cb_searchBy.TabIndex = 1;
            this.cb_searchBy.SelectedIndexChanged += new System.EventHandler(this.cb_searchBy_SelectedIndexChanged);
            // 
            // lbl_viewBy
            // 
            this.lbl_viewBy.AutoSize = true;
            this.lbl_viewBy.Location = new System.Drawing.Point(12, 12);
            this.lbl_viewBy.Name = "lbl_viewBy";
            this.lbl_viewBy.Size = new System.Drawing.Size(47, 13);
            this.lbl_viewBy.TabIndex = 2;
            this.lbl_viewBy.Text = "View by:";
            // 
            // tb_siteName
            // 
            this.tb_siteName.Location = new System.Drawing.Point(110, 189);
            this.tb_siteName.Name = "tb_siteName";
            this.tb_siteName.ReadOnly = true;
            this.tb_siteName.Size = new System.Drawing.Size(200, 20);
            this.tb_siteName.TabIndex = 3;
            this.tb_siteName.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_siteName
            // 
            this.lbl_siteName.AutoSize = true;
            this.lbl_siteName.Location = new System.Drawing.Point(12, 192);
            this.lbl_siteName.Name = "lbl_siteName";
            this.lbl_siteName.Size = new System.Drawing.Size(57, 13);
            this.lbl_siteName.TabIndex = 4;
            this.lbl_siteName.Text = "Site name:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 218);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(110, 215);
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = true;
            this.tb_username.Size = new System.Drawing.Size(200, 20);
            this.tb_username.TabIndex = 5;
            this.tb_username.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 244);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(110, 241);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '●';
            this.tb_password.ReadOnly = true;
            this.tb_password.Size = new System.Drawing.Size(200, 20);
            this.tb_password.TabIndex = 7;
            this.tb_password.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 270);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 10;
            this.lbl_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(110, 267);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(200, 20);
            this.tb_email.TabIndex = 9;
            this.tb_email.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_other_info
            // 
            this.lbl_other_info.AutoSize = true;
            this.lbl_other_info.Location = new System.Drawing.Point(326, 167);
            this.lbl_other_info.Name = "lbl_other_info";
            this.lbl_other_info.Size = new System.Drawing.Size(90, 13);
            this.lbl_other_info.TabIndex = 18;
            this.lbl_other_info.Text = "Other information:";
            // 
            // tb_otherInfo
            // 
            this.tb_otherInfo.Location = new System.Drawing.Point(424, 167);
            this.tb_otherInfo.Multiline = true;
            this.tb_otherInfo.Name = "tb_otherInfo";
            this.tb_otherInfo.ReadOnly = true;
            this.tb_otherInfo.Size = new System.Drawing.Size(200, 120);
            this.tb_otherInfo.TabIndex = 17;
            this.tb_otherInfo.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(326, 108);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(45, 13);
            this.lbl_answer.TabIndex = 16;
            this.lbl_answer.Text = "Answer:";
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(424, 108);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.ReadOnly = true;
            this.tb_answer.Size = new System.Drawing.Size(200, 20);
            this.tb_answer.TabIndex = 15;
            this.tb_answer.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(326, 82);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(52, 13);
            this.lbl_question.TabIndex = 14;
            this.lbl_question.Text = "Question:";
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(424, 82);
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(200, 20);
            this.tb_question.TabIndex = 13;
            this.tb_question.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(326, 56);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 12;
            this.lbl_phone.Text = "Phone:";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(424, 56);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ReadOnly = true;
            this.tb_phone.Size = new System.Drawing.Size(200, 20);
            this.tb_phone.TabIndex = 11;
            this.tb_phone.Click += new System.EventHandler(this.tb_selected_controls_Click);
            // 
            // lbl_date_created
            // 
            this.lbl_date_created.AutoSize = true;
            this.lbl_date_created.Location = new System.Drawing.Point(326, 134);
            this.lbl_date_created.Name = "lbl_date_created";
            this.lbl_date_created.Size = new System.Drawing.Size(72, 13);
            this.lbl_date_created.TabIndex = 20;
            this.lbl_date_created.Text = "Date created:";
            // 
            // tb_dateCreated
            // 
            this.tb_dateCreated.Location = new System.Drawing.Point(424, 134);
            this.tb_dateCreated.Name = "tb_dateCreated";
            this.tb_dateCreated.ReadOnly = true;
            this.tb_dateCreated.Size = new System.Drawing.Size(200, 20);
            this.tb_dateCreated.TabIndex = 19;
            this.tb_dateCreated.Click += new System.EventHandler(this.tb_selected_controls_Click);
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
            this.btn_copy_control_txt.Location = new System.Drawing.Point(248, 295);
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
            // panel_main_header
            // 
            this.panel_main_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.panel_main_header.Controls.Add(this.lbl_main);
            this.panel_main_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_main_header.Location = new System.Drawing.Point(0, 0);
            this.panel_main_header.Name = "panel_main_header";
            this.panel_main_header.Size = new System.Drawing.Size(432, 40);
            this.panel_main_header.TabIndex = 37;
            // 
            // lbl_main
            // 
            this.lbl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.lbl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_main.Location = new System.Drawing.Point(0, 0);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(432, 40);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "Main";
            this.lbl_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.Controls.Add(this.btn_copy_control_txt);
            this.panel_main.Controls.Add(this.lbl_viewBy);
            this.panel_main.Controls.Add(this.lbl_date_created);
            this.panel_main.Controls.Add(this.lb_main);
            this.panel_main.Controls.Add(this.tb_dateCreated);
            this.panel_main.Controls.Add(this.cb_searchBy);
            this.panel_main.Controls.Add(this.lbl_other_info);
            this.panel_main.Controls.Add(this.tb_siteName);
            this.panel_main.Controls.Add(this.tb_otherInfo);
            this.panel_main.Controls.Add(this.lbl_siteName);
            this.panel_main.Controls.Add(this.lbl_answer);
            this.panel_main.Controls.Add(this.tb_username);
            this.panel_main.Controls.Add(this.tb_answer);
            this.panel_main.Controls.Add(this.lbl_username);
            this.panel_main.Controls.Add(this.lbl_question);
            this.panel_main.Controls.Add(this.tb_password);
            this.panel_main.Controls.Add(this.tb_question);
            this.panel_main.Controls.Add(this.lbl_password);
            this.panel_main.Controls.Add(this.lbl_phone);
            this.panel_main.Controls.Add(this.tb_email);
            this.panel_main.Controls.Add(this.tb_phone);
            this.panel_main.Controls.Add(this.lbl_email);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 40);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(432, 321);
            this.panel_main.TabIndex = 38;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(432, 361);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_main_header);
            this.Name = "form_main";
            this.Text = "form_main";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.Resize += new System.EventHandler(this.form_main_Resize);
            this.panel_main_header.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_main;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.ComboBox cb_searchBy;
        private System.Windows.Forms.Label lbl_viewBy;
        private System.Windows.Forms.TextBox tb_siteName;
        private System.Windows.Forms.Label lbl_siteName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_other_info;
        private System.Windows.Forms.TextBox tb_otherInfo;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lbl_date_created;
        private System.Windows.Forms.TextBox tb_dateCreated;
        private System.Windows.Forms.Button btn_copy_control_txt;
        private System.Windows.Forms.Panel panel_main_header;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Panel panel_main;
    }
}