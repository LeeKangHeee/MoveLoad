﻿namespace MOVEROAD
{
    partial class HRManagement
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
            this.buttonAddUsers = new System.Windows.Forms.Button();
            this.buttonSearchUsers = new System.Windows.Forms.Button();
            this.buttonEditUsers = new System.Windows.Forms.Button();
            this.HRpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(235, 51);
            this.buttonAddUsers.TabIndex = 1;
            this.buttonAddUsers.Text = "사원 등록";
            this.buttonAddUsers.UseVisualStyleBackColor = true;
            this.buttonAddUsers.Click += new System.EventHandler(this.buttonAddUsers_Click);
            // 
            // buttonSearchUsers
            // 
            this.buttonSearchUsers.Location = new System.Drawing.Point(253, 12);
            this.buttonSearchUsers.Name = "buttonSearchUsers";
            this.buttonSearchUsers.Size = new System.Drawing.Size(235, 51);
            this.buttonSearchUsers.TabIndex = 3;
            this.buttonSearchUsers.Text = "사원 검색";
            this.buttonSearchUsers.UseVisualStyleBackColor = true;
            this.buttonSearchUsers.Click += new System.EventHandler(this.buttonSearchUsers_Click);
            // 
            // buttonEditUsers
            // 
            this.buttonEditUsers.Location = new System.Drawing.Point(498, 12);
            this.buttonEditUsers.Name = "buttonEditUsers";
            this.buttonEditUsers.Size = new System.Drawing.Size(235, 51);
            this.buttonEditUsers.TabIndex = 4;
            this.buttonEditUsers.Text = "사원 정보 수정";
            this.buttonEditUsers.UseVisualStyleBackColor = true;
            this.buttonEditUsers.Click += new System.EventHandler(this.buttonEditUsers_Click);
            // 
            // HRpanel
            // 
            this.HRpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HRpanel.Location = new System.Drawing.Point(0, 72);
            this.HRpanel.Name = "HRpanel";
            this.HRpanel.Size = new System.Drawing.Size(745, 340);
            this.HRpanel.TabIndex = 5;
            // 
            // HRManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.HRpanel);
            this.Controls.Add(this.buttonEditUsers);
            this.Controls.Add(this.buttonSearchUsers);
            this.Controls.Add(this.buttonAddUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRManagement";
            this.Text = "HRManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.Button buttonSearchUsers;
        private System.Windows.Forms.Button buttonEditUsers;
        private System.Windows.Forms.Panel HRpanel;
    }
}