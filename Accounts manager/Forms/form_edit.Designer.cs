namespace Accounts_manager
{
    partial class form_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_edit));
            this.panel_edit = new System.Windows.Forms.Panel();
            this.lbl_viewBy = new System.Windows.Forms.Label();
            this.lbl_date_created = new System.Windows.Forms.Label();
            this.lb_edit = new System.Windows.Forms.ListBox();
            this.tb_timeCreated = new System.Windows.Forms.TextBox();
            this.cb_searchBy = new System.Windows.Forms.ComboBox();
            this.lbl_other_info = new System.Windows.Forms.Label();
            this.tb_siteName = new System.Windows.Forms.TextBox();
            this.tb_otherInfo = new System.Windows.Forms.TextBox();
            this.lbl_siteName = new System.Windows.Forms.Label();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_save_changes = new System.Windows.Forms.Button();
            this.panel_edit_header = new System.Windows.Forms.Panel();
            this.lbl_edit = new System.Windows.Forms.Label();
            this.accounts = new Accounts_manager.Accounts();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Accounts_manager.AccountsTableAdapters.TableTableAdapter();
            this.btn_deleteAcc = new System.Windows.Forms.Button();
            this.panel_edit.SuspendLayout();
            this.panel_edit_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_edit
            // 
            this.panel_edit.AutoScroll = true;
            this.panel_edit.Controls.Add(this.btn_deleteAcc);
            this.panel_edit.Controls.Add(this.lbl_viewBy);
            this.panel_edit.Controls.Add(this.lbl_date_created);
            this.panel_edit.Controls.Add(this.lb_edit);
            this.panel_edit.Controls.Add(this.tb_timeCreated);
            this.panel_edit.Controls.Add(this.cb_searchBy);
            this.panel_edit.Controls.Add(this.lbl_other_info);
            this.panel_edit.Controls.Add(this.tb_siteName);
            this.panel_edit.Controls.Add(this.tb_otherInfo);
            this.panel_edit.Controls.Add(this.lbl_siteName);
            this.panel_edit.Controls.Add(this.lbl_answer);
            this.panel_edit.Controls.Add(this.tb_username);
            this.panel_edit.Controls.Add(this.tb_answer);
            this.panel_edit.Controls.Add(this.lbl_username);
            this.panel_edit.Controls.Add(this.lbl_question);
            this.panel_edit.Controls.Add(this.tb_password);
            this.panel_edit.Controls.Add(this.tb_question);
            this.panel_edit.Controls.Add(this.lbl_password);
            this.panel_edit.Controls.Add(this.lbl_phone);
            this.panel_edit.Controls.Add(this.tb_email);
            this.panel_edit.Controls.Add(this.tb_phone);
            this.panel_edit.Controls.Add(this.lbl_email);
            this.panel_edit.Controls.Add(this.btn_save_changes);
            this.panel_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_edit.Location = new System.Drawing.Point(0, 40);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(432, 321);
            this.panel_edit.TabIndex = 40;
            // 
            // lbl_viewBy
            // 
            this.lbl_viewBy.AutoSize = true;
            this.lbl_viewBy.Location = new System.Drawing.Point(12, 14);
            this.lbl_viewBy.Name = "lbl_viewBy";
            this.lbl_viewBy.Size = new System.Drawing.Size(47, 13);
            this.lbl_viewBy.TabIndex = 39;
            this.lbl_viewBy.Text = "View by:";
            // 
            // lbl_date_created
            // 
            this.lbl_date_created.AutoSize = true;
            this.lbl_date_created.Location = new System.Drawing.Point(326, 136);
            this.lbl_date_created.Name = "lbl_date_created";
            this.lbl_date_created.Size = new System.Drawing.Size(72, 13);
            this.lbl_date_created.TabIndex = 57;
            this.lbl_date_created.Text = "Date created:";
            // 
            // lb_edit
            // 
            this.lb_edit.FormattingEnabled = true;
            this.lb_edit.Location = new System.Drawing.Point(15, 58);
            this.lb_edit.Name = "lb_edit";
            this.lb_edit.ScrollAlwaysVisible = true;
            this.lb_edit.Size = new System.Drawing.Size(295, 108);
            this.lb_edit.Sorted = true;
            this.lb_edit.TabIndex = 37;
            this.lb_edit.SelectedIndexChanged += new System.EventHandler(this.lb_edit_SelectedIndexChanged);
            // 
            // tb_timeCreated
            // 
            this.tb_timeCreated.Location = new System.Drawing.Point(424, 136);
            this.tb_timeCreated.Name = "tb_timeCreated";
            this.tb_timeCreated.ReadOnly = true;
            this.tb_timeCreated.Size = new System.Drawing.Size(200, 20);
            this.tb_timeCreated.TabIndex = 56;
            // 
            // cb_searchBy
            // 
            this.cb_searchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_searchBy.FormattingEnabled = true;
            this.cb_searchBy.Items.AddRange(new object[] {
            "Answer",
            "Email",
            "Other information",
            "Phone",
            "Question",
            "Site name",
            "Username"});
            this.cb_searchBy.Location = new System.Drawing.Point(88, 11);
            this.cb_searchBy.Name = "cb_searchBy";
            this.cb_searchBy.Size = new System.Drawing.Size(150, 21);
            this.cb_searchBy.Sorted = true;
            this.cb_searchBy.TabIndex = 38;
            this.cb_searchBy.SelectedIndexChanged += new System.EventHandler(this.cb_searchBy_SelectedIndexChanged);
            // 
            // lbl_other_info
            // 
            this.lbl_other_info.AutoSize = true;
            this.lbl_other_info.Location = new System.Drawing.Point(326, 169);
            this.lbl_other_info.Name = "lbl_other_info";
            this.lbl_other_info.Size = new System.Drawing.Size(90, 13);
            this.lbl_other_info.TabIndex = 55;
            this.lbl_other_info.Text = "Other information:";
            // 
            // tb_siteName
            // 
            this.tb_siteName.Location = new System.Drawing.Point(110, 191);
            this.tb_siteName.Name = "tb_siteName";
            this.tb_siteName.Size = new System.Drawing.Size(200, 20);
            this.tb_siteName.TabIndex = 40;
            // 
            // tb_otherInfo
            // 
            this.tb_otherInfo.Location = new System.Drawing.Point(424, 169);
            this.tb_otherInfo.Multiline = true;
            this.tb_otherInfo.Name = "tb_otherInfo";
            this.tb_otherInfo.Size = new System.Drawing.Size(200, 120);
            this.tb_otherInfo.TabIndex = 54;
            // 
            // lbl_siteName
            // 
            this.lbl_siteName.AutoSize = true;
            this.lbl_siteName.Location = new System.Drawing.Point(12, 194);
            this.lbl_siteName.Name = "lbl_siteName";
            this.lbl_siteName.Size = new System.Drawing.Size(57, 13);
            this.lbl_siteName.TabIndex = 41;
            this.lbl_siteName.Text = "Site name:";
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(326, 110);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(45, 13);
            this.lbl_answer.TabIndex = 53;
            this.lbl_answer.Text = "Answer:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(110, 217);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(200, 20);
            this.tb_username.TabIndex = 42;
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(424, 110);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(200, 20);
            this.tb_answer.TabIndex = 52;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(12, 220);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 43;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(326, 84);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(52, 13);
            this.lbl_question.TabIndex = 51;
            this.lbl_question.Text = "Question:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(110, 243);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(200, 20);
            this.tb_password.TabIndex = 44;
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(424, 84);
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(200, 20);
            this.tb_question.TabIndex = 50;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 246);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 45;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(326, 58);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 49;
            this.lbl_phone.Text = "Phone:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(110, 269);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 20);
            this.tb_email.TabIndex = 46;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(424, 58);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(200, 20);
            this.tb_phone.TabIndex = 48;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 272);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 47;
            this.lbl_email.Text = "Email:";
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_save_changes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_changes.FlatAppearance.BorderSize = 0;
            this.btn_save_changes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_save_changes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_save_changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_changes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_save_changes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save_changes.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_changes.Image")));
            this.btn_save_changes.Location = new System.Drawing.Point(228, 295);
            this.btn_save_changes.Name = "btn_save_changes";
            this.btn_save_changes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_save_changes.Size = new System.Drawing.Size(150, 40);
            this.btn_save_changes.TabIndex = 36;
            this.btn_save_changes.Text = " Save changes";
            this.btn_save_changes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_changes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save_changes.UseVisualStyleBackColor = false;
            this.btn_save_changes.Click += new System.EventHandler(this.btn_save_changes_Click);
            // 
            // panel_edit_header
            // 
            this.panel_edit_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.panel_edit_header.Controls.Add(this.lbl_edit);
            this.panel_edit_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_edit_header.Location = new System.Drawing.Point(0, 0);
            this.panel_edit_header.Name = "panel_edit_header";
            this.panel_edit_header.Size = new System.Drawing.Size(432, 40);
            this.panel_edit_header.TabIndex = 39;
            // 
            // lbl_edit
            // 
            this.lbl_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.lbl_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit.Location = new System.Drawing.Point(0, 0);
            this.lbl_edit.Name = "lbl_edit";
            this.lbl_edit.Size = new System.Drawing.Size(432, 40);
            this.lbl_edit.TabIndex = 0;
            this.lbl_edit.Text = "Edit";
            this.lbl_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accounts
            // 
            this.accounts.DataSetName = "Accounts";
            this.accounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.accounts;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_deleteAcc
            // 
            this.btn_deleteAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_deleteAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteAcc.FlatAppearance.BorderSize = 0;
            this.btn_deleteAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_deleteAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_deleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAcc.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_deleteAcc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteAcc.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteAcc.Image")));
            this.btn_deleteAcc.Location = new System.Drawing.Point(397, 295);
            this.btn_deleteAcc.Name = "btn_deleteAcc";
            this.btn_deleteAcc.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_deleteAcc.Size = new System.Drawing.Size(150, 40);
            this.btn_deleteAcc.TabIndex = 58;
            this.btn_deleteAcc.Text = " Delete account";
            this.btn_deleteAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteAcc.UseVisualStyleBackColor = false;
            this.btn_deleteAcc.Click += new System.EventHandler(this.btn_deleteAcc_Click);
            // 
            // form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(432, 361);
            this.Controls.Add(this.panel_edit);
            this.Controls.Add(this.panel_edit_header);
            this.Name = "form_edit";
            this.Text = "form_edit";
            this.Load += new System.EventHandler(this.form_edit_Load);
            this.Resize += new System.EventHandler(this.form_edit_Resize);
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.panel_edit_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Button btn_save_changes;
        private System.Windows.Forms.Panel panel_edit_header;
        private System.Windows.Forms.Label lbl_edit;
        private System.Windows.Forms.Label lbl_viewBy;
        private System.Windows.Forms.Label lbl_date_created;
        private System.Windows.Forms.ListBox lb_edit;
        private System.Windows.Forms.TextBox tb_timeCreated;
        private System.Windows.Forms.ComboBox cb_searchBy;
        private System.Windows.Forms.Label lbl_other_info;
        private System.Windows.Forms.TextBox tb_siteName;
        private System.Windows.Forms.TextBox tb_otherInfo;
        private System.Windows.Forms.Label lbl_siteName;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lbl_email;
        private Accounts accounts;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AccountsTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button btn_deleteAcc;
    }
}