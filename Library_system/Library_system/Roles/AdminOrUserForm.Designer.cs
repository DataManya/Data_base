namespace Library_system
{
    partial class AdminOrUserForm
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
            this.adminBtn = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.adminBtn.Location = new System.Drawing.Point(203, 66);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(205, 48);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Администратор";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            //  
            // userBtn
            // 
            this.userBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.userBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.userBtn.Location = new System.Drawing.Point(205, 157);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(205, 50);
            this.userBtn.TabIndex = 1;
            this.userBtn.Text = "Пользователь";
            this.userBtn.UseVisualStyleBackColor = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите роль для доступа к системе:";
            // 
            // AdminOrUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.adminBtn);
            this.Name = "AdminOrUserForm";
            this.Text = "AdminOrUserForm";
            this.Load += new System.EventHandler(this.AdminOrUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Label label1;
    }
}