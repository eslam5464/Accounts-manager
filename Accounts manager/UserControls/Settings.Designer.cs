
namespace Accounts_manager.UserControls
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_export_csv = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_import_csv = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_export_csv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(92, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 48);
            this.panel1.TabIndex = 38;
            // 
            // btn_export_csv
            // 
            this.btn_export_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_export_csv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_export_csv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_export_csv.FlatAppearance.BorderSize = 0;
            this.btn_export_csv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_export_csv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_export_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export_csv.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_export_csv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_export_csv.Image = ((System.Drawing.Image)(resources.GetObject("btn_export_csv.Image")));
            this.btn_export_csv.Location = new System.Drawing.Point(85, 3);
            this.btn_export_csv.Name = "btn_export_csv";
            this.btn_export_csv.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_export_csv.Size = new System.Drawing.Size(80, 40);
            this.btn_export_csv.TabIndex = 37;
            this.btn_export_csv.Text = " CSV";
            this.btn_export_csv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export_csv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_export_csv.UseVisualStyleBackColor = false;
            this.btn_export_csv.Click += new System.EventHandler(this.btn_export_csv_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_phone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 48);
            this.panel2.TabIndex = 39;
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(39, 16);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(40, 13);
            this.lbl_phone.TabIndex = 13;
            this.lbl_phone.Text = "Export:";
            // 
            // btn_import_csv
            // 
            this.btn_import_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_import_csv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(57)))));
            this.btn_import_csv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_import_csv.FlatAppearance.BorderSize = 0;
            this.btn_import_csv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(42)))), ((int)(((byte)(101)))));
            this.btn_import_csv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(152)))));
            this.btn_import_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import_csv.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_import_csv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_import_csv.Image = ((System.Drawing.Image)(resources.GetObject("btn_import_csv.Image")));
            this.btn_import_csv.Location = new System.Drawing.Point(85, 3);
            this.btn_import_csv.Name = "btn_import_csv";
            this.btn_import_csv.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_import_csv.Size = new System.Drawing.Size(80, 40);
            this.btn_import_csv.TabIndex = 40;
            this.btn_import_csv.Text = " CSV";
            this.btn_import_csv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_import_csv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_import_csv.UseVisualStyleBackColor = false;
            this.btn_import_csv.Click += new System.EventHandler(this.btn_import_csv_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_import_csv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(92, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 48);
            this.panel3.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Import:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 48);
            this.panel4.TabIndex = 42;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(448, 400);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(448, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_export_csv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_import_csv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}
