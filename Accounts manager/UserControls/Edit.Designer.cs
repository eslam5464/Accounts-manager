
namespace Accounts_manager.UserControls
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.btn_deleteAcc = new System.Windows.Forms.Button();
            this.lbl_viewBy = new System.Windows.Forms.Label();
            this.lbl_date_created = new System.Windows.Forms.Label();
            this.lb_edit = new System.Windows.Forms.ListBox();
            this.tb_dateCreated = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deleteAcc
            // 
            this.btn_deleteAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_deleteAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteAcc.FlatAppearance.BorderSize = 0;
            this.btn_deleteAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_deleteAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_deleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteAcc.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_deleteAcc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteAcc.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteAcc.Image")));
            this.btn_deleteAcc.Location = new System.Drawing.Point(66, 141);
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
            // lbl_viewBy
            // 
            this.lbl_viewBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_viewBy.AutoSize = true;
            this.lbl_viewBy.Location = new System.Drawing.Point(3, 10);
            this.lbl_viewBy.Name = "lbl_viewBy";
            this.lbl_viewBy.Size = new System.Drawing.Size(47, 13);
            this.lbl_viewBy.TabIndex = 39;
            this.lbl_viewBy.Text = "View by:";
            // 
            // lbl_date_created
            // 
            this.lbl_date_created.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date_created.AutoSize = true;
            this.lbl_date_created.Location = new System.Drawing.Point(3, 93);
            this.lbl_date_created.Name = "lbl_date_created";
            this.lbl_date_created.Size = new System.Drawing.Size(72, 13);
            this.lbl_date_created.TabIndex = 57;
            this.lbl_date_created.Text = "Date created:";
            // 
            // lb_edit
            // 
            this.lb_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_edit.FormattingEnabled = true;
            this.lb_edit.Location = new System.Drawing.Point(3, 38);
            this.lb_edit.Name = "lb_edit";
            this.lb_edit.ScrollAlwaysVisible = true;
            this.lb_edit.Size = new System.Drawing.Size(211, 147);
            this.lb_edit.TabIndex = 37;
            this.lb_edit.SelectedIndexChanged += new System.EventHandler(this.lb_edit_SelectedIndexChanged);
            // 
            // tb_dateCreated
            // 
            this.tb_dateCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_dateCreated.Location = new System.Drawing.Point(101, 93);
            this.tb_dateCreated.Name = "tb_dateCreated";
            this.tb_dateCreated.ReadOnly = true;
            this.tb_dateCreated.Size = new System.Drawing.Size(115, 20);
            this.tb_dateCreated.TabIndex = 56;
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
            this.cb_searchBy.Location = new System.Drawing.Point(79, 7);
            this.cb_searchBy.Name = "cb_searchBy";
            this.cb_searchBy.Size = new System.Drawing.Size(135, 21);
            this.cb_searchBy.TabIndex = 38;
            // 
            // lbl_other_info
            // 
            this.lbl_other_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_other_info.AutoSize = true;
            this.lbl_other_info.Location = new System.Drawing.Point(3, 0);
            this.lbl_other_info.Name = "lbl_other_info";
            this.lbl_other_info.Size = new System.Drawing.Size(90, 13);
            this.lbl_other_info.TabIndex = 55;
            this.lbl_other_info.Text = "Other information:";
            // 
            // tb_siteName
            // 
            this.tb_siteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_siteName.Location = new System.Drawing.Point(101, 7);
            this.tb_siteName.Name = "tb_siteName";
            this.tb_siteName.Size = new System.Drawing.Size(113, 20);
            this.tb_siteName.TabIndex = 40;
            // 
            // tb_otherInfo
            // 
            this.tb_otherInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_otherInfo.Location = new System.Drawing.Point(101, -3);
            this.tb_otherInfo.Multiline = true;
            this.tb_otherInfo.Name = "tb_otherInfo";
            this.tb_otherInfo.Size = new System.Drawing.Size(115, 120);
            this.tb_otherInfo.TabIndex = 54;
            // 
            // lbl_siteName
            // 
            this.lbl_siteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_siteName.AutoSize = true;
            this.lbl_siteName.Location = new System.Drawing.Point(3, 10);
            this.lbl_siteName.Name = "lbl_siteName";
            this.lbl_siteName.Size = new System.Drawing.Size(57, 13);
            this.lbl_siteName.TabIndex = 41;
            this.lbl_siteName.Text = "Site name:";
            // 
            // lbl_answer
            // 
            this.lbl_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(3, 67);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(45, 13);
            this.lbl_answer.TabIndex = 53;
            this.lbl_answer.Text = "Answer:";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Location = new System.Drawing.Point(101, 33);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(113, 20);
            this.tb_username.TabIndex = 42;
            // 
            // tb_answer
            // 
            this.tb_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_answer.Location = new System.Drawing.Point(101, 67);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(115, 20);
            this.tb_answer.TabIndex = 52;
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(3, 36);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 43;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_question
            // 
            this.lbl_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(3, 41);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(52, 13);
            this.lbl_question.TabIndex = 51;
            this.lbl_question.Text = "Question:";
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(101, 59);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(113, 20);
            this.tb_password.TabIndex = 44;
            // 
            // tb_question
            // 
            this.tb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_question.Location = new System.Drawing.Point(101, 41);
            this.tb_question.Name = "tb_question";
            this.tb_question.Size = new System.Drawing.Size(115, 20);
            this.tb_question.TabIndex = 50;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(3, 62);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 45;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(3, 15);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 49;
            this.lbl_phone.Text = "Phone:";
            // 
            // tb_email
            // 
            this.tb_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_email.Location = new System.Drawing.Point(101, 85);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(113, 20);
            this.tb_email.TabIndex = 46;
            // 
            // tb_phone
            // 
            this.tb_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_phone.Location = new System.Drawing.Point(101, 15);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(115, 20);
            this.tb_phone.TabIndex = 48;
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(3, 88);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 47;
            this.lbl_email.Text = "Email:";
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_changes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_save_changes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_changes.FlatAppearance.BorderSize = 0;
            this.btn_save_changes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_save_changes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_save_changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_changes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_save_changes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save_changes.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_changes.Image")));
            this.btn_save_changes.Location = new System.Drawing.Point(64, 141);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_viewBy);
            this.panel1.Controls.Add(this.cb_searchBy);
            this.panel1.Controls.Add(this.lb_edit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 188);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_deleteAcc);
            this.panel5.Controls.Add(this.lbl_other_info);
            this.panel5.Controls.Add(this.tb_otherInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(226, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 200);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_siteName);
            this.panel4.Controls.Add(this.btn_save_changes);
            this.panel4.Controls.Add(this.lbl_email);
            this.panel4.Controls.Add(this.tb_email);
            this.panel4.Controls.Add(this.lbl_password);
            this.panel4.Controls.Add(this.tb_siteName);
            this.panel4.Controls.Add(this.tb_password);
            this.panel4.Controls.Add(this.lbl_username);
            this.panel4.Controls.Add(this.tb_username);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 200);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_phone);
            this.panel3.Controls.Add(this.lbl_date_created);
            this.panel3.Controls.Add(this.tb_phone);
            this.panel3.Controls.Add(this.tb_dateCreated);
            this.panel3.Controls.Add(this.tb_question);
            this.panel3.Controls.Add(this.lbl_question);
            this.panel3.Controls.Add(this.tb_answer);
            this.panel3.Controls.Add(this.lbl_answer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(226, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 188);
            this.panel3.TabIndex = 1;
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
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(448, 400);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(448, 400);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_deleteAcc;
        private System.Windows.Forms.Label lbl_viewBy;
        private System.Windows.Forms.Label lbl_date_created;
        private System.Windows.Forms.ListBox lb_edit;
        private System.Windows.Forms.TextBox tb_dateCreated;
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
        private System.Windows.Forms.Button btn_save_changes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
