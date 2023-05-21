using System.Drawing;
using System.Windows.Forms;

namespace MyBank.Manager_View
{
    partial class ManagerControlForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.TXB_Phone = new System.Windows.Forms.TextBox();
            this.TXB_Pass = new System.Windows.Forms.TextBox();
            this.TXB_Mail = new System.Windows.Forms.TextBox();
            this.TXB_Sname = new System.Windows.Forms.TextBox();
            this.TXB_Lname = new System.Windows.Forms.TextBox();
            this.TXB_Fname = new System.Windows.Forms.TextBox();
            this.TXB_Balance = new System.Windows.Forms.TextBox();
            this.depositDataGridView = new System.Windows.Forms.DataGridView();
            this.TXB_DepositeRate = new System.Windows.Forms.TextBox();
            this.TXB_Currency = new System.Windows.Forms.TextBox();
            this.TXB_CountMonths = new System.Windows.Forms.TextBox();
            this.TXB_Amount = new System.Windows.Forms.TextBox();
            this.CB_TypeDeposite = new System.Windows.Forms.ComboBox();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.dateTimePickerE = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerS = new System.Windows.Forms.DateTimePicker();
            this.textBoxDepositRate = new System.Windows.Forms.TextBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.MyBank = new System.Windows.Forms.Label();
            this.TXB_Profit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.userGridView.Location = new System.Drawing.Point(94, 277);
            this.userGridView.Name = "userGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userGridView.RowTemplate.Height = 25;
            this.userGridView.Size = new System.Drawing.Size(728, 130);
            this.userGridView.TabIndex = 0;
            this.userGridView.SelectionChanged += new System.EventHandler(this.userGridView_SelectionChanged);
            // 
            // BTN_Update
            // 
            this.BTN_Update.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Update.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Update.Location = new System.Drawing.Point(94, 243);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(1028, 28);
            this.BTN_Update.TabIndex = 2;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // TXB_Phone
            // 
            this.TXB_Phone.Location = new System.Drawing.Point(683, 192);
            this.TXB_Phone.Name = "TXB_Phone";
            this.TXB_Phone.Size = new System.Drawing.Size(439, 20);
            this.TXB_Phone.TabIndex = 14;
            // 
            // TXB_Pass
            // 
            this.TXB_Pass.Location = new System.Drawing.Point(683, 166);
            this.TXB_Pass.Name = "TXB_Pass";
            this.TXB_Pass.Size = new System.Drawing.Size(439, 20);
            this.TXB_Pass.TabIndex = 13;
            // 
            // TXB_Mail
            // 
            this.TXB_Mail.Location = new System.Drawing.Point(683, 141);
            this.TXB_Mail.Name = "TXB_Mail";
            this.TXB_Mail.Size = new System.Drawing.Size(439, 20);
            this.TXB_Mail.TabIndex = 12;
            // 
            // TXB_Sname
            // 
            this.TXB_Sname.Location = new System.Drawing.Point(138, 192);
            this.TXB_Sname.Name = "TXB_Sname";
            this.TXB_Sname.Size = new System.Drawing.Size(439, 20);
            this.TXB_Sname.TabIndex = 11;
            // 
            // TXB_Lname
            // 
            this.TXB_Lname.Location = new System.Drawing.Point(138, 166);
            this.TXB_Lname.Name = "TXB_Lname";
            this.TXB_Lname.Size = new System.Drawing.Size(439, 20);
            this.TXB_Lname.TabIndex = 10;
            // 
            // TXB_Fname
            // 
            this.TXB_Fname.Location = new System.Drawing.Point(138, 141);
            this.TXB_Fname.Name = "TXB_Fname";
            this.TXB_Fname.Size = new System.Drawing.Size(439, 20);
            this.TXB_Fname.TabIndex = 9;
            // 
            // TXB_Balance
            // 
            this.TXB_Balance.Location = new System.Drawing.Point(138, 217);
            this.TXB_Balance.Name = "TXB_Balance";
            this.TXB_Balance.Size = new System.Drawing.Size(439, 20);
            this.TXB_Balance.TabIndex = 16;
            // 
            // depositDataGridView
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depositDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.depositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.depositDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.depositDataGridView.Location = new System.Drawing.Point(94, 432);
            this.depositDataGridView.Name = "depositDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depositDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.depositDataGridView.RowTemplate.Height = 25;
            this.depositDataGridView.Size = new System.Drawing.Size(264, 130);
            this.depositDataGridView.TabIndex = 29;
            this.depositDataGridView.SelectionChanged += new System.EventHandler(this.depositDataGridView_SelectionChanged);
            // 
            // TXB_DepositeRate
            // 
            this.TXB_DepositeRate.Location = new System.Drawing.Point(1024, 381);
            this.TXB_DepositeRate.Name = "TXB_DepositeRate";
            this.TXB_DepositeRate.ReadOnly = true;
            this.TXB_DepositeRate.Size = new System.Drawing.Size(98, 20);
            this.TXB_DepositeRate.TabIndex = 28;
            // 
            // TXB_Currency
            // 
            this.TXB_Currency.Location = new System.Drawing.Point(1024, 356);
            this.TXB_Currency.Name = "TXB_Currency";
            this.TXB_Currency.ReadOnly = true;
            this.TXB_Currency.Size = new System.Drawing.Size(98, 20);
            this.TXB_Currency.TabIndex = 27;
            // 
            // TXB_CountMonths
            // 
            this.TXB_CountMonths.Location = new System.Drawing.Point(1024, 406);
            this.TXB_CountMonths.Name = "TXB_CountMonths";
            this.TXB_CountMonths.Size = new System.Drawing.Size(98, 20);
            this.TXB_CountMonths.TabIndex = 26;
            // 
            // TXB_Amount
            // 
            this.TXB_Amount.Location = new System.Drawing.Point(1024, 432);
            this.TXB_Amount.Name = "TXB_Amount";
            this.TXB_Amount.Size = new System.Drawing.Size(98, 20);
            this.TXB_Amount.TabIndex = 23;
            // 
            // CB_TypeDeposite
            // 
            this.CB_TypeDeposite.FormattingEnabled = true;
            this.CB_TypeDeposite.Location = new System.Drawing.Point(1024, 329);
            this.CB_TypeDeposite.Name = "CB_TypeDeposite";
            this.CB_TypeDeposite.Size = new System.Drawing.Size(98, 21);
            this.CB_TypeDeposite.TabIndex = 22;
            this.CB_TypeDeposite.SelectedIndexChanged += new System.EventHandler(this.CB_DepositType_SelectedIndexChanged);
            // 
            // BTN_Close
            // 
            this.BTN_Close.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Close.Location = new System.Drawing.Point(531, 432);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(269, 32);
            this.BTN_Close.TabIndex = 21;
            this.BTN_Close.Text = "Close Deposit";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // BTN_Create
            // 
            this.BTN_Create.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Create.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Create.Location = new System.Drawing.Point(1024, 290);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(98, 27);
            this.BTN_Create.TabIndex = 20;
            this.BTN_Create.Text = "Create Deposit";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // dateTimePickerE
            // 
            this.dateTimePickerE.Location = new System.Drawing.Point(531, 497);
            this.dateTimePickerE.Name = "dateTimePickerE";
            this.dateTimePickerE.Size = new System.Drawing.Size(270, 20);
            this.dateTimePickerE.TabIndex = 30;
            // 
            // dateTimePickerS
            // 
            this.dateTimePickerS.Location = new System.Drawing.Point(531, 469);
            this.dateTimePickerS.Name = "dateTimePickerS";
            this.dateTimePickerS.Size = new System.Drawing.Size(270, 20);
            this.dateTimePickerS.TabIndex = 31;
            // 
            // textBoxDepositRate
            // 
            this.textBoxDepositRate.Location = new System.Drawing.Point(531, 524);
            this.textBoxDepositRate.Name = "textBoxDepositRate";
            this.textBoxDepositRate.Size = new System.Drawing.Size(270, 20);
            this.textBoxDepositRate.TabIndex = 32;
            // 
            // LogOut
            // 
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.Color.Lime;
            this.LogOut.Location = new System.Drawing.Point(1173, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(64, 27);
            this.LogOut.TabIndex = 33;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // MyBank
            // 
            this.MyBank.AutoSize = true;
            this.MyBank.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.MyBank.ForeColor = System.Drawing.Color.Lime;
            this.MyBank.Location = new System.Drawing.Point(3, 3);
            this.MyBank.Name = "MyBank";
            this.MyBank.Size = new System.Drawing.Size(273, 89);
            this.MyBank.TabIndex = 34;
            this.MyBank.Text = "MyBank";
            // 
            // TXB_Profit
            // 
            this.TXB_Profit.Location = new System.Drawing.Point(1024, 458);
            this.TXB_Profit.Name = "TXB_Profit";
            this.TXB_Profit.ReadOnly = true;
            this.TXB_Profit.Size = new System.Drawing.Size(98, 20);
            this.TXB_Profit.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(83, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(69, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Midle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(74, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(75, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(643, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(628, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(649, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(945, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Count Months";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(949, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Deposit Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(969, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Currency";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(987, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Profit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(975, 435);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(450, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Deposit Rate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(464, 497);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Final Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(464, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Start Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(948, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Type Deposit";
            // 
            // ManagerControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_Profit);
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.textBoxDepositRate);
            this.Controls.Add(this.dateTimePickerS);
            this.Controls.Add(this.dateTimePickerE);
            this.Controls.Add(this.depositDataGridView);
            this.Controls.Add(this.TXB_DepositeRate);
            this.Controls.Add(this.TXB_Currency);
            this.Controls.Add(this.TXB_CountMonths);
            this.Controls.Add(this.TXB_Amount);
            this.Controls.Add(this.CB_TypeDeposite);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Create);
            this.Controls.Add(this.TXB_Balance);
            this.Controls.Add(this.TXB_Phone);
            this.Controls.Add(this.TXB_Pass);
            this.Controls.Add(this.TXB_Mail);
            this.Controls.Add(this.TXB_Sname);
            this.Controls.Add(this.TXB_Lname);
            this.Controls.Add(this.TXB_Fname);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.userGridView);
            this.Name = "ManagerControlForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.Load += new System.EventHandler(this.BalanceUpdateTimer_Tick);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView userGridView;
        private Button BTN_Update;
        private TextBox TXB_Phone;
        private TextBox TXB_Pass;
        private TextBox TXB_Mail;
        private TextBox TXB_Sname;
        private TextBox TXB_Lname;
        private TextBox TXB_Fname;
        private TextBox TXB_Balance;
        private DataGridView depositDataGridView;
        private TextBox TXB_DepositeRate;
        private TextBox TXB_Currency;
        private TextBox TXB_CountMonths;
        private TextBox TXB_Amount;
        private ComboBox CB_TypeDeposite;
        private Button BTN_Close;
        private Button BTN_Create;
        private DateTimePicker dateTimePickerE;
        private DateTimePicker dateTimePickerS;
        private TextBox textBoxDepositRate;
        private Button LogOut;
        private Label MyBank;
        private TextBox TXB_Profit;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}
