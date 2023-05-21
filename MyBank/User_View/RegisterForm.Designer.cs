using System.Drawing;
using System.Windows.Forms;

namespace MyBank.User_View
{
    partial class RegisterForm
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
            this.BTN_Log = new System.Windows.Forms.Button();
            this.BTN_Reg = new System.Windows.Forms.Button();
            this.TXB_Fname = new System.Windows.Forms.TextBox();
            this.TXB_Lname = new System.Windows.Forms.TextBox();
            this.TXB_Sname = new System.Windows.Forms.TextBox();
            this.TXB_Phone = new System.Windows.Forms.TextBox();
            this.TXB_Pass = new System.Windows.Forms.TextBox();
            this.TXB_Mail = new System.Windows.Forms.TextBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.Label = new System.Windows.Forms.Label();
            this.MyBank = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Log
            // 
            this.BTN_Log.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Log.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Log.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Log.Location = new System.Drawing.Point(1146, 3);
            this.BTN_Log.Name = "BTN_Log";
            this.BTN_Log.Size = new System.Drawing.Size(91, 44);
            this.BTN_Log.TabIndex = 0;
            this.BTN_Log.Text = "Log in";
            this.BTN_Log.UseVisualStyleBackColor = false;
            this.BTN_Log.Click += new System.EventHandler(this.BTN_Log_Click);
            // 
            // BTN_Reg
            // 
            this.BTN_Reg.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Reg.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reg.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Reg.Location = new System.Drawing.Point(529, 565);
            this.BTN_Reg.Name = "BTN_Reg";
            this.BTN_Reg.Size = new System.Drawing.Size(159, 44);
            this.BTN_Reg.TabIndex = 1;
            this.BTN_Reg.Text = "Create now";
            this.BTN_Reg.UseVisualStyleBackColor = false;
            this.BTN_Reg.Click += new System.EventHandler(this.BTN_Reg_Click);
            // 
            // TXB_Fname
            // 
            this.TXB_Fname.BackColor = System.Drawing.Color.White;
            this.TXB_Fname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXB_Fname.Location = new System.Drawing.Point(454, 169);
            this.TXB_Fname.Name = "TXB_Fname";
            this.TXB_Fname.Size = new System.Drawing.Size(328, 20);
            this.TXB_Fname.TabIndex = 2;
            // 
            // TXB_Lname
            // 
            this.TXB_Lname.BackColor = System.Drawing.Color.White;
            this.TXB_Lname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXB_Lname.Location = new System.Drawing.Point(454, 212);
            this.TXB_Lname.Name = "TXB_Lname";
            this.TXB_Lname.Size = new System.Drawing.Size(328, 20);
            this.TXB_Lname.TabIndex = 3;
            // 
            // TXB_Sname
            // 
            this.TXB_Sname.BackColor = System.Drawing.Color.White;
            this.TXB_Sname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXB_Sname.Location = new System.Drawing.Point(454, 261);
            this.TXB_Sname.Name = "TXB_Sname";
            this.TXB_Sname.Size = new System.Drawing.Size(328, 20);
            this.TXB_Sname.TabIndex = 4;
            // 
            // TXB_Phone
            // 
            this.TXB_Phone.BackColor = System.Drawing.Color.White;
            this.TXB_Phone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXB_Phone.Location = new System.Drawing.Point(454, 404);
            this.TXB_Phone.Name = "TXB_Phone";
            this.TXB_Phone.Size = new System.Drawing.Size(328, 20);
            this.TXB_Phone.TabIndex = 7;
            // 
            // TXB_Pass
            // 
            this.TXB_Pass.BackColor = System.Drawing.Color.White;
            this.TXB_Pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXB_Pass.Location = new System.Drawing.Point(454, 358);
            this.TXB_Pass.Name = "TXB_Pass";
            this.TXB_Pass.Size = new System.Drawing.Size(328, 20);
            this.TXB_Pass.TabIndex = 6;
            // 
            // TXB_Mail
            // 
            this.TXB_Mail.AllowDrop = true;
            this.TXB_Mail.BackColor = System.Drawing.Color.White;
            this.TXB_Mail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TXB_Mail.Location = new System.Drawing.Point(454, 311);
            this.TXB_Mail.Name = "TXB_Mail";
            this.TXB_Mail.Size = new System.Drawing.Size(328, 20);
            this.TXB_Mail.TabIndex = 5;
            // 
            // DTP
            // 
            this.DTP.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.DTP.CalendarTitleBackColor = System.Drawing.Color.Lime;
            this.DTP.CalendarTitleForeColor = System.Drawing.Color.Lime;
            this.DTP.Location = new System.Drawing.Point(454, 454);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(328, 20);
            this.DTP.TabIndex = 8;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(335, 345);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 9;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(451, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Birthday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(451, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Midle Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(451, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(451, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(451, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(451, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(451, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Email";
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.TXB_Phone);
            this.Controls.Add(this.TXB_Pass);
            this.Controls.Add(this.TXB_Mail);
            this.Controls.Add(this.TXB_Sname);
            this.Controls.Add(this.TXB_Lname);
            this.Controls.Add(this.TXB_Fname);
            this.Controls.Add(this.BTN_Reg);
            this.Controls.Add(this.BTN_Log);
            this.Name = "RegisterForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Log;
        private Button BTN_Reg;
        private TextBox TXB_Fname;
        private TextBox TXB_Lname;
        private TextBox TXB_Sname;
        private TextBox TXB_Phone;
        private TextBox TXB_Pass;
        private TextBox TXB_Mail;
        private DateTimePicker DTP;
        private Label Label;
        private Label MyBank;
        private Label label6;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label5;
        private Label label9;
        private Label label10;
    }
}
