using System.Drawing;
using System.Windows.Forms;

namespace MyBank.Admin_View
{
    partial class AdministratorRightsForm
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
            this.rightsDataGrid = new System.Windows.Forms.DataGridView();
            this.BTN_Admin = new System.Windows.Forms.Button();
            this.BTN_Manager = new System.Windows.Forms.Button();
            this.BTN_User = new System.Windows.Forms.Button();
            this.TXB_Delete = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.DTC = new System.Windows.Forms.Button();
            this.MyBank = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rightsDataGrid
            // 
            this.rightsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightsDataGrid.Location = new System.Drawing.Point(359, 90);
            this.rightsDataGrid.Name = "rightsDataGrid";
            this.rightsDataGrid.RowTemplate.Height = 25;
            this.rightsDataGrid.Size = new System.Drawing.Size(208, 497);
            this.rightsDataGrid.TabIndex = 0;
            // 
            // BTN_Admin
            // 
            this.BTN_Admin.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Admin.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Admin.Location = new System.Drawing.Point(680, 286);
            this.BTN_Admin.Name = "BTN_Admin";
            this.BTN_Admin.Size = new System.Drawing.Size(363, 22);
            this.BTN_Admin.TabIndex = 1;
            this.BTN_Admin.Text = "Admin";
            this.BTN_Admin.UseVisualStyleBackColor = true;
            this.BTN_Admin.Click += new System.EventHandler(this.BTN_GiveAdmin_Click);
            // 
            // BTN_Manager
            // 
            this.BTN_Manager.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Manager.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Manager.Location = new System.Drawing.Point(680, 311);
            this.BTN_Manager.Name = "BTN_Manager";
            this.BTN_Manager.Size = new System.Drawing.Size(363, 22);
            this.BTN_Manager.TabIndex = 2;
            this.BTN_Manager.Text = "Manager";
            this.BTN_Manager.UseVisualStyleBackColor = true;
            this.BTN_Manager.Click += new System.EventHandler(this.BTN_GiveManager_Click);
            // 
            // BTN_User
            // 
            this.BTN_User.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_User.ForeColor = System.Drawing.Color.Lime;
            this.BTN_User.Location = new System.Drawing.Point(680, 336);
            this.BTN_User.Name = "BTN_User";
            this.BTN_User.Size = new System.Drawing.Size(363, 22);
            this.BTN_User.TabIndex = 3;
            this.BTN_User.Text = "User";
            this.BTN_User.UseVisualStyleBackColor = true;
            this.BTN_User.Click += new System.EventHandler(this.BTN_GiveUser_Click);
            // 
            // TXB_Delete
            // 
            this.TXB_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.TXB_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TXB_Delete.ForeColor = System.Drawing.Color.Lime;
            this.TXB_Delete.Location = new System.Drawing.Point(680, 361);
            this.TXB_Delete.Name = "TXB_Delete";
            this.TXB_Delete.Size = new System.Drawing.Size(363, 22);
            this.TXB_Delete.TabIndex = 4;
            this.TXB_Delete.Text = "Delete Account";
            this.TXB_Delete.UseVisualStyleBackColor = true;
            this.TXB_Delete.Click += new System.EventHandler(this.TXB_Delete_Click);
            // 
            // LogOut
            // 
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.Color.Lime;
            this.LogOut.Location = new System.Drawing.Point(1173, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(64, 29);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // DTC
            // 
            this.DTC.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.DTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DTC.ForeColor = System.Drawing.Color.Lime;
            this.DTC.Location = new System.Drawing.Point(1101, 627);
            this.DTC.Name = "DTC";
            this.DTC.Size = new System.Drawing.Size(139, 27);
            this.DTC.TabIndex = 6;
            this.DTC.Text = "Deposit Type Control";
            this.DTC.UseVisualStyleBackColor = true;
            this.DTC.Click += new System.EventHandler(this.DTC_Click);
            // 
            // MyBank
            // 
            this.MyBank.AutoSize = true;
            this.MyBank.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.MyBank.ForeColor = System.Drawing.Color.Lime;
            this.MyBank.Location = new System.Drawing.Point(3, 3);
            this.MyBank.Name = "MyBank";
            this.MyBank.Size = new System.Drawing.Size(273, 89);
            this.MyBank.TabIndex = 10;
            this.MyBank.Text = "MyBank";
            // 
            // AdministratorRightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.DTC);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.TXB_Delete);
            this.Controls.Add(this.BTN_User);
            this.Controls.Add(this.BTN_Manager);
            this.Controls.Add(this.BTN_Admin);
            this.Controls.Add(this.rightsDataGrid);
            this.Name = "AdministratorRightsForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.Load += new System.EventHandler(this.AdministratorRightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView rightsDataGrid;
        private Button BTN_Admin;
        private Button BTN_Manager;
        private Button BTN_User;
        private Button TXB_Delete;
        private Button LogOut;
        private Button DTC;
        private Label MyBank;
    }
}
