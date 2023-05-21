using System.Drawing;
using System.Windows.Forms;

namespace MyBank.User_View
{
    partial class UserChangeForm
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
            this.TXB_Balance = new System.Windows.Forms.TextBox();
            this.TXB_Phone = new System.Windows.Forms.TextBox();
            this.TXB_Pass = new System.Windows.Forms.TextBox();
            this.TXB_Mail = new System.Windows.Forms.TextBox();
            this.TXB_Sname = new System.Windows.Forms.TextBox();
            this.TXB_Lname = new System.Windows.Forms.TextBox();
            this.TXB_Fname = new System.Windows.Forms.TextBox();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.DC = new System.Windows.Forms.Button();
            this.MyBank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_Balance
            // 
            this.TXB_Balance.Location = new System.Drawing.Point(165, 434);
            this.TXB_Balance.Name = "TXB_Balance";
            this.TXB_Balance.Size = new System.Drawing.Size(455, 20);
            this.TXB_Balance.TabIndex = 24;
            // 
            // TXB_Phone
            // 
            this.TXB_Phone.Location = new System.Drawing.Point(653, 379);
            this.TXB_Phone.Name = "TXB_Phone";
            this.TXB_Phone.Size = new System.Drawing.Size(455, 20);
            this.TXB_Phone.TabIndex = 23;
            // 
            // TXB_Pass
            // 
            this.TXB_Pass.Location = new System.Drawing.Point(654, 318);
            this.TXB_Pass.Name = "TXB_Pass";
            this.TXB_Pass.Size = new System.Drawing.Size(455, 20);
            this.TXB_Pass.TabIndex = 22;
            // 
            // TXB_Mail
            // 
            this.TXB_Mail.Location = new System.Drawing.Point(654, 257);
            this.TXB_Mail.Name = "TXB_Mail";
            this.TXB_Mail.Size = new System.Drawing.Size(455, 20);
            this.TXB_Mail.TabIndex = 21;
            // 
            // TXB_Sname
            // 
            this.TXB_Sname.Location = new System.Drawing.Point(164, 379);
            this.TXB_Sname.Name = "TXB_Sname";
            this.TXB_Sname.Size = new System.Drawing.Size(455, 20);
            this.TXB_Sname.TabIndex = 20;
            // 
            // TXB_Lname
            // 
            this.TXB_Lname.Location = new System.Drawing.Point(165, 318);
            this.TXB_Lname.Name = "TXB_Lname";
            this.TXB_Lname.Size = new System.Drawing.Size(455, 20);
            this.TXB_Lname.TabIndex = 19;
            // 
            // TXB_Fname
            // 
            this.TXB_Fname.Location = new System.Drawing.Point(165, 257);
            this.TXB_Fname.Name = "TXB_Fname";
            this.TXB_Fname.Size = new System.Drawing.Size(455, 20);
            this.TXB_Fname.TabIndex = 18;
            // 
            // BTN_Update
            // 
            this.BTN_Update.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Update.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Update.Location = new System.Drawing.Point(165, 468);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(943, 29);
            this.BTN_Update.TabIndex = 17;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // LogOut
            // 
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.Color.Lime;
            this.LogOut.Location = new System.Drawing.Point(1173, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(64, 28);
            this.LogOut.TabIndex = 25;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // DC
            // 
            this.DC.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.DC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DC.ForeColor = System.Drawing.Color.Lime;
            this.DC.Location = new System.Drawing.Point(1127, 626);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(113, 28);
            this.DC.TabIndex = 26;
            this.DC.Text = "Deposit Control";
            this.DC.UseVisualStyleBackColor = true;
            this.DC.Click += new System.EventHandler(this.DC_Click);
            // 
            // MyBank
            // 
            this.MyBank.AutoSize = true;
            this.MyBank.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.MyBank.ForeColor = System.Drawing.Color.Lime;
            this.MyBank.Location = new System.Drawing.Point(0, 3);
            this.MyBank.Name = "MyBank";
            this.MyBank.Size = new System.Drawing.Size(273, 89);
            this.MyBank.TabIndex = 27;
            this.MyBank.Text = "MyBank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(651, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(651, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(651, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(162, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Balance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(162, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Midle Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.ForeColor = System.Drawing.Color.Lime;
            this.label13.Location = new System.Drawing.Point(162, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(162, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "First Name";
            // 
            // UserChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.TXB_Balance);
            this.Controls.Add(this.TXB_Phone);
            this.Controls.Add(this.TXB_Pass);
            this.Controls.Add(this.TXB_Mail);
            this.Controls.Add(this.TXB_Sname);
            this.Controls.Add(this.TXB_Lname);
            this.Controls.Add(this.TXB_Fname);
            this.Controls.Add(this.BTN_Update);
            this.Name = "UserChangeForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.Load += new System.EventHandler(this.UserChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXB_Balance;
        private TextBox TXB_Phone;
        private TextBox TXB_Pass;
        private TextBox TXB_Mail;
        private TextBox TXB_Sname;
        private TextBox TXB_Lname;
        private TextBox TXB_Fname;
        private Button BTN_Update;
        private Button LogOut;
        private Button DC;
        private Label MyBank;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
