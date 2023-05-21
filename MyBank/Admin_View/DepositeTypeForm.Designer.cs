using System.Drawing;
using System.Windows.Forms;

namespace MyBank.Admin_View
{
    partial class DepositeTypeForm
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
            this.components = new System.ComponentModel.Container();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.TXB_DepositeRate = new System.Windows.Forms.TextBox();
            this.TXB_Currency = new System.Windows.Forms.TextBox();
            this.depositDataGridView = new System.Windows.Forms.DataGridView();
            this.LogOut = new System.Windows.Forms.Button();
            this.ARC = new System.Windows.Forms.Button();
            this.MyBank = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositeTypeRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositeTypeRepositoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.depositeTypeRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Create
            // 
            this.BTN_Create.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Create.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Create.Location = new System.Drawing.Point(808, 373);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(331, 22);
            this.BTN_Create.TabIndex = 0;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Delete.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Delete.Location = new System.Drawing.Point(808, 398);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(331, 22);
            this.BTN_Delete.TabIndex = 1;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Update.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Update.Location = new System.Drawing.Point(808, 423);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(331, 22);
            this.BTN_Update.TabIndex = 2;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(808, 228);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(331, 20);
            this.TXB_Name.TabIndex = 4;
            // 
            // TXB_DepositeRate
            // 
            this.TXB_DepositeRate.Location = new System.Drawing.Point(808, 282);
            this.TXB_DepositeRate.Name = "TXB_DepositeRate";
            this.TXB_DepositeRate.Size = new System.Drawing.Size(331, 20);
            this.TXB_DepositeRate.TabIndex = 5;
            // 
            // TXB_Currency
            // 
            this.TXB_Currency.Location = new System.Drawing.Point(808, 333);
            this.TXB_Currency.Name = "TXB_Currency";
            this.TXB_Currency.Size = new System.Drawing.Size(331, 20);
            this.TXB_Currency.TabIndex = 6;
            // 
            // depositDataGridView
            // 
            this.depositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositDataGridView.Location = new System.Drawing.Point(288, 108);
            this.depositDataGridView.Name = "depositDataGridView";
            this.depositDataGridView.RowTemplate.Height = 25;
            this.depositDataGridView.Size = new System.Drawing.Size(390, 465);
            this.depositDataGridView.TabIndex = 7;
            this.depositDataGridView.SelectionChanged += new System.EventHandler(this.SelUpd);
            // 
            // LogOut
            // 
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.Color.Lime;
            this.LogOut.Location = new System.Drawing.Point(1173, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(64, 25);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ARC
            // 
            this.ARC.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.ARC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARC.ForeColor = System.Drawing.Color.Lime;
            this.ARC.Location = new System.Drawing.Point(1092, 627);
            this.ARC.Name = "ARC";
            this.ARC.Size = new System.Drawing.Size(145, 27);
            this.ARC.TabIndex = 9;
            this.ARC.Text = "Admin Rights Control";
            this.ARC.UseVisualStyleBackColor = true;
            this.ARC.Click += new System.EventHandler(this.ARC_Click);
            // 
            // MyBank
            // 
            this.MyBank.AutoSize = true;
            this.MyBank.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.MyBank.ForeColor = System.Drawing.Color.Lime;
            this.MyBank.Location = new System.Drawing.Point(3, 5);
            this.MyBank.Name = "MyBank";
            this.MyBank.Size = new System.Drawing.Size(273, 89);
            this.MyBank.TabIndex = 10;
            this.MyBank.Text = "MyBank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(805, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(805, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Deposit Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(805, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // depositeTypeRepositoryBindingSource
            // 
            this.depositeTypeRepositoryBindingSource.DataSource = typeof(MyBank.Repository.DepositeTypeRepository);
            // 
            // depositeTypeRepositoryBindingSource2
            // 
            this.depositeTypeRepositoryBindingSource2.DataSource = typeof(MyBank.Repository.DepositeTypeRepository);
            // 
            // depositeTypeRepositoryBindingSource1
            // 
            this.depositeTypeRepositoryBindingSource1.DataSource = typeof(MyBank.Repository.DepositeTypeRepository);
            // 
            // DepositeTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.ARC);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.depositDataGridView);
            this.Controls.Add(this.TXB_Currency);
            this.Controls.Add(this.TXB_DepositeRate);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Create);
            this.Name = "DepositeTypeForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.Click += new System.EventHandler(this.DepositeTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Create;
        private Button BTN_Delete;
        private Button BTN_Update;
        private BindingSource depositeTypeRepositoryBindingSource;
        private TextBox TXB_Name;
        private TextBox TXB_DepositeRate;
        private TextBox TXB_Currency;
        private DataGridView depositDataGridView;
        private BindingSource depositeTypeRepositoryBindingSource1;
        private BindingSource depositeTypeRepositoryBindingSource2;
        private Button LogOut;
        private Button ARC;
        private Label MyBank;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
