﻿namespace Library_system
{
    partial class AdminLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 51);
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '*';
            this.loginBox.Size = new System.Drawing.Size(194, 20);
            this.loginBox.TabIndex = 1;
            this.loginBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginBox_KeyPress);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(70, 94);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(88, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 129);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button loginBtn;
    }
}