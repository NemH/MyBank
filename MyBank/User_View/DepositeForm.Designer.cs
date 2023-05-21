using System.Drawing;
using System.Windows.Forms;

namespace MyBank.User_View
{
    partial class DepositeForm
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
            if (disposing && components != null)
            {
                components.Dispose();
                balanceUpdateTimer.Stop();
                balanceUpdateTimer.Dispose();
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
            this.L_Balance = new System.Windows.Forms.Label();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.CB_TypeDeposite = new System.Windows.Forms.ComboBox();
            this.TXB_Amount = new System.Windows.Forms.TextBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_CountMonths = new System.Windows.Forms.TextBox();
            this.TXB_Currency = new System.Windows.Forms.TextBox();
            this.TXB_DepositeRate = new System.Windows.Forms.TextBox();
            this.depositDataGridView = new System.Windows.Forms.DataGridView();
            this.TXB_Balance = new System.Windows.Forms.TextBox();
            this.Ci = new System.Windows.Forms.Button();
            this.MyBank = new System.Windows.Forms.Label();
            this.TXB_Profit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.depositeTypeRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Balance
            // 
            this.L_Balance.AutoSize = true;
            this.L_Balance.ForeColor = System.Drawing.SystemColors.Control;
            this.L_Balance.Location = new System.Drawing.Point(74, 176);
            this.L_Balance.Name = "L_Balance";
            this.L_Balance.Size = new System.Drawing.Size(0, 13);
            this.L_Balance.TabIndex = 0;
            // 
            // BTN_Create
            // 
            this.BTN_Create.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Create.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Create.Location = new System.Drawing.Point(798, 246);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(327, 22);
            this.BTN_Create.TabIndex = 1;
            this.BTN_Create.Text = "Create Deposit";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Close.Location = new System.Drawing.Point(99, 364);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(561, 37);
            this.BTN_Close.TabIndex = 2;
            this.BTN_Close.Text = "Close Deposit";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // CB_TypeDeposite
            // 
            this.CB_TypeDeposite.FormattingEnabled = true;
            this.CB_TypeDeposite.Location = new System.Drawing.Point(798, 296);
            this.CB_TypeDeposite.Name = "CB_TypeDeposite";
            this.CB_TypeDeposite.Size = new System.Drawing.Size(327, 21);
            this.CB_TypeDeposite.TabIndex = 3;
            this.CB_TypeDeposite.Click += new System.EventHandler(this.CB_TypeDeposite_SelectedIndexChanged);
            // 
            // TXB_Amount
            // 
            this.TXB_Amount.Location = new System.Drawing.Point(798, 323);
            this.TXB_Amount.Name = "TXB_Amount";
            this.TXB_Amount.Size = new System.Drawing.Size(327, 20);
            this.TXB_Amount.TabIndex = 4;
            // 
            // LogOut
            // 
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.Color.Lime;
            this.LogOut.Location = new System.Drawing.Point(1173, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(64, 28);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(802, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Balance";
            // 
            // TXB_CountMonths
            // 
            this.TXB_CountMonths.Location = new System.Drawing.Point(798, 348);
            this.TXB_CountMonths.Name = "TXB_CountMonths";
            this.TXB_CountMonths.Size = new System.Drawing.Size(327, 20);
            this.TXB_CountMonths.TabIndex = 8;
            // 
            // TXB_Currency
            // 
            this.TXB_Currency.Location = new System.Drawing.Point(798, 373);
            this.TXB_Currency.Name = "TXB_Currency";
            this.TXB_Currency.ReadOnly = true;
            this.TXB_Currency.Size = new System.Drawing.Size(327, 20);
            this.TXB_Currency.TabIndex = 9;
            // 
            // TXB_DepositeRate
            // 
            this.TXB_DepositeRate.Location = new System.Drawing.Point(798, 399);
            this.TXB_DepositeRate.Name = "TXB_DepositeRate";
            this.TXB_DepositeRate.ReadOnly = true;
            this.TXB_DepositeRate.Size = new System.Drawing.Size(327, 20);
            this.TXB_DepositeRate.TabIndex = 10;
            // 
            // depositDataGridView
            // 
            this.depositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositDataGridView.Location = new System.Drawing.Point(99, 229);
            this.depositDataGridView.Name = "depositDataGridView";
            this.depositDataGridView.RowTemplate.Height = 25;
            this.depositDataGridView.Size = new System.Drawing.Size(561, 130);
            this.depositDataGridView.TabIndex = 11;
            // 
            // TXB_Balance
            // 
            this.TXB_Balance.Location = new System.Drawing.Point(851, 209);
            this.TXB_Balance.Name = "TXB_Balance";
            this.TXB_Balance.ReadOnly = true;
            this.TXB_Balance.Size = new System.Drawing.Size(274, 20);
            this.TXB_Balance.TabIndex = 12;
            // 
            // Ci
            // 
            this.Ci.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.Ci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ci.ForeColor = System.Drawing.Color.Lime;
            this.Ci.Location = new System.Drawing.Point(1124, 630);
            this.Ci.Name = "Ci";
            this.Ci.Size = new System.Drawing.Size(113, 24);
            this.Ci.TabIndex = 27;
            this.Ci.Text = "Change Info";
            this.Ci.UseVisualStyleBackColor = true;
            this.Ci.Click += new System.EventHandler(this.Ci_Click);
            // 
            // MyBank
            // 
            this.MyBank.AutoSize = true;
            this.MyBank.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.MyBank.ForeColor = System.Drawing.Color.Lime;
            this.MyBank.Location = new System.Drawing.Point(3, 3);
            this.MyBank.Name = "MyBank";
            this.MyBank.Size = new System.Drawing.Size(273, 89);
            this.MyBank.TabIndex = 28;
            this.MyBank.Text = "MyBank";
            // 
            // TXB_Profit
            // 
            this.TXB_Profit.Location = new System.Drawing.Point(798, 424);
            this.TXB_Profit.Name = "TXB_Profit";
            this.TXB_Profit.ReadOnly = true;
            this.TXB_Profit.Size = new System.Drawing.Size(327, 20);
            this.TXB_Profit.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(722, 299);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Type Deposit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(761, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Profit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(749, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(719, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Count Months";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(723, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Deposit Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(743, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Currency";
            // 
            // depositeTypeRepositoryBindingSource
            // 
            this.depositeTypeRepositoryBindingSource.DataSource = typeof(MyBank.Repository.DepositeTypeRepository);
            // 
            // DepositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXB_Profit);
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.Ci);
            this.Controls.Add(this.TXB_Balance);
            this.Controls.Add(this.depositDataGridView);
            this.Controls.Add(this.TXB_DepositeRate);
            this.Controls.Add(this.TXB_Currency);
            this.Controls.Add(this.TXB_CountMonths);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.TXB_Amount);
            this.Controls.Add(this.CB_TypeDeposite);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Create);
            this.Controls.Add(this.L_Balance);
            this.Name = "DepositeForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.Load += new System.EventHandler(this.DepositeForm_Load);
            this.MouseEnter += new System.EventHandler(this.BalanceUpdateTimer_Tick);
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositeTypeRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label L_Balance;
        private Button BTN_Create;
        private Button BTN_Close;
        private ComboBox CB_TypeDeposite;
        private TextBox TXB_Amount;
        private Button LogOut;
        private Label label1;
        private TextBox TXB_CountMonths;
        private BindingSource depositeTypeRepositoryBindingSource;
        private TextBox TXB_Currency;
        private TextBox TXB_DepositeRate;
        private DataGridView depositDataGridView;
        private TextBox TXB_Balance;
        private Button Ci;
        private Label MyBank;
        private TextBox TXB_Profit;
        private Label label16;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
