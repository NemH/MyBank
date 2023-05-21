using System.Drawing;
using System.Windows.Forms;

namespace MyBank.User_View
{
    partial class LoginForm
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
            this.BTN_Reg = new System.Windows.Forms.Button();
            this.TXB_Email = new System.Windows.Forms.TextBox();
            this.TXB_Pass = new System.Windows.Forms.TextBox();
            this.BTN_Log = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.MyBank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Reg
            // 
            this.BTN_Reg.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Reg.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reg.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Reg.Location = new System.Drawing.Point(1172, 3);
            this.BTN_Reg.Name = "BTN_Reg";
            this.BTN_Reg.Size = new System.Drawing.Size(65, 38);
            this.BTN_Reg.TabIndex = 1;
            this.BTN_Reg.Text = "Reg";
            this.BTN_Reg.UseVisualStyleBackColor = false;
            this.BTN_Reg.Click += new System.EventHandler(this.BTN_Reg_Click);
            // 
            // TXB_Email
            // 
            this.TXB_Email.Location = new System.Drawing.Point(485, 233);
            this.TXB_Email.Name = "TXB_Email";
            this.TXB_Email.Size = new System.Drawing.Size(274, 20);
            this.TXB_Email.TabIndex = 3;
            // 
            // TXB_Pass
            // 
            this.TXB_Pass.Location = new System.Drawing.Point(485, 307);
            this.TXB_Pass.Name = "TXB_Pass";
            this.TXB_Pass.Size = new System.Drawing.Size(274, 20);
            this.TXB_Pass.TabIndex = 4;
            // 
            // BTN_Log
            // 
            this.BTN_Log.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_Log.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BTN_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Log.ForeColor = System.Drawing.Color.Lime;
            this.BTN_Log.Location = new System.Drawing.Point(547, 504);
            this.BTN_Log.Name = "BTN_Log";
            this.BTN_Log.Size = new System.Drawing.Size(146, 38);
            this.BTN_Log.TabIndex = 7;
            this.BTN_Log.Text = "Login";
            this.BTN_Log.UseVisualStyleBackColor = false;
            this.BTN_Log.Click += new System.EventHandler(this.BTN_Log_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(482, 337);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 8;
            // 
            // MyBank
            // 
            this.MyBank.AutoSize = true;
            this.MyBank.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.MyBank.ForeColor = System.Drawing.Color.Lime;
            this.MyBank.Location = new System.Drawing.Point(3, 3);
            this.MyBank.Name = "MyBank";
            this.MyBank.Size = new System.Drawing.Size(273, 89);
            this.MyBank.TabIndex = 9;
            this.MyBank.Text = "MyBank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(487, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(487, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyBank);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.BTN_Log);
            this.Controls.Add(this.TXB_Pass);
            this.Controls.Add(this.TXB_Email);
            this.Controls.Add(this.BTN_Reg);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(1240, 657);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_Reg;
        private TextBox TXB_Email;
        private TextBox TXB_Pass;
        private Button BTN_Log;
        private Label Label;
        private Label MyBank;
        private Label label1;
        private Label label3;
    }
}
